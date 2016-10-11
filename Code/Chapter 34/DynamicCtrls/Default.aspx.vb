Option Explicit On
Option Strict On

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub ListControlsInPanel()
        Dim theInfo As String
        theInfo = String.Format("Has controls? {0} <br/>", myPanel.HasControls())
        For Each c As Control In myPanel.Controls
            If c.GetType() IsNot GetType(System.Web.UI.LiteralControl) Then
                theInfo += "***************************<br/>"
                theInfo += String.Format("Control Name? {0} <br/>", c.ToString())
                theInfo += String.Format("ID? {0} <br/>", c.ID)
                theInfo += String.Format("Control Visible? {0} <br/>", c.Visible)
                theInfo += String.Format("ViewState? {0} <br/>", c.EnableViewState)
            End If
        Next
        lblControlInfo.Text = theInfo
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles Me.Load
        ListControlsInPanel()
    End Sub

    Protected Sub btnRemovePanelItems_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles btnRemovePanelItems.Click
        myPanel.Controls.Clear()
        ListControlsInPanel()
    End Sub

    Protected Sub btnAddWidgets_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles btnAddWidgets.Click
        For i As Integer = 0 To 4
            ' Assign a name so we can get
            ' the text value out later
            ' using the HttpRequest.QueryString()
            ' method.
            Dim t As TextBox = New TextBox()
            t.ID = String.Format("newTextBox{0}", i)
            myPanel.Controls.Add(t)
            ListControlsInPanel()
        Next
    End Sub

    Protected Sub btnGetTextBoxValues_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles btnGetTextBoxValues.Click
        Dim textBoxValues As String = ""
        For i As Integer = 0 To Request.Form.Count - 1
            textBoxValues += String.Format("<li>{0} </li><br/>", Request.Form(i))
        Next
        lblTextBoxText.Text = textBoxValues
    End Sub
End Class

