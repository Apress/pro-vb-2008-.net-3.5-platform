Class MainWindow
  Private currValue As Integer = 0

  Public Sub New()
    InitializeComponent()
    lblCurrentValue.Content = currValue
  End Sub
  Protected Sub repeatAddValueButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Add 1 to the current value and show in label.
    currValue += 1
    lblCurrentValue.Content = currValue
  End Sub

  Protected Sub repeatRemoveValueButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Subtract 1 from the current value and show in label.
    currValue -= 1
    lblCurrentValue.Content = currValue
  End Sub
End Class
