Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class SQLTransact
    Implements IDisposable

    Public Property Servidor_Nome As String
    Public Property Servidor_Catalogo As String
    Public Property Servidor_Usuario As String
    Public Property Servidor_Senha As String
    Public Property Servidor_PersistirSeguranca As Boolean
    Public Property SQL_Servidor As New SqlConnectionStringBuilder
    Public Property SQL_Conexao As New SqlConnection
    Public Property SQL_Comando As New SqlCommand
    Public Property SQL_Transacao As SqlTransaction
    Public Property SQL_Stream As SqlFileStream
    Public Property TSQL_Nome As String
    Public Property TSQL_Parametros As Array
    Public Property TSQL_Valores As Array
    Public Property TSQL_Retorno As Object
    Public Property TSQL_RetornoNome As String
    Public Property TSQL_RetornoTipo As New SqlDbType
    Public Property TSQL_RetornoSolicitar As Boolean
    Public Property RegistrosAfetados As Integer
    Public Property TSQL_ExecutarReader As Boolean
    Public Property SQL_ReaderReturn As SqlDataReader

    Sub New()
        If Servidor_Nome = "" Then
            Servidor_Nome = "MCBMSAPP01.MAGNA.GLOBAL\SINCRODOC"
            Servidor_Catalogo = "SINCRODOC"
            Servidor_Usuario = "SA"
            Servidor_Senha = "S1ncro*240"
            Servidor_PersistirSeguranca = True
        End If

        Servidor()
    End Sub

    ''' <summary>
    ''' Definir servidor de banco de dados
    ''' </summary>
    ''' <returns>String contendo a conexão de dados</returns>
    Public Function Servidor() As String
        With SQL_Servidor
            .DataSource = Servidor_Nome
            .InitialCatalog = Servidor_Catalogo
            .UserID = Servidor_Usuario
            .Password = Servidor_Senha
            .PersistSecurityInfo = Servidor_PersistirSeguranca
        End With

        Return SQL_Servidor.ConnectionString
    End Function

    ''' <summary>
    ''' Estabelecer a conexão de dados com o servidor parametrizado
    ''' </summary>
    ''' <returns>True - Se conectado, senão False</returns>
    Public Function Conectar() As Boolean
        Try
            With _SQL_Conexao
                .ConnectionString = Servidor()

                If .State = ConnectionState.Closed Then .Open()

                Return True
            End With
        Catch errSQL_Conexao As Exception
            MsgBox("Não foi possível estabelecer conexão com a base de dados!" & Chr(13) & "Informe o Suporte Técnico Interactivity.")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Executar Stored Procedure (PLSQL)
    ''' </summary>
    ''' <returns>True se executado com sucesso, senão False</returns>
    Public Function ExecutarProcedure() As Boolean
        Try
            If SQL_Conexao.State = ConnectionState.Closed Then Conectar()

            Using SQLStoredProcedure As New SqlCommand()
                With SQLStoredProcedure
                    .Connection = SQL_Conexao
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = TSQL_Nome

                    For intP As Integer = 0 To (TSQL_Parametros.Length - 1)
                        Dim objParametro As New SqlParameter(TSQL_Parametros(intP).ToString, IIf(TSQL_Valores(intP) Is Nothing, vbNull, TSQL_Valores(intP)))

                        .Parameters.Add(objParametro)

                        objParametro = Nothing
                    Next intP

                    If TSQL_RetornoSolicitar Then
                        Dim objParametroRetorno As New SqlParameter(TSQL_RetornoNome, TSQL_RetornoTipo)
                        objParametroRetorno.Direction = ParameterDirection.Output

                        .Parameters.Add(objParametroRetorno)
                    End If

                    If SQL_Conexao.State = ConnectionState.Closed Then Conectar()

                    If TSQL_ExecutarReader Then
                        SQL_ReaderReturn = Nothing
                        SQL_ReaderReturn = .ExecuteReader()
                    Else
                        RegistrosAfetados = .ExecuteNonQuery()
                    End If

                    If TSQL_RetornoSolicitar Then TSQL_Retorno = .Parameters(TSQL_RetornoNome).Value
                End With
            End Using

            ExecutarProcedure = True
        Catch errSQL_ExecutarProcedure As Exception
            MsgBox(errSQL_ExecutarProcedure.Message)
            RegistrosAfetados = -1
            ExecutarProcedure = False
        Finally
            If SQL_Conexao.State = ConnectionState.Open And TSQL_ExecutarReader = False Then SQL_Conexao.Close()
        End Try

FimPorReader:
        Return ExecutarProcedure
    End Function

    Public Function Limpar() As Boolean
        Limpar = True
        Servidor_Nome = "MCBMSAPP01.MAGNA.GLOBAL\SINCRODOC"
        Servidor_Catalogo = "SINCRODOC"
        Servidor_Usuario = "SA"
        Servidor_Senha = "S1ncro*240"
        Servidor_PersistirSeguranca = True
        SQL_Servidor = New SqlConnectionStringBuilder
        SQL_Conexao = New SqlConnection
        SQL_ReaderReturn = Nothing
        TSQL_Nome = ""
        TSQL_Retorno = ""
        TSQL_RetornoTipo = New SqlDbType
        TSQL_RetornoSolicitar = False
        TSQL_ExecutarReader = False
        If TSQL_Parametros IsNot Nothing Then Array.Clear(TSQL_Parametros, 0, (TSQL_Parametros.Length - 1))
        If TSQL_Parametros IsNot Nothing Then Array.Clear(TSQL_Valores, 0, (TSQL_Parametros.Length - 1))
        RegistrosAfetados = 0
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class