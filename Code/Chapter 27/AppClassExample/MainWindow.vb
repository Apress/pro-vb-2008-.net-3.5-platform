Imports System.Windows.Forms
Imports System.Reflection

' Assembly-level attributes.
<assembly:AssemblyCompany("Intertech")>
<assembly:AssemblyProduct("A Better Window")>
<assembly:AssemblyVersion("1.1.0.0")>

Namespace MyWindowsApp
  Public Class MainWindow
    Inherits Form
	  ' Reflect over attributes using Application type.
    Public Sub New
      MessageBox.Show(String.Format("This app brought to you by {0}", _
        Application.CompanyName), _
		Application.ProductName)
		
      ' Handle Application.Exit event.
      AddHandler Application.ApplicationExit, AddressOf MainWindow_OnExit
    End Sub
	
	Public Sub MainWindow_OnExit(ByVal sender As Object, ByVal args As EventArgs)
		MessageBox.Show(string.Format("Form version {0} has terminated.", _
		Application.ProductVersion))
	End Sub
  End Class

  Public Module Program
    ' Run this application and identify the main window.
    Sub Main()
      Application.Run(New MainWindow())
    End Sub
  End Module
End Namespace
