Class MainWindow
  Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    SetF1CommandBinding()
  End Sub

  Private Sub FileExit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
    ' Terminate the application.
    Application.Current.Shutdown()
  End Sub

  Private Sub ToolsSpellingHints_Click(ByVal sender As Object, ByVal args As RoutedEventArgs)
    Dim spellingHints As String = String.Empty

    ' Try to get a spelling error at the current caret location.
    Dim err As SpellingError = txtData.GetSpellingError(txtData.CaretIndex)
    If err IsNot Nothing Then
      ' Build a string of spelling suggestions.
      For Each s As String In err.Suggestions
        spellingHints &= s & vbLf
      Next

      ' Show suggestions on Label within Expander.
      lblSpellingHints.Content = spellingHints

      ' Expand the expander.
      expanderSpelling.IsExpanded = True
    End If
  End Sub
  Private Sub MouseEnterExitArea(ByVal sender As Object, ByVal args As RoutedEventArgs)
    statBarText.Text = "Exit the Application"
  End Sub
  Private Sub MouseEnterToolsHintsArea(ByVal sender As Object, ByVal args As RoutedEventArgs)
    statBarText.Text = "Show Spelling Suggestions"
  End Sub
  Private Sub MouseLeaveArea(ByVal sender As Object, ByVal args As RoutedEventArgs)
    statBarText.Text = "Ready"
  End Sub

  Private Sub SetF1CommandBinding()
    Dim helpBinding As New CommandBinding(ApplicationCommands.Help)
    AddHandler helpBinding.CanExecute, AddressOf CanHelpExecute
    AddHandler helpBinding.Executed, AddressOf HelpExecuted
    CommandBindings.Add(helpBinding)
  End Sub

  Private Sub CanHelpExecute(ByVal sender As Object, _
  ByVal e As CanExecuteRoutedEventArgs)
    ' Here, you can set CanExecute to false if you wish to prevent the
    ' command from executing if you desire.
    e.CanExecute = True
  End Sub

  Private Sub HelpExecuted(ByVal sender As Object, _
    ByVal e As ExecutedRoutedEventArgs)
    MessageBox.Show("Dude, it is not that difficult. Just type something!", _
                    "Help!")
  End Sub

End Class


