Option Explicit On
Option Strict On

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnShowAppVariables_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles btnShowAppVariables.Click
        ' Get object from application variable. 
        Dim appVars As CarLotInfo = _
        CType(Application("CarSiteInfo"), CarLotInfo)

        Dim appState As String = _
        String.Format("<li>Car on sale: {0}</li>", _
        appVars.currentCarOnSale)

        appState &= _
          String.Format("<li>Most popular color: {0}</li>", _
          appVars.mostPopularColorOnLot)
        appState &= _
          String.Format("<li>Big shot SalesPerson: {0}</li>", _
          appVars.salesPersonOfTheMonth)
        lblAppVariables.Text = appState
    End Sub

    Protected Sub btnSetNewSP_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles btnSetNewSP.Click
        ' Set the new Salesperson.
        CType(Application("CarSiteInfo"), CarLotInfo).salesPersonOfTheMonth _
          = txtNewSP.Text
    End Sub

    Protected Sub btnShowCarOnSale_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles btnShowCarOnSale.Click
        'lblCurrCarOnSale.Text = String.Format("Sale on {0}'s today!", _
        'CType(Application("CurrentCarOnSale"), String))

        lblCurrCarOnSale.Text = String.Format("Sale on {0}'s today!", _
        CType(Application("CarSiteInfo"), CarLotInfo).currentCarOnSale)
    End Sub

    ' Just as an example...
    Private Sub CleanAppData()
        ' Remove a single item via string name.
        Application.Remove("SomeItemIDontNeed")

        ' Destroy all application data!
        Application.RemoveAll()
    End Sub
End Class
