' Helper enum for font size.
Public Enum TextFontSize
  FontSizeHuge = 30
  FontSizeNormal = 20
  FontSizeTiny = 8
End Enum

Public Class MainWindow
  Private currFontSize As TextFontSize = TextFontSize.FontSizeNormal

  ' Marks the item checked.
  Private WithEvents currentCheckedItem As ToolStripMenuItem

  Public Sub New()
    ' Call InitializeComponent() when defining your own constructor!
    InitializeComponent()

    ' Inherited method to center the Form.
    CenterToScreen()

    ' Now check the 'Normal' menu item.
    currentCheckedItem = normalToolStripMenuItem
    currentCheckedItem.Checked = True
  End Sub

  Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    Application.Exit()
  End Sub

  Private Sub toolStripTextBoxColor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripTextBoxColor.Leave
    Try
      BackColor = Color.FromName(toolStripTextBoxColor.Text)
    Catch ' Just do nothing if the user provides bad data
    End Try
  End Sub

  Private Sub MainWindow_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
    Dim g As Graphics = e.Graphics
    g.DrawString("Right click on me...", _
      New Font("Times New Roman", currFontSize), _
      New SolidBrush(Color.Black), 50, 50)
  End Sub

  ' This one event handler handles the Click event from each context menu item.
  Private Sub ContextMenuItemSelection_Clicked(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles HugeToolStripMenuItem.Click, _
    TinyToolStripMenuItem.Click, NormalToolStripMenuItem.Click

    ' Obtain the currently clicked ToolStripMenuItem.
    Dim miClicked As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

    ' Uncheck the currently checked item.
    currentCheckedItem.Checked = False

    ' Figure out which item was clicked using its Name.
    If miClicked.Name = "HugeToolStripMenuItem" Then
      currFontSize = TextFontSize.FontSizeHuge
    End If
    If miClicked.Name = "NormalToolStripMenuItem" Then
      currFontSize = TextFontSize.FontSizeNormal
    End If
    If miClicked.Name = "TinyToolStripMenuItem" Then
      currFontSize = TextFontSize.FontSizeTiny
    End If

    ' Tell the Form to repaint itself.
    Invalidate()

    ' Establish which item to check.
    If miClicked.Name = "HugeToolStripMenuItem" Then
      currFontSize = TextFontSize.FontSizeHuge
      currentCheckedItem = HugeToolStripMenuItem
    End If
    If miClicked.Name = "NormalToolStripMenuItem" Then
      currFontSize = TextFontSize.FontSizeNormal
      currentCheckedItem = NormalToolStripMenuItem
    End If
    If miClicked.Name = "TinyToolStripMenuItem" Then
      currFontSize = TextFontSize.FontSizeTiny
      currentCheckedItem = TinyToolStripMenuItem
    End If

    ' Check new item.
    currentCheckedItem.Checked = True
  End Sub

End Class
