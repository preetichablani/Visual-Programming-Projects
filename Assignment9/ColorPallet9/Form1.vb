Imports System.Drawing
Imports System.Windows.Forms
Public Class Form1
    Dim timerCopy1 As Integer = 1
    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles redScroll.Scroll
        TextBox1.Text = redScroll.Value
        TextBox4.Text = TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text
        Call colorCalc()
        TextBox5.Text = hexacalc(redScroll.Value) & hexacalc(greenScroll.Value) & hexacalc(blueScroll.Value)
    End Sub

    Function hexacalc(t As Integer)
        Dim x As Integer = t
        Dim f As Integer = 0
        Dim s As String = ""
        If x = 0 Then
            s = "0"
        End If
        While x <> 0
            f = x Mod 16
            If (f >= 10 And f <= 15) Then
                s = Chr(55 + f).ToString.ToUpper() & s
            Else
                s = f.ToString & s
            End If
            x = x \ 16
        End While
        If Len(s) = 1 Then
            s = "0" + s
        End If
        'TextBox5.Text = s
        Return s
    End Function

    Sub colorCalc()
        Label1.BackColor = Color.FromArgb(redScroll.Value, greenScroll.Value, blueScroll.Value)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "HEXA Color"
        Label2.Text = "RGB Color"
        Label1.Text = ""
        TextBox1.Text = redScroll.Value
        TextBox2.Text = greenScroll.Value
        TextBox3.Text = blueScroll.Value
        Button1.FlatStyle = FlatStyle.Popup

        Button1.Text = "Pik Color"
        Call colorCalc()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then
            If Val(TextBox1.Text) >= 0 And Val(TextBox1.Text) <= 255 Then
                redScroll.Value = Val(TextBox1.Text)
                TextBox4.Text = TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text
                Call colorCalc()
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If IsNumeric(TextBox2.Text) Then
            If Val(TextBox2.Text) >= 0 And Val(TextBox2.Text) <= 255 Then
                greenScroll.Value = Val(TextBox2.Text)
                Call colorCalc()
                TextBox4.Text = TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If IsNumeric(TextBox3.Text) Then
            If Val(TextBox3.Text) >= 0 And Val(TextBox3.Text) <= 255 Then
                blueScroll.Value = Val(TextBox3.Text)
                TextBox4.Text = TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text
                Call colorCalc()
            End If
        End If
    End Sub

    Private Sub greenScroll_Scroll(sender As Object, e As ScrollEventArgs) Handles greenScroll.Scroll
        TextBox2.Text = greenScroll.Value
        TextBox4.Text = TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text
        Call colorCalc()
        TextBox5.Text = hexacalc(redScroll.Value) & hexacalc(greenScroll.Value) & hexacalc(blueScroll.Value)
    End Sub

    Private Sub blueScroll_Scroll(sender As Object, e As ScrollEventArgs) Handles blueScroll.Scroll
        TextBox3.Text = blueScroll.Value
        TextBox4.Text = TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text
        Call colorCalc()
        TextBox5.Text = hexacalc(redScroll.Value) & hexacalc(greenScroll.Value) & hexacalc(blueScroll.Value)
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        Clipboard.SetText("rgb(" & TextBox4.Text & ")")
        Timer1.Enabled = True
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timerCopy1 = 15 Then
            Label1.Text = ""
            timerCopy1 = 1
            Timer1.Enabled = False
        Else
            Label1.Text = "Color Copied"
            timerCopy1 = timerCopy1 + 1
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        Clipboard.SetText("#" & TextBox5.Text)
        Timer1.Enabled = True
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.preetichablani")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

        Dim picker As New Form2()

        If picker.ShowDialog() = DialogResult.OK Then

            Dim clr As Color = picker.SelectedColor

            Label1.BackColor = clr

            
        End If

        Me.Show()
    End Sub
End Class
