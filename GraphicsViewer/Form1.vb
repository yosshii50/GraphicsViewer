Public Class Form1

    Dim FileNameList() As String
    Dim NowPos As Integer

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated


        On Error Resume Next
        'Dim WrkFileList As String() = System.IO.Directory.GetFiles("C:\!Delete\書籍１", "*.jpg")
        FileNameList = System.IO.Directory.GetFiles("C:\!Delete\書籍１", "*.jpg")
        On Error GoTo 0

        NowPos = 0
        Call ImageView(NowPos)

    End Sub

    Private Sub ImageView(ByRef WrkPos As Integer)

        If WrkPos < 0 Then
            WrkPos = 0
        End If
        If WrkPos >= FileNameList.Count Then
            WrkPos = FileNameList.Count - 1
        End If

        PictureBox1.ImageLocation = FileNameList(WrkPos)
        PictureBox2.ImageLocation = FileNameList(WrkPos + 1)
        PictureBox1.Refresh()
        PictureBox2.Refresh()
        Me.Text = WrkPos + 1 & "/" & FileNameList.Count

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                NowPos = NowPos - 1
                Call ImageView(NowPos)
            Case Keys.Right
                NowPos = NowPos + 1
                Call ImageView(NowPos)
            Case Keys.Up
                NowPos = NowPos - 2
                Call ImageView(NowPos)
            Case Keys.Down
                NowPos = NowPos + 2
                Call ImageView(NowPos)
            Case Keys.PageUp
                NowPos = 0
                Call ImageView(NowPos)
            Case Keys.Next
                NowPos = FileNameList.Count - 1
                Call ImageView(NowPos)
            Case Else
                Debug.WriteLine(e.KeyCode)
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBox1.Top = 0
        PictureBox1.Left = 0

        PictureBox2.Top = 0

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        PictureBox1.Width = Me.ClientSize.Width / 2
        PictureBox1.Height = Me.ClientSize.Height

        PictureBox2.Left = PictureBox1.Width
        PictureBox2.Width = Me.ClientSize.Width / 2
        PictureBox2.Height = Me.ClientSize.Height

    End Sub
End Class
