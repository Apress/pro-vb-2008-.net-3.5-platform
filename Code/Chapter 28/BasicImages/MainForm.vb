Option Explicit On
Option Strict On

Public Class MainForm
    ' To hold the *.bmp data. 
    Private myImages As Bitmap() = New Bitmap(2) {}

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myImages(0) = New Bitmap("imageA.bmp")
        myImages(1) = New Bitmap("imageB.bmp")
        myImages(2) = New Bitmap("imageC.bmp")
        CenterToScreen()
    End Sub
    Private Sub MainForm_Paint(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        ' Render all three images.
        Dim yOffset As Integer = 10
        For Each b As Bitmap In myImages
            g.DrawImage(b, 10, yOffset, 90, 90)
            yOffset += 100
        Next
    End Sub
End Class
