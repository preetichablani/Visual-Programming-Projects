Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=logindb")
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "LOGIN DETAILS"
        Me.Text = "Develop By - Preeti Chablani"
        Label1.ForeColor = Color.DarkBlue
        Label2.Text = "Username"
        Label3.Text = "Password"
        TextBox2.PasswordChar = "*"
        Button1.Text = "LOGIN"
        Button2.Text = "CLOSE"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd As New MySqlCommand("select * from employee where username=@u and password=@p", con)
        cmd.Parameters.AddWithValue("@u", TextBox1.Text)
        cmd.Parameters.AddWithValue("@p", TextBox2.Text)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        If dr.Read Then
            MessageBox.Show("Login Successful")
            Form4.Label1.Text = "WELCOME ADMIN, " & dr("firstname").ToString()
            Form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username or Password")
        End If
        con.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class