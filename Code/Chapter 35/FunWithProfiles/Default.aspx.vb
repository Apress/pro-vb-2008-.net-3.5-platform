Partial Class _Default
  Inherits System.Web.UI.Page

  Protected Sub Page_Load(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles Me.Load
    GetUserAddress()
  End Sub

  Protected Sub btnSubmit_Click(ByVal sender As Object, _
  ByVal e As System.EventArgs) Handles btnSubmit.Click
    ' Database writes happening here!
    Profile.AddressInfo.City = txtCity.Text
    Profile.AddressInfo.street = txtStreetAddress.Text
    Profile.AddressInfo.State = txtState.Text

    ' Get settings from database.
    GetUserAddress()
  End Sub

  Private Sub GetUserAddress()
    ' Database reads happening here!
    lblUserData.Text = String.Format("You live here: {0}, {1}, {2}", _
      Profile.AddressInfo.street, Profile.AddressInfo.city, _
      Profile.AddressInfo.state)
  End Sub

End Class
