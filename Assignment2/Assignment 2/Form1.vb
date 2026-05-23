Public Class Form1

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Student Marks Calculator"
        Label2.Text = "Student Name"
        Label3.Text = "Student Class"
        Label4.Text = "VB.Net"
        Label5.Text = "Android"
        Label6.Text = "CBS"
        Label7.Text = "DAA"
        Button1.Text = "Reset"
        Button2.Text = "Submit"
        Button1.Enabled = False
        Button2.Enabled = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim total, per As Double
        total = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        per = total / 400 * 100
        Form2.TextBox1.Text = TextBox1.Text
        Form2.TextBox2.Text = TextBox2.Text
        Form2.TextBox3.Text = TextBox3.Text
        Form2.TextBox4.Text = TextBox4.Text
        Form2.TextBox5.Text = TextBox5.Text
        Form2.TextBox6.Text = TextBox6.Text
        Form2.TextBox7.Text = total
        Form2.TextBox8.Text = per
        Dim d As String
        Dim col As New Color

        If per >= 60 Then
            d = "First DIV"
            col = Color.DarkGreen
        ElseIf per >= 48 Then
            d = "Second DIV"
            col = Color.Orange
        ElseIf per >= 36 Then
            d = "Third DIV"
            col = Color.Yellow
        Else
            d = "Fail"
            col = Color.Red
        End If

        Me.Hide()
        Form2.Show()
        Form2.Label10.Text = d
        Form2.Label10.ForeColor = col
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Focus()
    End Sub
End Class
