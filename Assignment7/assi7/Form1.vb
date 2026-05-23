Public Class Form1
    Dim i As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Student Form Created By Preeti"
        Label1.Text = "Roll No:"
        Label2.Text = "Name:"
        Label3.Text = "Class:"
        Label4.Text = "City:"
        GroupBox1.Text = "Gender"
        RadioButton1.Text = "Male"
        RadioButton2.Text = "Female"
        ComboBox1.Items.Add("BCA")
        ComboBox1.Items.Add("BBA")
        ComboBox1.Items.Add("BA")
        ComboBox2.Items.Add("Ajmer")
        ComboBox2.Items.Add("Nasirabad")
        ComboBox2.Items.Add("Jaipur")
        ComboBox2.Items.Add("Jodhpur")
        ComboBox2.Items.Add("Kota")
        ComboBox2.Items.Add("Beawar")
        ComboBox2.Items.Add("Bikaner")
        Label5.Text = "Pho No:"
        Label13.Text = "Gender"
        Label14.Text = ""
        Panel1.BackColor = Color.LightPink
        Label6.Text = "Email:"
        Button1.Text = "Clear"
        Button2.Text = "Submit"
        Label7.Text = "Roll no."
        Label8.Text = "Name:"
        Label9.Text = "Class:"
        Label10.Text = "City:"
        ComboBox4.Items.Add("BCA")
        ComboBox4.Items.Add("BBA")
        ComboBox4.Items.Add("BA")
        ComboBox3.Items.Add("Ajmer")
        ComboBox3.Items.Add("Nasirabad")
        ComboBox3.Items.Add("Jaipur")
        ComboBox3.Items.Add("Jodhpur")
        ComboBox3.Items.Add("Kota")
        ComboBox3.Items.Add("Beawar")
        ComboBox3.Items.Add("Bikaner")
        Label11.Text = "Pho No:"
        Panel1.BackColor = Color.LightPink
        Label12.Text = "Emai:"
        Button3.Text = "Clear"
        Button4.Text = "Submit"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox8.Text = TextBox1.Text
        TextBox7.Text = TextBox2.Text
        ComboBox4.SelectedItem = ComboBox1.SelectedItem
        ComboBox3.SelectedItem = ComboBox2.SelectedItem
        If RadioButton1.Checked = True Then
            Label14.Text = "Male"
        ElseIf RadioButton2.Checked = True Then
            Label14.Text = "Female"
        End If
        TextBox6.Text = TextBox3.Text
        TextBox5.Text = TextBox4.Text
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Width >= 600 Then
            Timer1.Enabled = False
        Else
            Me.Width = Me.Width + i
            i = i + 20
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Width <= 320 Then
            Timer1.Enabled = False
        Else
            Me.Width = Me.Width - i
            i = i - 20
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Form Submitted")
    End Sub
End Class
