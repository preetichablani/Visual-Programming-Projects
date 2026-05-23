Imports System.IO
Imports System.Drawing

Public Class Form1
    Dim currentFile As String = ""
    Dim bulletMode As String = ""
    Dim numberCount As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Develop By - Preeti Chablani"
        Me.WindowState = FormWindowState.Maximized
        RichTextBox1.BackColor = Color.Pink
        RichTextBox1.ForeColor = Color.Black
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Consolas", 12)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWToolStripMenuItem.Click
        RichTextBox1.Clear()
        currentFile = ""
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        Dim op As New OpenFileDialog
        op.Filter = "Text Files|*.txt"
        If op.ShowDialog = DialogResult.OK Then
            RichTextBox1.Text = File.ReadAllText(op.FileName)
            currentFile = op.FileName
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAVEToolStripMenuItem.Click
        If currentFile = "" Then
            Dim sv As New SaveFileDialog
            sv.Filter = "Text Files|*.txt"
            If sv.ShowDialog = DialogResult.OK Then
                File.WriteAllText(sv.FileName, RichTextBox1.Text)
                currentFile = sv.FileName
            End If
        Else
            File.WriteAllText(currentFile, RichTextBox1.Text)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXISTToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUTToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPYToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PASTEToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTALLToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub DarkThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAToolStripMenuItem.Click
        Me.ForeColor = Color.White
        RichTextBox1.BackColor = Color.DarkCyan
    End Sub
    Private Sub LightThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIGHTTHEMEToolStripMenuItem.Click
        Me.ForeColor = Color.Black
        RichTextBox1.BackColor = Color.LightPink
    End Sub
    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles BToolStripMenuItem.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            Dim currentFont As Font = RichTextBox1.SelectionFont
            Dim style As FontStyle
            If currentFont.Bold Then
                style = FontStyle.Regular
            Else
                style = FontStyle.Bold
            End If
            RichTextBox1.SelectionFont =
                New Font(currentFont, style)
        End If
    End Sub

    Private Sub btnItalic_Click(sender As Object, e As EventArgs) Handles IToolStripMenuItem.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            Dim currentFont As Font = RichTextBox1.SelectionFont
            Dim style As FontStyle
            If currentFont.Italic Then
                style = FontStyle.Regular
            Else
                style = FontStyle.Italic
            End If
            RichTextBox1.SelectionFont =
               New Font(currentFont, style)
        End If
    End Sub

    Private Sub btnUnderline_Click(sender As Object, e As EventArgs) Handles UToolStripMenuItem.Click
        If RichTextBox1.SelectionFont IsNot Nothing Then
            Dim currentFont As Font = RichTextBox1.SelectionFont
            Dim style As FontStyle
            If currentFont.Underline Then
                style = FontStyle.Regular
            Else
                style = FontStyle.Underline
            End If
            RichTextBox1.SelectionFont =
               New Font(currentFont, style)
        End If
    End Sub

    Private Sub cmbHeading_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Dim size As Integer = 12
        Select Case ToolStripComboBox1.Text
            Case "H1"
                size = 32
            Case "H2"
                size = 28
            Case "H3"
                size = 24
            Case "H4"
                size = 20
            Case "H5"
                size = 16
            Case "H6"
                size = 14
            Case Else
                size = 12
        End Select
        RichTextBox1.SelectionFont =
            New Font("Consolas", size, FontStyle.Bold)
    End Sub

    Private Sub bullet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        bulletMode = ToolStripComboBox2.Text
        Dim lines() As String = RichTextBox1.Lines
        For i As Integer = 0 To lines.Length - 1
            Dim txt As String = lines(i).Trim()
            txt = txt.Replace("•", "")
            txt = txt.Replace("○", "")
            txt = txt.Replace("■", "")
            If txt.Contains(".") Then
                Dim firstPart As String = txt.Split("."c)(0)
                If IsNumeric(firstPart) Then
                    txt = txt.Substring(txt.IndexOf(".") + 1).Trim()
                End If
            End If
            Select Case bulletMode
                Case "Disc"
                    lines(i) = "• " & txt
                Case "Circle"
                    lines(i) = "○ " & txt
                Case "Square"
                    lines(i) = "■ " & txt
                Case "Number"
                    lines(i) = (i + 1).ToString() & ". " & txt
                Case Else
                    lines(i) = txt
            End Select
        Next
        RichTextBox1.Lines = lines
        If bulletMode = "Number" Then
            numberCount = lines.Length + 1
        End If
    End Sub

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            RichTextBox1.SelectedText = vbCrLf
            If bulletMode = "Disc" Then
                RichTextBox1.SelectedText = "• "
            ElseIf bulletMode = "Circle" Then
                RichTextBox1.SelectedText = "○ "
            ElseIf bulletMode = "Square" Then
                RichTextBox1.SelectedText = "■ "
            ElseIf bulletMode = "Number" Then
                RichTextBox1.SelectedText = numberCount.ToString() & ". "
                numberCount += 1
            End If
        End If
    End Sub
End Class