Imports System.Windows.Forms

Namespace MyWindowsApp
  Public Class MainWindow
    Inherits Form
  End Class

  Public Module Program
    ' Run this application and identify the main window.
    Sub Main()
      Application.Run(New MainWindow())
    End Sub
  End Module
End Namespace
