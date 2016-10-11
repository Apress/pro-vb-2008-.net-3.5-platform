Option Explicit On
Option Strict On

Imports System.Drawing.Drawing2D

Public Class MainForm

    Private Sub MainForm_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim r As Rectangle = New Rectangle(10, 10, 100, 100)

        ' A gradient brush.
        Dim theBrush As LinearGradientBrush = Nothing
        Dim yOffSet As Integer = 10

        ' Get all members of the LinearGradientMode enum.
        Dim obj As Array = [Enum].GetValues(GetType(LinearGradientMode))

        For x As Integer = 0 To obj.Length - 1
            ' Draw an oval with a LinearGradientMode member.
            ' Configure Brush.
            Dim temp As LinearGradientMode = CType(obj.GetValue(x), LinearGradientMode)
            theBrush = New LinearGradientBrush(r, Color.GreenYellow, Color.Blue, temp)

            ' Print name of LinearGradientMode enum.
            g.DrawString(temp.ToString(), _
              New Font("Times New Roman", 10), _
              New SolidBrush(Color.Black), 0, yOffSet)
            ' Fill a rectangle with the correct brush.
            g.FillRectangle(theBrush, 150, yOffSet, 200, 50)
            yOffSet += 80
        Next
    End Sub
End Class
