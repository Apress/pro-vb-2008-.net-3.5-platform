Class MainWindow
  Public Sub New()
    InitializeComponent()

    ' Add items to our list box.
    lstStyles.Items.Add("TiltStyle")
    lstStyles.Items.Add("GreenStyle")
    lstStyles.Items.Add("MouseOverStyle")
  End Sub

  Private Sub lstStyles_Changed(ByVal sender As System.Object, _
                                  ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
    ' Get the selected style name from the list box.      
    Dim currStyle As System.Windows.Style = DirectCast(FindResource(lstStyles.SelectedValue), System.Windows.Style)

    ' Set the style of the button type.
    Me.btnMouseOverStyle.Style = currStyle
  End Sub
End Class
