Public Class frmSplashScreen

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Version " & My.Application.Info.Version.ToString
    End Sub
End Class