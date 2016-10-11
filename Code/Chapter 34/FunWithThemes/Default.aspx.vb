Option Explicit On
Option Strict On

Partial Class _Default
  Inherits System.Web.UI.Page

  Protected Sub btnNoTheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoTheme.Click
    ' Empty strings result in no theme being applied. 
    Session("UserTheme") = ""
    ' Trigger the PreInit event again.
    Server.Transfer(Request.FilePath)
  End Sub

  Protected Sub btnGreenTheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGreenTheme.Click
    Session("UserTheme") = "BasicGreen"
    ' Trigger the PreInit event again.
    Server.Transfer(Request.FilePath)
  End Sub

  Protected Sub btnOrangeTheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOrangeTheme.Click
    Session("UserTheme") = "CrazyOrange"
    ' Trigger the PreInit event again.
    Server.Transfer(Request.FilePath)
  End Sub

  Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
    Try
      Theme = Session("UserTheme").ToString()
    Catch
      Theme = ""
    End Try
  End Sub
End Class
