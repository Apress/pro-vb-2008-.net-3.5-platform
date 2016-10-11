Class MainWindow

  Private Sub btnOK_Click(ByVal sender As System.Object, _
    ByVal e As System.Windows.RoutedEventArgs)
    Dim spellingHints As String = String.Empty

    ' Same spell checking logic as before...
    If CheckPassword() Then
      ' Try to get a spelling error at the current caret location.
      Dim err As SpellingError = txtData.GetSpellingError(txtData.CaretIndex)
      If err IsNot Nothing Then
        ' Build a string of spelling suggestions.
        For Each s As String In err.Suggestions
          spellingHints &= s & vbLf
        Next
        ' Show suggestions.
        MessageBox.Show(spellingHints, "Try these instead")
      End If
    Else
      MessageBox.Show("Security error!!")
    End If
  End Sub

  Private Function CheckPassword() As Boolean
    If pwdText.Password = "Chucky" Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub Window1_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Window1.Loaded

  End Sub
End Class
