Option Explicit On
Option Strict On

Public Class MainForm
    Private Sub MainForm_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) _
    Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim myFamily As FontFamily = New FontFamily("Verdana")
        Dim myFont As Font = New Font(myFamily, 12)
        Dim y As Integer = 0
        Dim fontHeight As Integer = myFont.Height

        ' Show units of measurement for FontFamily members.
        Me.Text = "Measurements are in GraphicsUnit." & myFont.Unit.ToString()
        g.DrawString("The Verdana family.", myFont, Brushes.Blue, 10, y)
        y += 20
        ' Print our family ties...
        g.DrawString("Ascent for bold Verdana: " _
          & myFamily.GetCellAscent(FontStyle.Bold), _
          myFont, Brushes.Black, 10, y + fontHeight)
        y += 20
        g.DrawString("Descent for bold Verdana: " _
          & myFamily.GetCellDescent(FontStyle.Bold), _
          myFont, Brushes.Black, 10, y + fontHeight)
        y += 20
        g.DrawString("Line spacing for bold Verdana: " _
          & myFamily.GetLineSpacing(FontStyle.Bold), _
          myFont, Brushes.Black, 10, y + fontHeight)
        y += 20
        g.DrawString("Height for bold Verdana: " & _
          myFamily.GetEmHeight(FontStyle.Bold), _
          myFont, Brushes.Black, 10, y + fontHeight)
        y += 20
    End Sub
End Class
