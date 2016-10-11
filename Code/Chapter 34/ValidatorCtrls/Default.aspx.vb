
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnPostback_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPostback.Click
        lblValidationComplete.Text = "You passed validation!"
    End Sub
End Class
