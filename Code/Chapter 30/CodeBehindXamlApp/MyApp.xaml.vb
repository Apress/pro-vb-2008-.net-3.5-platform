' MyApp.xaml.vb
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace SimpleXamlApp
  Public Partial Class MyApp
    Inherits Application
    Private Sub AppExit(ByVal sender As Object, ByVal e As ExitEventArgs)
      MessageBox.Show("App has exited")
    End Sub
  End Class
End Namespace
