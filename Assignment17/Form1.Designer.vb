<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(303, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 49)
        Label1.TabIndex = 0
        Label1.Text = "Loading..."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.ControlText
        ProgressBar1.Location = New Point(12, 162)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(776, 29)
        ProgressBar1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(361, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 37)
        Label2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.PeachPuff
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(189, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 84)
        Button1.TabIndex = 3
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.PeachPuff
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(410, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 84)
        Button2.TabIndex = 4
        Button2.Text = "Stop"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 200
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer

End Class
