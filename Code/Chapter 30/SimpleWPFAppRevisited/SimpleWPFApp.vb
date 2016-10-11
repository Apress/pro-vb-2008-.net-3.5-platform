' A simple WPF application, written without XAML.
Imports System
Imports System.Windows
Imports System.Windows.Controls

' In this first example, we are defining a single class type to 
' represent the application itself and the main window.
Public Class MyWPFApp
	Inherits Application
	<STAThread()> _
	Public Shared Sub Main()
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
		' Check the incoming command-line arguments and see if they 
		' specified a flag for /GODMODE.
		Application.Current.Properties("GodMode") = False
		For Each arg As String In e.Args
			If arg.ToLower() = "/godmode" Then
				Application.Current.Properties("GodMode") = True
				Exit For
			End If
		Next

		' Create a MainWindow object. 
		Dim wnd As New MainWindow("My better WPF App!", 200, 300)
	End Sub

End Class

Class MainWindow
  Inherits Window
	Private btnExitApp As New Button()

	' This string will document which events fire, and when.
	Private lifeTimeData As String = String.Empty

	Protected Sub MainWindow_Activated(ByVal sender As Object, ByVal e As EventArgs)
		lifeTimeData &= "Activate Event Fired!" & vbLf
	End Sub
	Protected Sub MainWindow_Deactivated(ByVal sender As Object, ByVal e As EventArgs)
		lifeTimeData &= "Deactivated Event Fired!" & vbLf
	End Sub
	Protected Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As EventArgs)
		lifeTimeData &= "Loaded Event Fired!" & vbLf
	End Sub

	Protected Sub MainWindow_Closing(ByVal sender As Object, _
	  ByVal e As System.ComponentModel.CancelEventArgs)
	  lifeTimeData &= "Closing Event Fired!" & vbLf

	  ' See if the user really wants to shut down this window.
	  Dim msg As String = "Do you want to close without saving?"
	  Dim result As MessageBoxResult = MessageBox.Show(msg, _
		"My App", MessageBoxButton.YesNo, MessageBoxImage.Warning)
	  If result = MessageBoxResult.No Then
		' If user doesn't want to close, cancel closure.
		e.Cancel = True
	  End If
	End Sub

	Protected Sub MainWindow_MouseMove(ByVal sender As Object, _
	  ByVal e As System.Windows.Input.MouseEventArgs)
	  ' Set the title of the window to the current X,Y of the mouse.
	  Me.Title = e.GetPosition(Me).ToString() 
	End Sub
	
	Protected Sub MainWindow_Closed(ByVal sender As Object, ByVal e As EventArgs)
	  lifeTimeData &= "Closed Event Fired!" & vbLf
	  MessageBox.Show(lifeTimeData)
	End Sub
	
	Protected Sub MainWindow_KeyUp(ByVal sender As Object, _
	  ByVal e As System.Windows.Input. KeyEventArgs)
	  ' Display keypress.
	  Me.Title = e.Key.ToString() 
	End Sub
	
	Public Sub New(ByVal windowTitle As String, ByVal height As Integer, _
	  ByVal width As Integer)
		' Rig up events.
		AddHandler Me.Activated, AddressOf MainWindow_Activated
		AddHandler Me.Deactivated, AddressOf MainWindow_Deactivated
		AddHandler btnExitApp.Click, AddressOf btnExitApp_Clicked
		AddHandler Me.Closing, AddressOf MainWindow_Closing
		AddHandler Me.Closed, AddressOf MainWindow_Closed
		AddHandler Me.MouseMove, AddressOf MainWindow_MouseMove
		AddHandler Me.KeyUp, AddressOf MainWindow_KeyUp
		
		' Configure button and set the child control.
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
		' Did user enable /godmode?
		If CBool(Application.Current.Properties("GodMode")) Then
			MessageBox.Show("Cheater!")
		End If

		' Get a handle to the current application and shut it down.
		' Application.Current.Shutdown()
		Me.Close()
	End Sub
End Class
