Public Class MainWindow

  ' Which format to display?
  Private dtFormat As DateTimeFormat = DateTimeFormat.ShowClock

  ' Marks the item checked.
  Private currentCheckedItem As ToolStripMenuItem

  Public Sub New()
    ' This call is required by the Windows Forms designer.
    InitializeComponent()

    ' These properties can also be set
    ' with the Properties window.
    Text = "Status Strip Example"
    CenterToScreen()
    currentCheckedItem = currentTimeToolStripMenuItem
    currentCheckedItem.Checked = True
  End Sub

  Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    Application.Exit()
  End Sub

  Private Sub aboutToolStripMenuItem_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    MessageBox.Show("My StatusStripApp!")
  End Sub

#Region "Mouse Hover event handlers"
  Private Sub exitToolStripMenuItem_MouseHover(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.MouseHover
    toolStripStatusLabelMenuState.Text = "Exits the app."
  End Sub

  Private Sub aboutToolStripMenuItem_MouseHover(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.MouseHover
    toolStripStatusLabelMenuState.Text = "Shows about box."
  End Sub

  Private Sub dayoftheWeekToolStripMenuItem_MouseHover(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles DayOfTheWeekToolStripMenuItem.MouseHover
    toolStripStatusLabelMenuState.Text = "Shows the day of the week."
  End Sub

  Private Sub currentTimeToolStripMenuItem_MouseHover(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles CurrentTimeToolStripMenuItem.MouseHover
    toolStripStatusLabelMenuState.Text = "Shows the current time."
  End Sub
#End Region

#Region "Pop up button Click event handlers"
  Private Sub currentTimeToolStripMenuItem_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles CurrentTimeToolStripMenuItem.Click
    ' Toggle check mark and set pane format to time.
    currentCheckedItem.Checked = False
    dtFormat = DateTimeFormat.ShowClock
    currentCheckedItem = CurrentTimeToolStripMenuItem
    currentCheckedItem.Checked = True
  End Sub

  Private Sub dayoftheWeekToolStripMenuItem_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles DayOfTheWeekToolStripMenuItem.Click
    ' Toggle check mark and set pane format to date.
    currentCheckedItem.Checked = False
    dtFormat = DateTimeFormat.ShowDay
    currentCheckedItem = DayOfTheWeekToolStripMenuItem
    currentCheckedItem.Checked = True
  End Sub
#End Region

#Region "Timer Tick Event Handler"
  Private Sub timerDateTimeUpdate_Tick(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles timerDateTimeUpdate.Tick
    Dim panelInfo As String = ""

    ' Create current format.
    If dtFormat = DateTimeFormat.ShowClock Then
      panelInfo = DateTime.Now.ToLongTimeString
    Else
      panelInfo = DateTime.Now.ToLongDateString
    End If

    ' Set text on pane.
    toolStripStatusLabelClock.Text = panelInfo
  End Sub
#End Region

#Region "Mouse Leave event for menu items"
  Private Sub Handle_MouseLeave(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles CurrentTimeToolStripMenuItem.MouseLeave, _
                                       ExitToolStripMenuItem.MouseLeave, _
                                       DayOfTheWeekToolStripMenuItem.MouseLeave, _
                                       AboutToolStripMenuItem.MouseLeave
    toolStripStatusLabelMenuState.Text = "Ready."
  End Sub
#End Region

End Class

Public Enum DateTimeFormat
  ShowClock
  ShowDay
End Enum
