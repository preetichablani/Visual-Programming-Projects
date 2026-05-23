Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Loading System - Preeti Chablani"
        Me.BackColor = Color.LightBlue
        Me.StartPosition = FormStartPosition.CenterScreen
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.Width = 400
        ProgressBar1.Height = 35
        ProgressBar1.Left = 70
        ProgressBar1.Top = 100
        Label2.Visible = False
        Label2.ForeColor = Color.Black
        Label2.AutoSize = True
        Label2.Left = 235
        Label2.Top = 150
        Button1.Text = "START"
        Button1.BackColor = Color.Red
        Button1.ForeColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Left = 80
        Button1.Top = 220
        Button2.Text = "STOP"
        Button2.BackColor = Color.Blue
        Button2.ForeColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Left = 280
        Button2.Top = 220
        Timer1.Interval = 200
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Label2.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        Label2.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show(
                "Process Complete Successfully!",
                "Completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        MessageBox.Show(
            "Process Stopped!",
            "Stopped",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
       )
    End Sub
End Class