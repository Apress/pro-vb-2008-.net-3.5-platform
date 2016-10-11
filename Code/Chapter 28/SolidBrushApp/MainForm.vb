Option Explicit On
Option Strict On

Public Class MainForm

  Private Sub MainForm_Paint(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    Dim g As Graphics = e.Graphics
    ' Make a blue SolidBrush.
    Dim blueBrush As SolidBrush = New SolidBrush(Color.Blue)

    ' Get a stock brush from the Brushes type.
    Dim pen2 As SolidBrush = CType(Brushes.Firebrick, SolidBrush)

    ' Render some shapes with the brushes.
    g.FillEllipse(blueBrush, 10, 10, 100, 100)
    g.FillPie(Brushes.Black, 150, 10, 120, 150, 90, 80)

    ' Draw a purple polygon as well...
    Dim brush3 As SolidBrush = New SolidBrush(Color.Purple)
    g.FillPolygon(brush3, New Point() {New Point(30, 140), _
     New Point(265, 200), New Point(100, 225), _
     New Point(190, 190), New Point(50, 330), _
     New Point(20, 180)})

    ' And a rectangle with some text...
    Dim r As Rectangle = New Rectangle(150, 10, 130, 60)
    g.FillRectangle(Brushes.Blue, r)
    g.DrawString("Hello out there...How are ya?", New Font("Arial", 12), Brushes.White, r)
  End Sub
End Class
