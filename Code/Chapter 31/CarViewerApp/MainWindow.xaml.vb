Class MainWindow
  Private myCars As New CarList()

  Private Sub AddNewCarWizard(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
    Dim dlg As New AddNewCarDialog()
    If True = dlg.ShowDialog() Then
      If dlg.SelectedCar IsNot Nothing Then
        myCars.Add(dlg.SelectedCar)
      End If
    End If
  End Sub

  Private Sub ListItemSelected(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
    ' Get correct car from the ObservableCollection based
    ' on the selected item in the list box. Then call toString().
    txtCarStats.Text = myCars(allCars.SelectedIndex).ToString()
  End Sub

  Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
    ' Set the data context.
    allCars.DataContext = myCars
  End Sub

  Private Sub ExitApplication(ByVal sender As System.Object, _
                              ByVal e As System.Windows.RoutedEventArgs)
    Application.Current.Shutdown()
  End Sub
End Class
