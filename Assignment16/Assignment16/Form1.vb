Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "PINCODE FINDER"
        Me.Text = "Develop By - Preeti Chablani"
        Call connect()
        Dim da, da1 As MySqlDataAdapter
        Dim dt, dt1 As New DataTable
        Dim str, str1 As String
        Try
            str = "select distinct state from statecitypincode"
            da = New MySqlDataAdapter(str, con)
            da.Fill(dt)
            Dim i As Integer
            ComboBox1.Items.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    ComboBox1.Items.Add(dt.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try
        Try
            str = "select state,city, pincode from statecitypincode"
            da1 = New MySqlDataAdapter(str, con)
            da1.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                DataGridView1.DataSource = dt1
                DataGridView1.Refresh()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim str As String
        Try
            str = "select  distinct city from statecitypincode where state = '" & ComboBox1.Text.Trim() & "'"
            da = New MySqlDataAdapter(str, con)
            da.Fill(dt)
            Dim i As Integer
            ComboBox2.Items.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    ComboBox2.Items.Add(dt.Rows(i).Item(0))
                Next
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim str As String
        Try
            str = "select pincode from statecitypincode where city = '" & ComboBox2.Text & "'"
            da = New MySqlDataAdapter(str, con)
            da.Fill(dt)
            Dim i As Integer
            TextBox1.Text = ""
            If dt.Rows.Count > 0 Then
                TextBox1.Text = dt.Rows(0).Item(0)

            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Call connect()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim str As String
        Try
            str = "select state,city,pincode from statecitypincode where state like('" & TextBox2.Text & "%') or city like('" & TextBox2.Text & "%') or pincode like('" & TextBox2.Text & "%')"
            da = New MySqlDataAdapter(str, con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
                DataGridView1.Refresh()
            End If
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub
End Class