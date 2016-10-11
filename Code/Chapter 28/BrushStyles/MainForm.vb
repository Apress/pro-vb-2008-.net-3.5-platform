Option Explicit On
Option Strict On

Imports System.Drawing.Drawing2D

Public Class MainForm
  Private Sub MainForm_Paint(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    Dim g As Graphics = e.Graphics
    Dim yOffSet As Integer = 10

    ' Get all members of the HatchStyle enum.
    Dim obj As Array = [Enum].GetValues(GetType(HatchStyle))

    For x As Integer = 0 To 4
      ' Draw an oval with first 5 HatchStyle values.
      ' Configure Brush.
      Dim temp As HatchStyle = CType(obj.GetValue(x), HatchStyle)
      Dim theBrush As HatchBrush = New HatchBrush(temp, Color.White, Color.Black)
      ' Print name of HatchStyle enum.
      g.DrawString(temp.ToString(), New Font("Times New Roman", 10), Brushes.Black, 0, yOffSet)
      ' Fill a rectangle with the correct brush.
      g.FillEllipse(theBrush, 150, yOffSet, 200, 25)
      yOffSet += 40
    Next
  End Sub
End Class
