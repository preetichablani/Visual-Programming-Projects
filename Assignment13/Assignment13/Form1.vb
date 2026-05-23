Imports System.IO
Imports System.Drawing
Public Class Form1
    Dim images(4) As String
    Dim i As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Developed By - Preeti Chablani"

        Me.Size = New Size(900, 600)

        Label1.Text = "IMAGE GALLERY SLIDER"
        Label1.ForeColor = Color.DarkBlue
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 22, FontStyle.Bold)

        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.BackColor = Color.White

        Timer1.Interval = 2000
        Timer1.Start()

        images(0) = "C:\Users\preet\OneDrive\Documents\preeti vb\image\img1.jpg"
        images(1) = "C:\Users\preet\OneDrive\Documents\preeti vb\image\img2.jpg"
        images(2) = "C:\Users\preet\OneDrive\Documents\preeti vb\image\img3.jpg"
        images(3) = "C:\Users\preet\OneDrive\Documents\preeti vb\image\img4.jpg"
        images(4) = "C:\Users\preet\OneDrive\Documents\preeti vb\image\img5.jpg"

        PictureBox1.ImageLocation = images(i)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If i >= images.Length Then
            i = 0
        End If
        PictureBox1.ImageLocation = images(i)
    End Sub
End Class