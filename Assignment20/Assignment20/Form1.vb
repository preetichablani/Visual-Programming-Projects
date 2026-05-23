Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim showPass As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Beige
        Label1.Text = "PERFECT PASSWORD CHECKER"
        Label2.Text = "Password"
        Label3.Text = "Confirm Password"
        Label4.Text = "Password Strength :-"
        Label5.Text = ""
        Button1.Text = "RESET"
        TextBox1.PasswordChar = "*"
        TextBox2.PasswordChar = "*"
        Label1.ForeColor = Color.DarkBlue
        Label2.ForeColor = Color.FromArgb(30, 41, 59)
        Label3.ForeColor = Color.FromArgb(30, 41, 59)
        Label4.ForeColor = Color.FromArgb(71, 85, 105)
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
        TextBox2.ForeColor = Color.Black
        Button1.BackColor = Color.DarkBlue
        Button1.ForeColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim pass As String
        pass = TextBox1.Text
        If pass.Length >= 8 And
           pass Like "*[A-Z]*" And
           pass Like "*[0-9]*" And
           pass Like "*[@#$&]*" Then
            Label5.Text = "Password is Perfect"
            Label5.ForeColor = Color.Blue
            ProgressBar1.Value = 100
            ProgressBar1.BackColor = Color.DarkBlue
            TextBox1.BackColor = Color.FromArgb(220, 252, 231)

        ElseIf pass.Length >= 5 Then
            Label5.Text = "Password is Average"
            Label5.ForeColor = Color.DarkOrange
            ProgressBar1.Value = 50
            ProgressBar1.BackColor = Color.DarkOrange
            TextBox1.BackColor = Color.FromArgb(254, 249, 195)

        Else
            Label5.Text = "Password is Weak"
            Label5.ForeColor = Color.Green
            ProgressBar1.Value = 30
            ProgressBar1.BackColor = Color.Green
            TextBox1.BackColor = Color.FromArgb(254, 226, 226)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Exit Sub
        End If
        If TextBox2.Text.Length = TextBox1.Text.Length Then
            If TextBox1.Text = TextBox2.Text Then
                MessageBox.Show("Password Correct", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox2.BackColor = Color.FromArgb(220, 252, 231)
            Else
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox2.BackColor = Color.FromArgb(254, 226, 226)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label5.Text = ""
        Label4.Text = "Password Strength :-"
        ProgressBar1.Value = 0
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox1.PasswordChar = "*"
        TextBox2.PasswordChar = "*"
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        showPass = Not showPass
        If showPass = True Then
            TextBox1.PasswordChar = ""
            TextBox2.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class