Option Explicit On
Option Strict On

Imports System.Drawing.Drawing2D

Enum ClickedImage
    ImageA
    ImageB
    ImageC
    StrangePath
End Enum

Public Class MainForm

    ' To hold the *.bmp data. 
    Private myImages As Bitmap() = New Bitmap(2) {}
    Private imageRects As Rectangle() = New Rectangle(2) {}
    Private isImageClicked As Boolean = False
    Private imageClicked As ClickedImage = ClickedImage.ImageA
    Private myPath As GraphicsPath = New GraphicsPath()

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myImages(0) = New Bitmap("imageA.bmp")
        myImages(1) = New Bitmap("imageB.bmp")
        myImages(2) = New Bitmap("imageC.bmp")

        ' Set up the rectangles.
        imageRects(0) = New Rectangle(10, 10, 90, 90)
        imageRects(1) = New Rectangle(10, 110, 90, 90)
        imageRects(2) = New Rectangle(10, 210, 90, 90)

        ' Create an interesting path.
        myPath.StartFigure()
        myPath.AddLine(New Point(150, 10), New Point(120, 150))
        myPath.AddArc(200, 200, 100, 100, 0, 90)
        Dim point1 As Point = New Point(250, 250)
        Dim point2 As Point = New Point(350, 275)
        Dim point3 As Point = New Point(350, 325)
        Dim point4 As Point = New Point(250, 350)
        Dim points As Point() = {point1, point2, point3, point4}
        myPath.AddCurve(points)
        myPath.CloseFigure()
        CenterToScreen()
    End Sub

#Region "Event handlers"
    Private Sub MainForm_Paint(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        ' Render all three images.
        Dim yOffset As Integer = 10
        For Each b As Bitmap In myImages
            g.DrawImage(b, 10, yOffset, 90, 90)
            yOffset += 100
        Next

        ' Draw the graphics path.
        g.FillPath(Brushes.Sienna, myPath)

        ' Draw outline (if clicked)
        If isImageClicked = True Then
            Dim outline As Pen = New Pen(Color.Red, 5)
            Select Case imageClicked
                Case ClickedImage.ImageA
                    g.DrawRectangle(outline, imageRects(0))
                    Exit Select
                Case ClickedImage.ImageB
                    g.DrawRectangle(outline, imageRects(1))
                    Exit Select
                Case ClickedImage.ImageC
                    g.DrawRectangle(outline, imageRects(2))
                    Exit Select
                Case ClickedImage.StrangePath
                    g.DrawPath(outline, myPath)
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub MainForm_MouseDown(ByVal sender As System.Object, _
      ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ' Get (x, y) of mouse click.
        Dim mousePt As Point = New Point(e.X, e.Y)

        ' See if the mouse is anywhere in the 3 Rectangles.
        If imageRects(0).Contains(mousePt) Then
            isImageClicked = True
            imageClicked = ClickedImage.ImageA
            Me.Text = "You clicked image A"
        ElseIf imageRects(1).Contains(mousePt) Then
            isImageClicked = True
            imageClicked = ClickedImage.ImageB
            Me.Text = "You clicked image B"
        ElseIf imageRects(2).Contains(mousePt) Then
            isImageClicked = True
            imageClicked = ClickedImage.ImageC
            Me.Text = "You clicked image C"
        ElseIf myPath.IsVisible(mousePt) Then
            isImageClicked = True
            imageClicked = ClickedImage.StrangePath
            Me.Text = "You clicked the strange shape..."
        Else
            ' Not in any shape, set defaults.
            isImageClicked = False
            Me.Text = "Hit Testing Images"
        End If

        ' Redraw the client area.
        Invalidate()
    End Sub
#End Region

End Class
