Option Explicit On
Option Strict On

Imports System.Drawing.Text

Public Class MainForm
  Private swellValue As Integer
  Private strFontFace As String = "WingDings"
  Private installedFonts As String

  Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    BackColor = Color.Honeydew
    CenterToScreen()
    ' Configure the Timer.
    swellTimer.Enabled = True
    swellTimer.Interval = 100
  End Sub

#Region "Event handlers"
  Private Sub swellToolStripMenuItem_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles swellToolStripMenuItem.Click
    swellTimer.Enabled = Not swellTimer.Enabled
  End Sub

  Private Sub arialToolStripMenuItem_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles arialToolStripMenuItem.Click
    strFontFace = "Arial"
    Invalidate()
  End Sub

  Private Sub timesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timesToolStripMenuItem.Click
    strFontFace = "Times New Roman"
    Invalidate()
  End Sub

  Private Sub wingDingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wingDingsToolStripMenuItem.Click
    strFontFace = "WingDings"
    Invalidate()
  End Sub

  Private Sub listInstalledFontsToolStripMenuItem_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles listInstalledFontsToolStripMenuItem.Click
    Dim fonts As InstalledFontCollection = New InstalledFontCollection()
    For i As Integer = 0 To fonts.Families.Length - 1
      installedFonts &= fonts.Families(i).Name & " "
    Next
    ' This time, we need to invalidate the entire client area,
    ' as we will paint the installedFonts string on the lower half
    ' of the client rectangle.
    Invalidate()
  End Sub

  Private Sub swellTimer_Tick(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles swellTimer.Tick
    ' Increase current swellValue by 5.
    swellValue += 5
    ' If this value is greater than or equal to 50, reset to zero.
    If swellValue >= 50 Then
      swellValue = 0
    End If
    ' Just invalidate the 'minimal dirty rectangle to help reduce flicker.
    Invalidate(New Rectangle(0, 0, ClientRectangle.Width, 100))
  End Sub

  Private Sub MainForm_Paint(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    Dim g As Graphics = e.Graphics
    Dim theFont As Font = New Font(strFontFace, 12 + swellValue)
    Dim message As String = "Hello GDI+"

    ' Display message in the center of the window!
    Dim windowCenter As Single = CSng(Me.DisplayRectangle.Width / 2)
    Dim stringSize As SizeF = e.Graphics.MeasureString(message, theFont)
    Dim startPos As Single = windowCenter - (stringSize.Width / 2)
    g.DrawString(message, theFont, Brushes.Blue, startPos, 10)

    ' Show installed fonts in the rectangle below the swell area.
    Dim myRect As Rectangle = New Rectangle(0, 100, ClientRectangle.Width, ClientRectangle.Height)
    ' Paint this area of the Form black.
    g.FillRectangle(New SolidBrush(Color.Black), myRect)
    g.DrawString(installedFonts, New Font("Arial", 12), Brushes.White, myRect)
  End Sub

  Private Sub MainForm_Resize(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles MyBase.Resize
    Invalidate()
  End Sub
#End Region

End Class
