Imports System
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Security.Permissions
Imports System.Runtime.InteropServices

Public Class Pesquisar
    Const ErroCompartilhamento As Integer = 32
    Const ErroLock As Integer = 33

    Public Shared Property Caminho As String
    Public Shared Property Departamento As Integer

    Public Shared Sub Executar()
        Verificando()
    End Sub

    <PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
    Public Shared Sub Verificando()
        Dim objFSW As New FileSystemWatcher()

        With objFSW
            .Path = Caminho
            .NotifyFilter = (NotifyFilters.LastAccess Or NotifyFilters.LastWrite Or NotifyFilters.FileName Or NotifyFilters.DirectoryName)
            .Filter = "*.*"

            AddHandler .Changed, AddressOf OnChanged
            AddHandler .Created, AddressOf OnChanged

            .EnableRaisingEvents = True
        End With
    End Sub

    Private Shared Sub OnChanged(source As Object, e As FileSystemEventArgs)
        Dim bolRenomear As Boolean = False

        If Not File.Exists(e.FullPath) Then Exit Sub

        If e.ChangeType = WatcherChangeTypes.Changed Then
            Do While ArquivoEmUso(e.FullPath)
                '---> Enquanto gravar arquivo
            Loop

            Dim ArqInfo As New FileInfo(e.FullPath)
            Dim objStream As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read)
            Dim objBinaryReader As New BinaryReader(objStream)
            Dim objBytes As Byte() = objBinaryReader.ReadBytes(CInt(objStream.Length))
            objBinaryReader.Close()
            objStream.Close()
            objBinaryReader = Nothing
            objStream = Nothing

            Dim objSQLProc As New SQLTransact
            With objSQLProc
                .Limpar()
                .TSQL_Nome = "doc.spGravarPendencia"
                .TSQL_RetornoSolicitar = False
                .TSQL_Parametros = {"@IDDepartamento", "@ArqPendNome", "@ArqPendBin", "@DocInfDesc", "@DocInfNom", "@DocInfExt", "@DocInfLoc", "@DocInfTam", "@DocInfDtCri", "@DocInfDtUltAlt"}
                .TSQL_Valores = {Departamento, e.Name, objBytes, ArqInfo.Name, ArqInfo.Name, ArqInfo.Extension, ArqInfo.DirectoryName, ArqInfo.Length, Mid(ArqInfo.CreationTime.ToShortDateString, 4, 2) & "/" & Mid(ArqInfo.CreationTime.ToShortDateString, 1, 2) & "/" & Mid(ArqInfo.CreationTime.ToShortDateString, 7, 4) & Mid(ArqInfo.CreationTime.ToShortDateString, 11, 9), Mid(ArqInfo.LastWriteTime.ToShortDateString, 4, 2) & "/" & Mid(ArqInfo.LastWriteTime.ToShortDateString, 1, 2) & "/" & Mid(ArqInfo.LastWriteTime.ToShortDateString, 7, 4) & Mid(ArqInfo.LastWriteTime.ToShortDateString, 11, 9)}
                .ExecutarProcedure()
            End With

            File.Delete(e.FullPath)
        End If
    End Sub

    Public Shared Function ArquivoEmUso(ByVal parArquivo As String) As Boolean
        If File.Exists(parArquivo) = True Then
            Dim objStream As FileStream = Nothing
            Dim intErro As Integer = 0

            Try
                objStream = File.Open(parArquivo, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
            Catch errStream As Exception
                intErro = Marshal.GetHRForException(errStream) And ((1 << 16) - 1)

                If (TypeOf errStream Is IOException) AndAlso (intErro = ErroCompartilhamento OrElse intErro = ErroLock) Then Return True
            Finally
                If objStream IsNot Nothing Then objStream.Close()
            End Try
        End If

        Return False
    End Function
End Class
