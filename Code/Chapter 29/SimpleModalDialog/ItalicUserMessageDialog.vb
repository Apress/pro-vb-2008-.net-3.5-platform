Option Explicit On
Option Strict On

Public Class ItalicUserMessageDialog
    Public Property Italic() As Boolean
        Get
            Return checkBoxItalic.Checked
        End Get
        Set(ByVal value As Boolean)
            checkBoxItalic.Checked = value
        End Set
    End Property
End Class
