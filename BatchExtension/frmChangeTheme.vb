Public Class frmChangeTheme

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmMain.colorCode = 0
        frmMain.setTheme(0)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmMain.colorCode = 1
        frmMain.setTheme(1)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmMain.colorCode = 2
        frmMain.setTheme(2)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmMain.colorCode = 3
        frmMain.setTheme(3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmMain.colorCode = 4
        frmMain.setTheme(4)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmMain.colorCode = 5
        frmMain.setTheme(5)
    End Sub
End Class