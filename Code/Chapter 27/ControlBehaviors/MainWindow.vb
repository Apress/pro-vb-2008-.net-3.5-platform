Imports System.Windows.Forms
Imports System.Drawing

Namespace MyWindowsApp
  Public Class MainWindow
    Inherits Form

    Public Sub New()
      ' Use inherited properties to set basic UI.
      Text = "My Fantastic Form"
      Height = 300
      Width = 500
      BackColor = Color.LemonChiffon
      Cursor = Cursors.Hand
    End Sub
	
	Public Sub MainWindow_MouseMove(ByVal sender As Object, _
      ByVal e As MouseEventArgs) Handles Me.MouseMove
      Text = String.Format("Current Pos: ({0} , {1})", e.X, e.Y)
    End Sub

	Public Sub MainWindow_MouseUp(ByVal sender As Object, _
      ByVal e As MouseEventArgs) Handles Me.MouseUp
      If e.Button = System.Windows.Forms.MouseButtons.Left Then
        MessageBox.Show("Left click!")
      End If
      If e.Button = System.Windows.Forms.MouseButtons.Right Then
        MessageBox.Show("Right click!")
      End If
      If e.Button = System.Windows.Forms.MouseButtons.Middle Then
        MessageBox.Show("Middle click!")
      End If
    End Sub

	Public Sub MainWindow_KeyUp(ByVal sender As Object, _
	  ByVal e As KeyEventArgs) Handles Me.KeyUp
      MessageBox.Show(e.KeyCode.ToString(), "Key Pressed!")
	End Sub

  End Class

  Public Module Program
    ' Run this application and identify the main window.
    Sub Main()
      Application.Run(New MainWindow())
    End Sub
  End Module
End Namespace
