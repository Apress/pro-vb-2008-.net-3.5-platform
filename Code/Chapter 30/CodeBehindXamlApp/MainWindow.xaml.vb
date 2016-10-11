' MainWindow.xaml.vb
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace SimpleXamlApp
  Public Partial Class MainWindow
    Inherits Window
    Public Sub New()
      ' Remember!  This method is defined
      ' within the generated MainWindow.g.vb file.
      InitializeComponent()
    End Sub

    Private Sub btnExitApp_Clicked(ByVal sender As Object, _
      ByVal e As RoutedEventArgs)
      ' Get a handle to the current application and shut it down.
      Application.Current.Shutdown()
    End Sub
  End Class
End Namespace
