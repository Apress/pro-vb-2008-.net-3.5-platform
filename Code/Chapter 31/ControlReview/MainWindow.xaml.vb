Class MainWindow
  Sub New()
    InitializeComponent()
    ' Change FontSize of Label.
    lblInstructions.FontSize = 14
  End Sub

  Private Sub btnPurchaseOptions_Click(ByVal sender As System.Object, _
  ByVal e As System.Windows.RoutedEventArgs) Handles btnPurchaseOptions.Click
    MessageBox.Show("Button has been clicked")
  End Sub

End Class


