Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connect()
        Dim str As String
        Try
            con.Open()
            str = "insert into student_info (stud_id, stud_name, stud_class, stud_city, stud_pno)values(@sid, @name, @clas, @city, @pno)"
            Dim rs As New MySqlCommand(str, con)
            rs.Parameters.AddWithValue("@sid", TextBox1.Text)
            rs.Parameters.AddWithValue("@name", TextBox2.Text)
            rs.Parameters.AddWithValue("@clas", ComboBox1.Text)
            rs.Parameters.AddWithValue("@city", ComboBox2.Text)
            rs.Parameters.AddWithValue("@pno", TextBox5.Text)
            rs.ExecuteNonQuery()
            MsgBox("Data inserted")
            Call clearData()
            con.Close()
            Call showDataInGrid()

        Catch ex As Exception
            MsgBox("ss" & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub showDataInGrid()
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Try
            con.Open()
            da = New MySqlDataAdapter("select stud_id, stud_name, stud_class, stud_city, stud_pno from student_info", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox("ss" & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub clearData()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox5.Text = ""
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call clearData()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://wa.me/8233730139?text=helloworld")

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Develop By Preeti Chablani"
        Label1.Text = "ID"
        Label2.Text = "Name"
        Label3.Text = "Class"
        Label4.Text = "City"
        Label5.Text = "Phone No."
        LinkLabel1.Text = "Preeti Chablani"
        Button1.Text = "Insert"
        Button2.Text = "Show"
        Button3.Text = "Clear"
        Button4.Text = "Modify"
        Button5.Text = "Delete"
        Call showDataInGrid()
        Call connect()
        Dim da, da1 As MySqlDataAdapter
        Dim dt, dt1 As New DataTable
        Dim str1, str As String
        str = "select * from classdetail"
        str1 = "select * from citydetail"
        Try
            con.Open()
            da = New MySqlDataAdapter(str, con)
            da.Fill(dt)
            ComboBox1.Items.Clear()
            For i As Integer = 0 To dt.Rows.Count - 1
                ComboBox1.Items.Add(dt.Rows(i).Item(1))
            Next
            da1 = New MySqlDataAdapter(str1, con)
            da1.Fill(dt1)
            ComboBox2.Items.Clear()
            For i As Integer = 0 To dt1.Rows.Count - 1
                ComboBox2.Items.Add(dt1.Rows(i).Item(1))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Try
            con.Open()
            da = New MySqlDataAdapter("select * from student_info order by stud_name asc", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox("ss" & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim s1, str As String
        s1 = DataGridView1.SelectedCells.Item(0).Value
        str = "select * from student_info where stud_id = '" & s1 & "'"
        Try
            con.Open()
            da = New MySqlDataAdapter(str, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            TextBox1.Text = dt.Rows(0).Item(1)
            TextBox2.Text = dt.Rows(0).Item(2)
            ComboBox1.Text = dt.Rows(0).Item(3)
            ComboBox2.Text = dt.Rows(0).Item(4)
            TextBox5.Text = dt.Rows(0).Item(5)

            DataGridView1.Refresh()
        Catch ex As Exception
            MsgBox("ss" & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If Len(TextBox2.Text) > 0 Then
            Button4.Enabled = True
        Else
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call connect()
        Dim str As String
        Try
            con.Open()
            str = "update student_info set stud_name = @name,stud_class = @class,stud_city = @city,stud_pno = @pno where stud_id = '" & TextBox1.Text & "'"
            Dim rs As New MySqlCommand(str, con)
            rs.Parameters.AddWithValue("@name", TextBox2.Text)
            rs.Parameters.AddWithValue("@class", ComboBox1.Text)
            rs.Parameters.AddWithValue("@city", ComboBox2.Text)
            rs.Parameters.AddWithValue("@pno", TextBox5.Text)
            rs.ExecuteNonQuery()
            MsgBox("Data Modified")
            con.Close()
            Call showDataInGrid()
        Catch ex As Exception
            MsgBox("ss" & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call connect()
        Dim str As String
        Try
            con.Open()
            str = "delete from student_info where stud_id = '" & TextBox1.Text & "'"
            Dim rs As New MySqlCommand(str, con)
            rs.ExecuteNonQuery()
            MsgBox("Data delete")
            con.Close()
            Call showDataInGrid()
        Catch ex As Exception
            MsgBox("ss" & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Try
            con.Open()
            da = New MySqlDataAdapter("select * from student_info where stud_name like('" & TextBox3.Text & "%')", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call showDataInGrid()
    End Sub
End Class
