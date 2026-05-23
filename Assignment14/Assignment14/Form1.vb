Imports System.Diagnostics
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Webpage - Preeti Chablani"
        Me.BackColor = Color.FromArgb(245, 247, 250)
        Panel1.BackColor = Color.FromArgb(44, 62, 80)
        Label1.Text = "Preeti Chablani"
        Label1.ForeColor = Color.White
        Label2.Text = "Web Developer Designer"
        Label2.ForeColor = Color.Gainsboro
        Label3.Text = "Contact"
        Label3.BackColor = Color.FromArgb(231, 76, 60)
        Label3.ForeColor = Color.White
        Label7.Text = "8233730139"
        Label8.Text = "preetichablani2006@gmail.com"
        Label9.Text = "Ram Nagar Ajmer, Rajasthan"
        Label4.Text = "Education"
        Label4.BackColor = Color.FromArgb(231, 76, 60)
        Label4.ForeColor = Color.White
        Label10.Text = "Bachelor of Computer Application (BCA)"
        Label10.ForeColor = Color.Maroon
        Label5.Text = "Social Media"
        Label5.BackColor = Color.FromArgb(231, 76, 60)
        Label5.ForeColor = Color.White
        Label6.Text = "Technical Skills"
        Label6.BackColor = Color.FromArgb(231, 76, 60)
        Label6.ForeColor = Color.White
        Label11.Text = "C,C++"
        Label12.Text = "Java"
        Label13.Text = "HTML CSS"
        Label14.Text = "JavaScript"
        Label11.ForeColor = Color.FromArgb(41, 128, 185)
        Label12.ForeColor = Color.FromArgb(41, 128, 185)
        Label13.ForeColor = Color.FromArgb(41, 128, 185)
        Label14.ForeColor = Color.FromArgb(41, 128, 185)
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("tel:8233730139")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("mailto:preetichablani2006@gmail.com")
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://github.com/preetichablani")
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start("https://wa.me/918233730139")
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Process.Start("https://www.linkedin.com/in/Preeti-Chablani/")
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Process.Start("https://www.snapchat.com/add/preeti125904")
    End Sub
End Class