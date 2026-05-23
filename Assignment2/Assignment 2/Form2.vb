Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Student Name"
        Label3.Text = "Student Class"
        Label4.Text = "VB.Net"
        Label5.Text = "Android"
        Label6.Text = "CBS"
        Label7.Text = "DAA"
        Label8.Text = "Total Marks"
        Label9.Text = "Percentage"
        Button1.Text = "Back && Close"
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        Label10.Text = ""
        Me.Text = "Student Marks Calculator"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.TextBox3.Text = ""
        Form1.TextBox4.Text = ""
        Form1.TextBox5.Text = ""
        Form1.TextBox6.Text = ""
        Me.Hide()
        Form1.Show()
        Form1.TextBox1.Focus()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class