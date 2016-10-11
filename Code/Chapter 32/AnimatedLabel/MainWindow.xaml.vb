Imports System.Windows.Media.Animation

Class MainWindow

  Private Sub btnAnimatelblMessage_Click(ByVal sender As System.Object, _
                                         ByVal e As System.Windows.RoutedEventArgs)
    ' Take 4 seconds to complete the animation.
    Dim dblAnim As New DoubleAnimation()
    dblAnim.From = 40
    dblAnim.To = 200

    dblAnim.Duration = New Duration(TimeSpan.FromSeconds(4))
    ' Loop forever.
    dblAnim.RepeatBehavior = RepeatBehavior.Forever
    ' Reverse when done.
    dblAnim.AutoReverse = True

    lblHeight.BeginAnimation(Label.HeightProperty, dblAnim)
  End Sub

  Private Sub btnAnimatelblTransparency_Click(ByVal sender As System.Object, _
                                              ByVal e As System.Windows.RoutedEventArgs)
    ' This will change the opacity of the label
    Dim dblAnim As New DoubleAnimation()
    dblAnim.From = 1
    dblAnim.To = 0
    dblAnim.Duration = New Duration(TimeSpan.FromSeconds(10))
    lblTransparency.BeginAnimation(Label.OpacityProperty, dblAnim)
  End Sub
End Class
