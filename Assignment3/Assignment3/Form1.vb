Public Class Form1
    Dim Title As String = "Electricity Bill Generator-Preeti Chablani"
    Dim uc1, uc2, uc3, uc4 As Double
    Dim mc1, mc2, mc3, mc4 As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Title
        Me.Text = Title
        uc1 = 4.25
        uc2 = 5.75
        uc3 = 7.25
        uc4 = 8.5
        mc1 = 0
        mc2 = 150
        mc3 = 250
        mc4 = 450
        Label2.Text = "Customer ID"
        Label3.Text = "Customer Name"
        TextBox2.Enabled = False
        Label4.Text = "Enter Unit"
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox4.Enabled = False
        Label9.Text = "Total Units"
        Label11.Text = "Total Meter Charge"
        Label10.Text = "Total Unit Charge"
        Label12.Text = "Net Bill Amount"
        Label13.Text = ""
        Label8.Text = ""
        Label7.Text = ""
        Label6.Text = ""
        Label5.Text = ""
        TextBox3.Enabled = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "20260001" Then
            TextBox2.Text = "Manthan Verma"
        ElseIf TextBox1.Text = "20260002" Then
            TextBox2.Text = "Rashi Bhojwani"
        ElseIf TextBox1.Text = "20260003" Then
            TextBox2.Text = "Yash Parashar"
        ElseIf TextBox1.Text = "20260004" Then
            TextBox2.Text = "Diya Khatwani"
        ElseIf TextBox1.Text = "20260005" Then
            TextBox2.Text = "Harshita Jangid"
        Else
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            TextBox3.Enabled = True
            TextBox3.Focus()
        Else
            TextBox3.Enabled = False
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim tbc, uc1r, uc2r, uc3r, uc4r As Double
        Dim mccharges As Double = 0
        Dim unit As Integer
        If TextBox3.Text <> "" Then
            unit = Val(TextBox3.Text)
            If unit >= 0 And unit <= 50 Then
                uc1r = unit * uc1
                tbc = uc1r
                mccharges = mc1
            ElseIf unit >= 51 And unit <= 150 Then
                uc1r = 50 * uc1
                uc2r = (unit - 50) * uc2
                tbc = uc1r + uc2r
                mccharges = mc2
            ElseIf unit >= 151 And unit <= 250 Then
                uc1r = 50 * uc1
                uc2r = 100 * uc2
                uc3r = (unit - 150) * uc3
                tbc = uc1r + uc2r + uc3r
                mccharges = mc3
            ElseIf unit >= 251 Then
                uc1r = 50 * uc1
                uc2r = 100 * uc2
                uc3r = 100 * uc3
                uc4r = (unit - 250) * uc4
                tbc = uc1r + uc2r + uc3r + uc4r
                mccharges = mc4
            End If
            Label5.Text = "Unit 0 - 50 @" & uc1 & " - (Unit - " & (uc1r / uc1) & ") -- Rs. " & uc1r
            Label6.Text = "Unit 50 - 150 @" & uc2 & " - (Unit - " & (uc2r / uc2) & ") -- Rs. " & uc2r
            Label7.Text = "Unit 150 - 250 @" & uc3 & " - (Unit - " & (uc3r / uc3) & ") -- Rs. " & uc3r
            Label8.Text = "Unit 250 && Above @" & uc4 & " - (Unit - " & (uc4r / uc4) & ") -- Rs. " & uc4r
            TextBox4.Text = unit
            TextBox5.Text = tbc
            TextBox6.Text = mccharges
            tbc = tbc + mccharges
            Label13.Text = "Rs. " & tbc
            Label13.ForeColor = Color.DarkGreen
        Else
            Label5.Text = ""
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            mccharges = uc1r = uc2r = uc3r = uc4r = unit = 0
        End If
    End Sub
End Class
