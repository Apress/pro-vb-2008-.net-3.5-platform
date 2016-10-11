Option Explicit On
Option Strict On

Imports System.Drawing.Drawing2D

Public Class MainForm
    Private Sub MainForm_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim thePen As Pen = New Pen(Color.Black, 10)
        Dim yOffSet As Integer = 10
        ' Get all members of the LineCap enum.
        Dim obj As Array = [Enum].GetValues(GetType(LineCap))
        For x As Integer = 0 To obj.Length - 1
            ' Draw a line with a LineCap member.
            ' Get next cap and configure pen.
            Dim temp As LineCap = CType(obj.GetValue(x), LineCap)
            thePen.StartCap = temp
            thePen.EndCap = temp
            ' Print name of LineCap enum.
            g.DrawString(temp.ToString(), New Font("Times New Roman", 10), _
              New SolidBrush(Color.Black), 0, yOffSet)
            ' Draw a line with the correct cap.
            g.DrawLine(thePen, 100, yOffSet, Width - 50, yOffSet)
            yOffSet += 40
        Next
    End Sub

    Private Sub MainForm_Resize(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles MyBase.Resize
        Invalidate()
    End Sub
End Class
