Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = ">"
        Button2.Text = ">>"
        Button3.Text = "<"
        Button4.Text = "<<"
        Dim arr() As String = {"Preeti", "Bhavika", "Diya", "Rashi", "Tanvi", "Deepika"}
        Me.Text = "ListBox-Preeti Chablani"
        ListBox1.Items.AddRange(arr)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem <> "" Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Count <> 0 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                ListBox2.Items.Add(ListBox1.Items.Item(i))
            Next
            ListBox1.Items.Clear()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox2.SelectedItem <> "" Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox2.Items.Count <> 0 Then
            For i As Integer = 0 To ListBox2.Items.Count - 1
                ListBox1.Items.Add(ListBox2.Items.Item(i))
            Next
            ListBox2.Items.Clear()
        End If
    End Sub
End Class
