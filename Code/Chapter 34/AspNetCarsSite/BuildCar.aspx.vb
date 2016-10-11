
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub carWizard_FinishButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles carWizard.FinishButtonClick
        ' Get each value.
        Dim order As String = String.Format("{0}, your {1} {2} will arrive on {3}.", _
          txtCarPetName.Text, ListBoxColors.SelectedValue, txtCarModel.Text, carCalendar.SelectedDate.ToShortDateString())
        ' Assign to label
        lblOrder.Text = order
    End Sub
End Class
