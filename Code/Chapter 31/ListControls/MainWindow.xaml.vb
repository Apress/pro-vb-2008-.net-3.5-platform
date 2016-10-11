Class MainWindow

  Public Sub New()
    InitializeComponent()

    FillListBox()
  End Sub

  Private Sub FillListBox()
    ' Add items to the list box.
    lstVideoGameConsoles.Items.Add("Microsoft XBox 360")
    lstVideoGameConsoles.Items.Add("Sony Playstation 3")
    lstVideoGameConsoles.Items.Add("Nintendo Wii")
    lstVideoGameConsoles.Items.Add("Sony PSP")
    lstVideoGameConsoles.Items.Add("Nintendo DS")
  End Sub

  Private Sub btnGetGameSystem_Click(ByVal sender As System.Object, _
                                     ByVal e As System.Windows.RoutedEventArgs)
    Dim data As String = String.Empty
    data &= String.Format("SelectedIndex = {0}" & vbLf, _
                          lstVideoGameConsoles.SelectedIndex)
    data &= String.Format("SelectedItem = {0}" & vbLf, _
                          lstVideoGameConsoles.SelectedItem)
    data &= String.Format("SelectedValue = {0}" & vbLf, _
                          lstVideoGameConsoles.SelectedValue)
    MessageBox.Show(data, "Your Game Info")
  End Sub

  Protected Sub btnGetColor_Click(ByVal sender As Object, ByVal args As RoutedEventArgs)
    Dim data As String = String.Empty
    data &= String.Format("SelectedIndex = {0}" & vbLf, lstColors.SelectedIndex)
    data &= String.Format("SelectedItem = {0}" & vbLf, lstColors.SelectedItem)
    data &= String.Format("SelectedValue = {0}", _
                          TryCast(lstColors.Items(lstColors.SelectedIndex), StackPanel).Tag)
    MessageBox.Show(data, "Your Color Info")
  End Sub
End Class
