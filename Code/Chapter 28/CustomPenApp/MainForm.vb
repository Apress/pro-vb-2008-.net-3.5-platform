Option Explicit On
Option Strict On

Imports System.Drawing.Drawing2D

Public Class MainForm
    Private Sub MainForm_Paint(ByVal sender As System.Object, _
     ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        ' Make a big blue pen.
        Dim bluePen As Pen = New Pen(Color.Blue, 20)

        ' Get a stock pen from the Pens type.
        Dim pen2 As Pen = Pens.Firebrick

        ' Render some shapes with the pens.
        g.DrawEllipse(bluePen, 10, 10, 100, 100)
        g.DrawLine(pen2, 10, 130, 110, 130)
        g.DrawPie(Pens.Black, 150, 10, 120, 150, 90, 80)

        ' Draw a purple dashed polygon as well...
        Dim pen3 As Pen = New Pen(Color.Purple, 5)
        pen3.DashStyle = DashStyle.DashDotDot
        g.DrawPolygon(pen3, New Point() {New Point(30, 140), _
          New Point(265, 200), New Point(100, 225), _
          New Point(190, 190), New Point(50, 330), _
          New Point(20, 180)})

        ' And a rectangle containing some text...
        Dim r As Rectangle = New Rectangle(150, 10, 130, 60)
        g.DrawRectangle(Pens.Blue, r)
        g.DrawString("Hello out there...How are ya?", _
          New Font("Arial", 12), Brushes.Black, r)

        ' Draw custom dash pattern all around the boarder of the form.
        Dim customDashPen As Pen = New Pen(Color.BlueViolet, 10)
        Dim myDashes As Single() = {5.0F, 2.0F, 1.0F, 3.0F}
        customDashPen.DashPattern = myDashes
        g.DrawRectangle(customDashPen, ClientRectangle)
    End Sub

    Private Sub MainForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Invalidate()
    End Sub
End Class
