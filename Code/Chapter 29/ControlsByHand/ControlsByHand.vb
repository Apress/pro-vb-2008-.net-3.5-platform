Option Explicit On
Option Strict On

Imports System.Windows.Forms
Imports System.Drawing

	Class MainWindow
	Inherits Form
		' Form widget member variables.
		Private  firstNameBox As New TextBox()
		Private WithEvents btnShowControls As New Button()

		Public Sub New()
			' Configure Form.
			Me.Text = "Simple Controls"
			Me.Width = 300
			Me.Height = 200
			CenterToScreen()

			' Add a new textbox to the Form.
			firstNameBox.Text = "Hello"
			firstNameBox.Size = New Size(150, 50)
			firstNameBox.Location = New Point(10, 10)
			Me.Controls.Add(firstNameBox)

			' Add a new button to the Form.
			btnShowControls.Text = "Click Me"
			btnShowControls.Size = New Size(90, 30)
			btnShowControls.Location = New Point(10, 70)
			btnShowControls.BackColor = Color.DodgerBlue
			Me.Controls.Add(btnShowControls)
		End Sub 

		' Handle Button's Click event.
		Private Sub btnShowControls_Clicked(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowControls.Click
			' Call ToString() on each control in the 
			' Form's Controls collection 
			Dim ctrlInfo As String = ""
			For Each c As Control In Me.Controls
				ctrlInfo += String.Format("Control: {0}" & Chr(10), c.ToString())
			Next
			MessageBox.Show(ctrlInfo, "Controls on Form")
			
			' Uncomment to test.
			' DisableAllButtons()
		End Sub
		
		' This method disables all buttons on the Form. 
		Private Sub DisableAllButtons()
		  For Each c As Control In Me.Controls
		    If TypeOf c Is Button Then
		      CType(c, Button).Enabled = False
		    End If
		    Next
		End Sub
	End Class

	Class Program
		Public Shared Sub Main(ByVal args As String())
			Application.Run(New MainWindow())
		End Sub
	End Class