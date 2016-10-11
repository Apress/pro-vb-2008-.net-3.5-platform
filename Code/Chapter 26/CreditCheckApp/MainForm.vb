' Need the WF runtime!
Imports System.Workflow.Runtime

' Be sure to reference our custom WF library.
Imports CreditCheckWFLib

Public Class MainForm

  Private Sub btnCheckCustomerCredit_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnCheckCustomerCredit.Click
    ' Create the WF runtime.
    Dim wfRuntime As New WorkflowRuntime()

    ' Get ID in the TextBox to pass to the workflow.
    Dim args As New Dictionary(Of String, Object)()
    args.Add("ID", Integer.Parse(txtCustomerID.Text))

    ' Get an instance of our WF.
    Dim myWorkflow As WorkflowInstance = wfRuntime.CreateWorkflow(GetType(CreditCheckWF), args)

    ' Start it up!
    myWorkflow.Start()
  End Sub
End Class
