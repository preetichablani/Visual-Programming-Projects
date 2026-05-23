Public Class Form1
    Dim balance As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "ATM System - Preeti Chablani"
        Me.BackColor = Color.FromArgb(15, 23, 42)
        Label1.Text = "ATM SYSTEM"
        Label2.Text = "Account Number"
        Label3.Text = "Username"
        Label4.Text = "PIN"
        Label5.Text = "Amount"
        Label1.ForeColor = Color.White
        Label2.ForeColor = Color.White
        Label3.ForeColor = Color.White
        Label4.ForeColor = Color.White
        Label5.ForeColor = Color.White
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox4.BackColor = Color.WhiteSmoke
        TextBox3.PasswordChar = "*"
        RichTextBox1.BackColor = Color.WhiteSmoke
        Button1.Text = "Check Balance"
        Button2.Text = "Deposit"
        Button3.Text = "Withdraw"
        Button4.Text = "Exit"
        Button1.BackColor = Color.FromArgb(65, 105, 225)
        Button2.BackColor = Color.FromArgb(65, 105, 225)
        Button3.BackColor = Color.FromArgb(65, 105, 225)
        Button4.BackColor = Color.FromArgb(220, 38, 38)
        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.White
        Button3.ForeColor = Color.White
        Button4.ForeColor = Color.White
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or
       TextBox2.Text = "" Or
       TextBox3.Text = "" Or
       TextBox4.Text = "" Then
            MessageBox.Show("Fill All Fields")
        ElseIf TextBox1.TextLength <> 8 Then
            MessageBox.Show("Account Number Must Be 8 Digits")
        ElseIf TextBox3.TextLength <> 8 Then
            MessageBox.Show("PIN Must Be 8 Digits")
        Else
            balance = Val(TextBox4.Text)
            RichTextBox1.Clear()
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
            RichTextBox1.SelectionFont =
        New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
            RichTextBox1.AppendText(
        "Welcome " & TextBox2.Text & vbCrLf & vbCrLf)
            RichTextBox1.SelectionFont =
        New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
            RichTextBox1.AppendText(
        "Account Number : " & TextBox1.Text & vbCrLf &
        "Current Balance = ₹" & balance)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or
       TextBox2.Text = "" Or
       TextBox3.Text = "" Or
       TextBox4.Text = "" Then
            MessageBox.Show("Fill All Fields")
        ElseIf TextBox1.TextLength <> 8 Then
            MessageBox.Show("Account Number Must Be 8 Digits")
        ElseIf TextBox3.TextLength <> 8 Then
            MessageBox.Show("PIN Must Be 8 Digits")
        Else
            Dim amount As Integer
            amount = Val(TextBox4.Text)
            balance = balance + amount
            RichTextBox1.Clear()
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
            RichTextBox1.SelectionFont =
        New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
            RichTextBox1.AppendText(
        "Deposit Successful" & vbCrLf & vbCrLf)
            RichTextBox1.SelectionFont =
        New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
            RichTextBox1.AppendText(
        "Deposited Amount = ₹" & amount & vbCrLf &
        "Current Balance = ₹" & balance)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or
       TextBox2.Text = "" Or
       TextBox3.Text = "" Or
       TextBox4.Text = "" Then
            MessageBox.Show("Fill All Fields")
        ElseIf TextBox1.TextLength <> 8 Then
            MessageBox.Show("Account Number Must Be 8 Digits")
        ElseIf TextBox3.TextLength <> 8 Then
            MessageBox.Show("PIN Must Be 8 Digits")
        Else
            Dim amount As Integer
            amount = Val(TextBox4.Text)
            If amount <= balance Then
                balance = balance - amount
                RichTextBox1.Clear()
                RichTextBox1.SelectionAlignment =
            HorizontalAlignment.Center
                RichTextBox1.SelectionFont =
            New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                RichTextBox1.AppendText(
            "Withdrawal Successful" & vbCrLf & vbCrLf)
                RichTextBox1.SelectionFont =
            New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
                RichTextBox1.AppendText(
            "Withdraw Amount = ₹" & amount & vbCrLf &
            "Current Balance = ₹" & balance)
            Else
                MessageBox.Show("Insufficient Balance")
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class