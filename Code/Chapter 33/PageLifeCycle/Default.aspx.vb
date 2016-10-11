Partial Class _Default
  Inherits System.Web.UI.Page

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles Me.Load
    ' Perform load logic here...
    Response.Write("Load event fired!")
  End Sub

  Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles Me.Unload
    ' No longer possible to emit data to the HTTP
    ' response at this point, so we will write to a local file.
    System.IO.File.WriteAllText("C:\MyLog.txt", "Page unloading!")
  End Sub

  Protected Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
    Response.Clear()
    Response.Write("I am sorry...I can't find a required file.<br>")
    Response.Write(String.Format("The error was: <b>{0}</b>", _
        Server.GetLastError().Message))
    Server.ClearError()
  End Sub

  Protected Sub btnPostback_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPostback.Click
    ' This is just here to allow a postback.
  End Sub

  Protected Sub btnTriggerError_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTriggerError.Click
    ' Try to open a nonexistent file on the web server.
    ' This will fire the Error event for this page.
    System.IO.File.ReadAllText("C:\IDontExist.txt")
  End Sub
End Class
