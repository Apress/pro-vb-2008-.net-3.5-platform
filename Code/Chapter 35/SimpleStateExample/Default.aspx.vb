Option Explicit On
Option Strict On

' This is the 'stateless' version of the class
'
'Partial Class _Default
'    Inherits System.Web.UI.Page
'    ' State data?
'    Private userFavoriteCar As String

'    Protected Sub btnSetCar_Click(ByVal sender As Object, _
'      ByVal e As System.EventArgs) Handles btnSetCar.Click
'        ' Store favorite car in member variable.
'        userFavoriteCar = txtFavCar.Text
'    End Sub

'    Protected Sub btnGetCar_Click(ByVal sender As Object, _
'      ByVal e As System.EventArgs) Handles btnGetCar.Click
'        ' Set label text to value of member variable.
'        lblFavCar.Text = userFavoriteCar
'    End Sub
'End Class

' With state!
Partial Class _Default
    Inherits System.Web.UI.Page
    Protected Sub btnSetCar_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles btnSetCar.Click
        ' Store favorite car in session variable.
        Session("UserFavCar") = txtFavCar.Text
    End Sub

    Protected Sub btnGetCar_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles btnGetCar.Click
        ' Set label text to value of session variable.
        lblFavCar.Text = CType(Session("UserFavCar"), String)
    End Sub
End Class
