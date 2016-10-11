Option Explicit On
Option Strict On

Public Class MainForm
  ' The unit of measurement.
  Private gUnit As GraphicsUnit = GraphicsUnit.Pixel

  ' Point of origin.
  Private renderingOrgPt As New Point(0, 0)

#Region "Menu Handlers"
  Private Sub pointToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pointToolStripMenuItem.Click
    gUnit = GraphicsUnit.Point
    Invalidate()
  End Sub

  Private Sub documentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles documentToolStripMenuItem.Click
    gUnit = GraphicsUnit.Document
    Invalidate()
  End Sub

  Private Sub displayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayToolStripMenuItem.Click
    gUnit = GraphicsUnit.Display
    Invalidate()
  End Sub

  Private Sub milliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles milliToolStripMenuItem.Click
    gUnit = GraphicsUnit.Millimeter
    Invalidate()
  End Sub

  Private Sub inchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inchToolStripMenuItem.Click
    gUnit = GraphicsUnit.Inch
    Invalidate()
  End Sub

  Private Sub pixelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pixelToolStripMenuItem.Click
    gUnit = GraphicsUnit.Pixel
    Invalidate()
  End Sub

  Private Sub toolStripMenuItem100by100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripMenuItem100by100.Click
    renderingOrgPt.X = 100
    renderingOrgPt.Y = 100
    Invalidate()
  End Sub

  Private Sub toolStripMenuItem5by5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripMenuItem5by5.Click
    renderingOrgPt.X = 5
    renderingOrgPt.Y = 5
    Invalidate()
  End Sub

  Private Sub toolStripMenuItem0by0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripMenuItem0by0.Click
    renderingOrgPt.X = 0
    renderingOrgPt.Y = 0
    Invalidate()
  End Sub
#End Region

  Private Sub MainForm_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    Dim g As Graphics = e.Graphics
    ' Configure graphics unit.
    g.PageUnit = gUnit
    ' Configure origin.
    g.TranslateTransform(renderingOrgPt.X, renderingOrgPt.Y)
    g.DrawRectangle(New Pen(Color.Red, 5), 0, 0, 100, 100)
    Me.Text = String.Format("PageUnit: {0}, Origin: {1}", gUnit, renderingOrgPt.ToString())
  End Sub
End Class
