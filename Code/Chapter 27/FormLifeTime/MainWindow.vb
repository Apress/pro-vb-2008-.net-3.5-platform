Imports System.Windows.Forms
Imports System.ComponentModel 

Public Class MainWindow
  Inherits Form

  Private lifeTimeInfo As String

  ' Handle the Load, Activated, Deactivate, and Closed events.
  Public Sub MainWindow_Load(ByVal sender As Object, _
    ByVal e as EventArgs) Handles Me.Load
    lifeTimeInfo = lifeTimeInfo & "Load event" & VbLf
  End Sub

  Public Sub MainWindow_Activated(ByVal sender As Object, _
    ByVal e as EventArgs) Handles Me.Activated
    lifeTimeInfo = lifeTimeInfo & "Activated event" & VbLf
  End Sub

  Public Sub MainWindow_Deactivate(ByVal sender As Object, _
    ByVal e as EventArgs) Handles Me.Deactivate
    lifeTimeInfo = lifeTimeInfo & "Deactivate event" & VbLf
  End Sub

  Public Sub MainWindow_Closed(ByVal sender As Object, _
    ByVal e as EventArgs) Handles Me.Closed
    lifeTimeInfo = lifeTimeInfo & "Closed event" & VbLf
    MessageBox.Show(lifeTimeInfo)
  End Sub

  Private Sub MainWindow_Closing(ByVal sender As Object, _
	ByVal e As CancelEventArgs) Handles Me.Closing
	  Dim dr As System.Windows.Forms.DialogResult = _
	  MessageBox.Show("Do you REALLY want to close this app?", _
	    "Closing event!", MessageBoxButtons.YesNo)
	If dr = System.Windows.Forms.DialogResult.No Then
	  e.Cancel = True
	Else
	  e.Cancel = False
	End If
  End Sub

End Class

Public Module Program
  ' Run this application and identify the main window.
  Sub Main()
    Application.Run(New MainWindow())
  End Sub
End Module

