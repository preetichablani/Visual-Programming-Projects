Imports System.Windows.Forms.VisualStyles
Imports System.Drawing
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Opacity = 0.01   ' Almost invisible
        Me.TopMost = True
        Me.Cursor = Cursors.Cross
    End Sub
    Public SelectedColor As Color

    Private Function GetColorAt(x As Integer, y As Integer) As Color

        Dim bmp As New Bitmap(1, 1)

        Using g As Graphics = Graphics.FromImage(bmp)
            g.CopyFromScreen(x, y, 0, 0, New Size(1, 1))
        End Using

        Return bmp.GetPixel(0, 0)

    End Function

    Private Sub PickerForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

        Dim pos As Point = Cursor.Position

        SelectedColor = GetColorAt(pos.X, pos.Y)

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub
End Class