Option Explicit On
Option Strict On

Public Class MainWindow
  ' The current, max, and min font sizes.
  Private currFontSize As Integer = 12
  Const MinFontSize As Integer = 12
  Const MaxFontSize As Integer = 70

  Public Sub New()
    InitializeComponent()
    CenterToScreen()
    Text = String.Format("Your Font size is: {0}", currFontSize)
  End Sub

#Region "Event Handlers"
  Private Sub toolStripButtonShrinkFont_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles toolStripButtonShrinkFont.Click
    ' Reduce font size by 5 and refresh display.
    currFontSize -= 5
    If (currFontSize <= MinFontSize) Then
      currFontSize = MinFontSize
    End If
    Text = String.Format("Your Font size is: {0}", currFontSize)
    toolStripContainer1.Invalidate(True)
  End Sub

  Private Sub toolStripButtonGrowFont_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles toolStripButtonGrowFont.Click
    ' Increase font size by 5 and refresh display.
    currFontSize += 5
    If (currFontSize >= MaxFontSize) Then
      currFontSize = MaxFontSize
    End If
    Text = String.Format("Your Font size is: {0}", currFontSize)
    toolStripContainer1.Invalidate(True)
  End Sub

  Private Sub ContentPanel_Paint(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.PaintEventArgs) Handles toolStripContainer1.ContentPanel.Paint, ContentPanel.Paint

    ' Paint the user-defined message.
    Dim g As Graphics = e.Graphics
    g.DrawString(toolStripTextBoxMessage.Text, _
      New Font("Times New Roman", currFontSize), _
      Brushes.Black, 10, 60)
  End Sub
#End Region

End Class

