Class MainWindow
  ' This is used to hold data on the mouse-related
  ' activity.
  Private mouseActivityOuterEllipse As String = String.Empty

  Public Sub New()
    InitializeComponent()
  End Sub

  Public Sub btnClickMe_Clicked(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Show the final string.
    mouseActivityOuterEllipse &= "Button Click event fired!" & vbLf
    MessageBox.Show(mouseActivityOuterEllipse)

    ' Clear string for next test.
    mouseActivityOuterEllipse = String.Empty
  End Sub

  Public Sub outerEllipse_MouseDown(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Add data to string.
    mouseActivityOuterEllipse &= "MouseDown event fired!" & vbLf
  End Sub

  Public Sub outerEllipse_PreviewMouseDown(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Add data to string.
    mouseActivityOuterEllipse = "PreviewMouseDown event fired!" & vbLf
  End Sub
End Class
