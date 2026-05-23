Public Class Form1
    Dim min, sec, msec As Integer
    Dim swstatus, onoff As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        Me.Text = "StopWatch - By Preeti Chablani"
        Label1.ForeColor = Color.FromArgb(60, 100, 180)
        min = 0
        sec = 0
        msec = 0
        onoff = False
        swstatus = False
        Button1.BackColor = Color.FromArgb(60, 100, 180)
        Button1.ForeColor = Color.White
        Button2.BackColor = Color.FromArgb(60, 100, 180)
        Button2.ForeColor = Color.White
        Button3.BackColor = Color.FromArgb(60, 100, 180)
        Button3.ForeColor = Color.White
        Button1.Text = "Start"
        Button2.Text = "Close"
        Button3.Text = "Reset"
        'Button3.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(min, "00") & ":" & Format(sec, "00") & ":" & Format(msec, "00")
        msec = msec + 1
        If (msec >= 100) Then
            sec = sec + 1
            msec = 0
            If sec >= 60 Then
                min = min + 1
                sec = 0
                msec = 0
                If min >= 60 Then
                    min = sec = msec = 0
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If swstatus = True Then
            swstatus = False
            Timer1.Enabled = False
            Button1.Text = "Play"
        Else
            Timer1.Enabled = True
            swstatus = True
            Button1.Text = "Pause"
            onoff = True
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        i = MsgBox("Do you want to close ... ", MsgBoxStyle.YesNo, "StopWatch - By Naman & Yash")
        If i = 6 Then
            Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If onoff = True Then
            Dim i As Integer
            Timer1.Enabled = False
            i = MsgBox("Do  you want to reset .. ", MsgBoxStyle.YesNo, "By Naman & Yash")
            If i = 6 Then
                min = 0
                sec = 0
                msec = 0
                Label1.Text = "00:00:00"
                Timer1.Enabled = False
                swstatus = False
                Button1.Text = "Start"
            Else
                Timer1.Enabled = True
            End If
        End If
    End Sub
End Class
