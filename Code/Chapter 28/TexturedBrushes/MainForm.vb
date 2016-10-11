Option Explicit On
Option Strict On

Public Class MainForm
  Private texturedTextBrush As Brush
  Private texturedBGroundBrush As Brush

  Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    CenterToScreen()

    ' Load images brushes.
    Try
      Dim bGroundBrushImage As Image = New Bitmap("Clouds.bmp")
      texturedBGroundBrush = New TextureBrush(bGroundBrushImage)
      Dim textBrushImage As Image = New Bitmap("Soap Bubbles.bmp")
      texturedTextBrush = New TextureBrush(textBrushImage)
    Catch
      MessageBox.Show("Can't find bitmap files!")
      Application.Exit()
    End Try
  End Sub

#Region "Event Handlers"
  Private Sub MainForm_Paint(ByVal sender As System.Object, _
   ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    Dim g As Graphics = e.Graphics
    Dim r As Rectangle = ClientRectangle

    ' Paint the clouds on the client area.
    g.FillRectangle(texturedBGroundBrush, r)

    ' Some big bold text with a textured brush.
    g.DrawString("Bitmaps as brushes!  Way cool...", _
      New Font("Arial", 50, FontStyle.Bold Or FontStyle.Italic), texturedTextBrush, r)
  End Sub

  Private Sub MainForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    Invalidate()
  End Sub
#End Region

End Class
