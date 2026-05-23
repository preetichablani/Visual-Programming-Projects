Imports System.Drawing.Text
Public Class Form1
    Dim bstat, istat, ustat As Boolean
    Dim cutstat = False
    Dim alignV As Integer = 0
    Dim savestatus As Integer = 0
    Dim savefilename As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim font As New InstalledFontCollection
        For Each f As FontFamily In font.Families
            cmbfontf.Items.Add(f.Name)
        Next
        Dim i As Integer
        For i = 6 To 72 Step 2
            cmbfontsize.Items.Add(i.ToString)
        Next
        RichTextBox1.Text = "Preeti Chablani"
        Me.Text = "Notepad Created By Preeti Chablani"
        cmbfontf.Text = "Font Family"
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        If savestatus = 1 Then
            Dim x As Integer
            x = MsgBox("Do You Want to Save File or Not", MsgBoxStyle.YesNoCancel)
            If x = 6 Then
                RichTextBox1.SaveFile(savefilename)
                savestatus = 0
                RichTextBox1.Clear()
            ElseIf x = 7 Then
                savestatus = 0
                RichTextBox1.Clear()
            End If
        Else
            savestatus = 0
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim f As Font
        If bstat = False Then
            f = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, FontStyle.Bold)
            RichTextBox1.SelectionFont = f
            bstat = True
        Else
            f = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, FontStyle.Regular)
            RichTextBox1.SelectionFont = f
            bstat = False
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim f As Font
        If istat = False Then
            f = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, FontStyle.Italic)
            RichTextBox1.SelectionFont = f
            istat = True
        Else
            f = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, FontStyle.Regular)
            RichTextBox1.SelectionFont = f
            istat = False
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim f As Font
        If ustat = False Then
            f = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, FontStyle.Underline)
            RichTextBox1.SelectionFont = f
            ustat = True
        Else
            f = New Font(RichTextBox1.SelectionFont.FontFamily, RichTextBox1.SelectionFont.Size, FontStyle.Regular)
            RichTextBox1.SelectionFont = f
            ustat = False
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.InitialDirectory = "D:\"
        OpenFileDialog1.Filter = "Text|*.txt|Doc|*.doc"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            savefilename = OpenFileDialog1.FileName
            savestatus = 1
            RichTextBox1.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        SaveFileDialog1.InitialDirectory = "D:\"
        SaveFileDialog1.Filter = "Text|*.txt|Doc|*.doc"
        If savestatus = 1 Then
            RichTextBox1.SaveFile(savefilename)
            savestatus = 1
        Else
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RichTextBox1.SaveFile(SaveFileDialog1.FileName)
                savefilename = SaveFileDialog1.FileName
                savestatus = 1
            End If
        End If
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
        RichTextBox1.SelectedText = ""
        cutstat = True
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        Clipboard.SetText(RichTextBox1.SelectedText)
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        If cutstat = True Then
            RichTextBox1.AppendText(Clipboard.GetText)
            cutstat = False
            Clipboard.Clear()
        Else
            RichTextBox1.AppendText(Clipboard.GetText)
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub cmbfontsize_TextChanged(sender As Object, e As EventArgs) Handles cmbfontsize.TextChanged
        Dim f As New Font(RichTextBox1.SelectionFont.FontFamily, CSng(cmbfontsize.Text))
        RichTextBox1.SelectionFont = f
    End Sub

    Private Sub cmbfontf_TextChanged(sender As Object, e As EventArgs) Handles cmbfontf.TextChanged
        Dim f As New Font(cmbfontf.Text, RichTextBox1.SelectionFont.Size)
        RichTextBox1.SelectionFont = f
    End Sub
End Class
