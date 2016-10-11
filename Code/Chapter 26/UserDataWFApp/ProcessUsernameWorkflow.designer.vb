<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessUsernameWorkflow

  'NOTE: The following procedure is required by the Workflow Designer
  'It can be modified using the Workflow Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Private Sub InitializeComponent()
    Me.CanModifyActivities = True
    Dim codecondition1 As System.Workflow.Activities.CodeCondition = New System.Workflow.Activities.CodeCondition
    Me.NameNotValidActivity = New System.Workflow.Activities.CodeActivity
    Me.AskForNameLoopActivity = New System.Workflow.Activities.WhileActivity
    Me.ShowInstructionsActivity = New System.Workflow.Activities.CodeActivity
    '
    'NameNotValidActivity
    '
    Me.NameNotValidActivity.Name = "NameNotValidActivity"
    AddHandler Me.NameNotValidActivity.ExecuteCode, AddressOf Me.NameNotValid
    '
    'AskForNameLoopActivity
    '
    Me.AskForNameLoopActivity.Activities.Add(Me.NameNotValidActivity)
    AddHandler codecondition1.Condition, AddressOf Me.GetAndValidateUserName
    Me.AskForNameLoopActivity.Condition = codecondition1
    Me.AskForNameLoopActivity.Name = "AskForNameLoopActivity"
    '
    'ShowInstructionsActivity
    '
    Me.ShowInstructionsActivity.Name = "ShowInstructionsActivity"
    AddHandler Me.ShowInstructionsActivity.ExecuteCode, AddressOf Me.ShowInstructions
    '
    'ProcessUsernameWorkflow
    '
    Me.Activities.Add(Me.ShowInstructionsActivity)
    Me.Activities.Add(Me.AskForNameLoopActivity)
    Me.Name = "ProcessUsernameWorkflow"
    Me.CanModifyActivities = False

  End Sub
  Private AskForNameLoopActivity As System.Workflow.Activities.WhileActivity
  Private NameNotValidActivity As System.Workflow.Activities.CodeActivity
  Private ShowInstructionsActivity As System.Workflow.Activities.CodeActivity

End Class
