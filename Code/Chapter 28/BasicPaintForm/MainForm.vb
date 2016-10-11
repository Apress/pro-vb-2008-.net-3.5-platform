Public Class MainForm
  ' Used to hold all the Points.
  Private myPts As New List(Of Point)

  Private Sub MainForm_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    Dim g As Graphics = e.Graphics
    g.DrawString("Hello GDI+", New Font("Times New Roman", 20), _
                 Brushes.Green, 0, 0)

    ' Now render all the Points.
    For Each p As Point In myPts
      g.FillEllipse(Brushes.DarkOrange, p.X, p.Y, 10, 10)
    Next
  End Sub

  Private Sub MainForm_MouseDown(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
    ' Add new point to list.
    myPts.Add(New Point(e.X, e.Y))
    Invalidate()
  End Sub

End Class
