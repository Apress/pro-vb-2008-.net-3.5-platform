Option Explicit On
Option Strict On

Public Class ChildPrototypeForm
  Private Sub ChildPrototypeForm_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles MyBase.Click
    ' Get three random numbers
    Dim r, g, b As Integer
    Dim ran As New Random()
    r = ran.Next(0, 255)
    g = ran.Next(0, 255)
    b = ran.Next(0, 255)

    ' Now create a color for the background.
    Dim currColor As Color = Color.FromArgb(r, g, b)
    Me.BackColor = currColor
    Me.Text = currColor.ToString()
  End Sub
End Class