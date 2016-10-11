
Partial Class _Default
  Inherits System.Web.UI.Page

  Protected Sub btnSomeTraining_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSomeTraining.Click
    Response.Redirect("http://www.IntertechTraining.com")
  End Sub

  Protected Sub btnHttpResponse_Click(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles btnHttpResponse.Click
    Response.Write("<b>My name is:</b><br>")
    Response.Write(Me.ToString())
    Response.Write("<br><br><b>Here was your last request:</b><br>")
    ' This assumes that you have a file of this name 
    ' in your virtual directory!
    ' Response.WriteFile("MyHTMLPage.htm")
  End Sub

  Protected Sub btnGetFormData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetFormData.Click
    ' Get value for a widget with ID txtFirstName.
    Dim firstName As String = Request.Form("txtFirstName")
    lblFormData.Text = firstName
  End Sub

  Protected Sub btnGetBrowserStats_Click(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles btnGetBrowserStats.Click
    Dim theInfo As String = ""
    theInfo &= String.Format("<li>Is the client AOL? {0}</li>", _
      Request.Browser.AOL)
    theInfo &= _
      String.Format("<li>Does the client support ActiveX? {0}</li>", _
      Request.Browser.ActiveXControls)
    theInfo &= String.Format("<li>Is the client a Beta? {0}</li>", _
      Request.Browser.Beta)
    theInfo &= _
      String.Format("<li>Dose the client support Java Applets? {0}</li>", _
      Request.Browser.JavaApplets)
    theInfo &= _
      String.Format("<li>Does the client support Cookies? {0}</li>", _
      Request.Browser.Cookies)
    theInfo &= _
      String.Format("<li>Does the client support VBScript? {0}</li>", _
      Request.Browser.VBScript)
    lblOutput.Text = theInfo
  End Sub

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    ' Only fill DataSet the very first time
    ' the user comes to this page.
    If Not IsPostBack Then
      ' Populate DataSet and cache it!
    End If
    ' Use cached DataSet.
  End Sub
End Class
