Option Explicit On
Option Strict On

Public Class CarEventArgs
  Inherits EventArgs

  Public ReadOnly msgData As String
  Public Sub New(ByVal msg As String)
    msgData = msg
  End Sub
End Class
