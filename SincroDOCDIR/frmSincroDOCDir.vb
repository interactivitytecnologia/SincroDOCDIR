Imports System.ComponentModel

Partial Public Class frmSincroDOCDir

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmSincroDOCDir_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub frmSincroDOCDir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Debugger.IsAttached Then
            Dim vetParametros() As String = System.Environment.GetCommandLineArgs()

            If vetParametros.Length <> 3 Then
                MsgBox("Directory not is defined!" & Chr(13) & "Use like exemple: SincroDOCDIR.exe C:\MyLocal 89", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "SincroDOC Directory")
                Me.Close()
            Else
                lblLocal.Text = vetParametros(1)
                lblDepartamento.Text = vetParametros(2)
            End If
        Else
            lblLocal.Text = "Z:\Diretoria"
            lblDepartamento.Text = "5"
        End If
    End Sub

    Private Sub frmSincroDOCDir_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()

        Dim FSW As New Pesquisar
        Pesquisar.Caminho = lblLocal.Text
        Pesquisar.Departamento = 5
        Pesquisar.Executar()
    End Sub

End Class
