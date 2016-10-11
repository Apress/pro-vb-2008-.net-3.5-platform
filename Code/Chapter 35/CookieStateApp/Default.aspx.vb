Option Explicit On
Option Strict On

Partial Class _Default
  Inherits System.Web.UI.Page

  Protected Sub btnNewCookie_Click(ByVal sender As Object, _
   ByVal e As System.EventArgs) Handles btnNewCookie.Click
    ' Make a new (persistent) cookie.
    Dim theCookie As HttpCookie = _
         New HttpCookie(txtCookieName.Text, _
         txtCookieValue.Text)
    theCookie.Expires = DateTime.Parse("03/26/2009")
    Response.Cookies.Add(theCookie)
  End Sub

  Protected Sub btnShowCookie_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowCookie.Click
    Dim cookieData As String = ""
    For Each s As String In Request.Cookies
      cookieData &= String.Format _
            ("<li><b>Name</b>: {0}, <b>Value</b>: {1}</li>", _
            s, Request.Cookies(s).Value)
    Next
    lblCookieData.Text = cookieData
  End Sub
End Class
