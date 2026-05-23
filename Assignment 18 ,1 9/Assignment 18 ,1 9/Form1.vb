Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "EMPLOYEE DETAILS"
        Label1.ForeColor = Color.DarkBlue
        Button1.Text = "SIGN IN"
        Button2.Text = "LOG IN"
        Me.Text = "Develop By - Preeti Chablani"
        Me.BackColor = Color.WhiteSmoke
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = New Size(800, 500)
        Button1.BackColor = Color.RoyalBlue
        Button1.ForeColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Width = 220
        Button1.Height = 70
        Button1.Left = 270
        Button1.Top = 120
        Button2.BackColor = Color.MediumSeaGreen
        Button2.ForeColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Width = 220
        Button2.Height = 70
        Button2.Left = 270
        Button2.Top = 230
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class