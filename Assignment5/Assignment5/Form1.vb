Public Class Form1
    Dim col As New Collection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "add data"
        Label2.Text = " value"
        Label3.Text = "key"
        Label4.Text = " Before"
        Label5.Text = "After"
        Label8.Text = "Enter key"
        Label9.Text = "Enter Index"
        Button2.Text = "Add"
        Button4.Text = "Show"
        Button6.Text = "Remove"
        Button5.Text = "Close"
        Button3.Text = "Cancel"
        Button7.Text = "Remove"
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
                col.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text)
            ElseIf TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" Then
                col.Add(TextBox1.Text, TextBox2.Text, TextBox4.Text)
            ElseIf TextBox1.Text <> "" And TextBox2.Text <> "" Then
                col.Add(TextBox1.Text, TextBox2.Text)
            End If
            MsgBox("Data Added Successfully")
            Panel1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox1.Focus()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each x In col
            rt1.Text = (rt1.Text & x)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox7.Text <> "" And TextBox8.Text = "" Then
            col.Remove(TextBox7.Text)
            MsgBox("Data Successfully Removed")
            Panel2.Visible = False
        ElseIf TextBox8.Text <> "" And TextBox7.Text = "" Then
            If Val(TextBox8.Text) < col.Count Then
                col.Remove(CInt(TextBox8.Text))
                MsgBox("Data Successfully Removed")
                Panel2.Visible = False
            End If
        End If
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel2.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel2.Visible = False
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox1.Focus()
    End Sub

End Class
