Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBox1.Top = 0
        PictureBox1.Left = 0

        PictureBox1.ImageLocation = "C:\!Delete\書籍１\Page0015.jpg"

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        PictureBox1.Width = Me.ClientSize.Width
        PictureBox1.Height = Me.ClientSize.Height

    End Sub
End Class
