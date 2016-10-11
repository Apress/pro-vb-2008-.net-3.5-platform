Option Explicit On
Option Strict On

Public Class UserMessageDialog
    Public Property Message() As String
        Get
            Return txtUserInput.Text
        End Get
        Set(ByVal value As String)
            txtUserInput.Text = value
        End Set
    End Property
End Class