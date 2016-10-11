Option Explicit On
Option Strict On

' EnableViewState has been set to false in the Page directive!
' Set to true to change the behnvior of this page. 

Partial Class _Default
  Inherits System.Web.UI.Page

  Protected Sub btnAddToVS_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles btnAddToVS.Click
    ViewState("CustomViewStateItem") = "Some user data"
    lblVSValue.Text = CType(ViewState("CustomViewStateItem"), String)
  End Sub

  Protected Sub Page_Load(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles Me.Load
    If Not IsPostBack Then
      ' Fill ListBox dynamically!
      myListBox.Items.Add("Item One")
      myListBox.Items.Add("Item Two")
      myListBox.Items.Add("Item Three")
      myListBox.Items.Add("Item Four")
    End If
  End Sub
End Class
