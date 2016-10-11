Option Explicit On
Option Strict On

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, _
     ByVal e As System.EventArgs) Handles btnSubmit.Click
        ' Set current user prefs.
        Try
            Dim u As UserShoppingCart = CType(Session("UserShoppingCartInfo"), UserShoppingCart)
            u.dateOfPickUp = myCalendar.SelectedDate
            u.desiredCar = txtCarMake.Text
            u.desiredCarColor = txtCarColor.Text
            u.downPayment = Single.Parse(txtDownPayment.Text)
            u.isLeasing = chkIsLeasing.Checked
            lblUserInfo.Text = u.ToString()
            Session("UserShoppingCartInfo") = u
        Catch ex As Exception
            lblUserInfo.Text = ex.Message
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblUserID.Text = String.Format("Here is your ID: {0}", _
                Session.SessionID)
        End If
    End Sub
End Class
