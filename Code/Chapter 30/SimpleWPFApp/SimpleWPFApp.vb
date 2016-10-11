' A simple WPF application, written without XAML or Visual Studio.
Imports System
Imports System.Windows
Imports System.Windows.Controls

' In this first example, we are defining a single class type to 
' represent the application itself and the main window.
Class MyWPFApp
  Inherits Application

	<STAThread()> _
	Shared Sub Main()
		' Handle the Startup and Exit events, and then run the application.
		Dim app As New MyWPFApp()
		AddHandler app.Startup, AddressOf AppStartUp
		AddHandler app.Exit, AddressOf AppExit

		' Fires the Startup event.
		app.Run()
	End Sub

	Shared Sub AppExit(ByVal sender As Object, ByVal e As ExitEventArgs)
		MessageBox.Show("App has exited")
	End Sub

	Shared Sub AppStartUp(ByVal sender As Object, ByVal e As StartupEventArgs)
	  ' Create a MainWindow object. 
	  Dim wnd As new MainWindow("My better WPF App!", 200, 300)
	End Sub

End Class

Class MainWindow
  Inherits Window
  ' Our UI element.
  Private btnExitApp As New Button()

  Public Sub New(ByVal windowTitle As String, ByVal height As Integer, _
    ByVal width As Integer)
    ' Configure button and set the child control.
    AddHandler btnExitApp.Click, AddressOf btnExitApp_Clicked
    btnExitApp.Content = "Exit Application"
    btnExitApp.Height = 25
    btnExitApp.Width = 100

    ' Set the content of this window to a single button.
    Me.AddChild(btnExitApp)

    ' Configure the window.
    Me.Title = windowTitle
    Me.WindowStartupLocation = WindowStartupLocation.CenterScreen
    Me.Height = height
    Me.Width = width
    Me.Show()
  End Sub

  Sub btnExitApp_Clicked(ByVal sender As Object, ByVal e As RoutedEventArgs)
    ' Get a handle to the current application and shut it down.
    Application.Current.Shutdown()
  End Sub
End Class

