Imports System.Drawing.Text
Imports System.Reflection
Public Class Form1
    Dim fsize As Integer = 8
    Dim ffamily As String = "calibri"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter Text"
        Label2.Text = "FontFamily"
        Label3.Text = "FontSize"
        Label4.Text = "BackColor"
        Label5.Text = "ForeColor"
        ComboBox1.Items.Clear()
        Dim font As New InstalledFontCollection
        For Each f As FontFamily In font.Families
            ComboBox1.Items.Add(f.Name)
        Next
        Dim i As Integer
        ComboBox2.Items.Clear()
        For i = 8 To 72 Step 2
            ComboBox2.Items.Add(i)
        Next
        Dim p = GetType(Color).GetProperties()
        For Each x In p
            ComboBox4.Items.Add(x.Name)
            ComboBox3.Items.Add(x.Name)
        Next
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ffamily = ComboBox1.Text
        Label6.Font = New Font(ffamily, fsize)
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        fsize = ComboBox2.Text
        Label6.Font = New Font(ffamily, fsize)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label6.Text = TextBox1.Text
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Label6.ForeColor = Color.FromName(ComboBox4.SelectedItem.ToString)
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label6.BackColor = Color.FromName(ComboBox3.SelectedItem.ToString)
    End Sub
End Class
