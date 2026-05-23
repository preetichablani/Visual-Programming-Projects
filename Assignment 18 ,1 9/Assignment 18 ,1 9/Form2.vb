Imports MySql.Data.MySqlClient

Public Class Form2
    Dim con As MySqlConnection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New MySqlConnection("server=localhost;userid=root;password=;database=logindb")
        Me.BackColor = Color.AliceBlue
        Me.Text = "Develop By - Preeti Chablani"
        Label1.Text = "SIGN IN DETAILS"
        Label1.ForeColor = Color.DarkBlue
        Label2.Text = "First Name"
        Label3.Text = "Last Name"
        Label4.Text = "Username"
        Label5.Text = "Password"
        Label6.Text = "Re Password"
        Label7.Text = "City"
        Label8.Text = "Type"
        TextBox4.PasswordChar = "*"
        TextBox5.PasswordChar = "*"
        ComboBox1.Items.Add("Ajmer")
        ComboBox1.Items.Add("Jaipur")
        ComboBox1.Items.Add("Udaipur")
        ComboBox1.Items.Add("jodhpur")
        ComboBox1.Items.Add("Beawer")
        ComboBox1.Items.Add("Pushkar")
        ComboBox1.Items.Add("Kota")
        ComboBox1.Items.Add("Bikaner")
        ComboBox1.Items.Add("Kishanghar")
        ComboBox2.Items.Add("Admin")
        ComboBox2.Items.Add("Manager")
        ComboBox2.Items.Add("Employee")
        ComboBox2.Items.Add("Customer")
        Button1.Text = "SAVE"
        Button1.BackColor = Color.RoyalBlue
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Fill All Fields")
            Exit Sub
        End If

        If TextBox4.Text <> TextBox5.Text Then
            MessageBox.Show("Password Not Match")
            Exit Sub
        End If
        con.Open()

        Dim checkuser As New MySqlCommand("select count(*) from employee where username=@u", con)
        checkuser.Parameters.AddWithValue("@u", TextBox3.Text)
        Dim count As Integer
        count = Convert.ToInt32(checkuser.ExecuteScalar())
        If count > 0 Then
            MessageBox.Show("Username Already Exists")
            con.Close()
            Exit Sub
        End If

        Dim cmd As New MySqlCommand("insert into employee values(@f,@l,@u,@p,@c,@t)", con)
        cmd.Parameters.AddWithValue("@f", TextBox1.Text)
        cmd.Parameters.AddWithValue("@l", TextBox2.Text)
        cmd.Parameters.AddWithValue("@u", TextBox3.Text)
        cmd.Parameters.AddWithValue("@p", TextBox4.Text)
        cmd.Parameters.AddWithValue("@c", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@t", ComboBox2.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Saved Successfully")
        Form1.Show()
        Me.Hide()
        con.Close()
    End Sub
End Class