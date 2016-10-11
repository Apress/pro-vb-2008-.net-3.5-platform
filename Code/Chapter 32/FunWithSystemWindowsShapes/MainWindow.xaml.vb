Class MainWindow

  Private Sub SimpleLine_MouseEnter(ByVal sender As System.Object, _
                                    ByVal e As System.Windows.Input.MouseEventArgs)
    Me.Title = String.Format("Mouse entered at: {0}", _
    e.GetPosition(SimpleLine))
  End Sub
End Class
