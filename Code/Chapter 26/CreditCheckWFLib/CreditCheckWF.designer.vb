<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditCheckWF

  'NOTE: The following procedure is required by the Workflow Designer
  'It can be modified using the Workflow Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Private Sub InitializeComponent()
    Me.CanModifyActivities = True
    Dim ruleconditionreference1 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Me.ShowDenyMessageActivity = New System.Workflow.Activities.CodeActivity
    Me.ProcessCreditRiskActivity = New System.Workflow.Activities.CodeActivity
    Me.PurchaseCarActivity = New System.Workflow.Activities.CodeActivity
    Me.CreditCheckFailed = New System.Workflow.Activities.IfElseBranchActivity
    Me.CreditCheckOK = New System.Workflow.Activities.IfElseBranchActivity
    Me.CreditCheckPassedActivity = New System.Workflow.Activities.IfElseActivity
    Me.ValidateCreditActivity = New System.Workflow.Activities.CodeActivity
    '
    'ShowDenyMessageActivity
    '
    Me.ShowDenyMessageActivity.Name = "ShowDenyMessageActivity"
    AddHandler Me.ShowDenyMessageActivity.ExecuteCode, AddressOf Me.CreditDenied
    '
    'ProcessCreditRiskActivity
    '
    Me.ProcessCreditRiskActivity.Name = "ProcessCreditRiskActivity"
    AddHandler Me.ProcessCreditRiskActivity.ExecuteCode, AddressOf Me.ProcessCreditRisk
    '
    'PurchaseCarActivity
    '
    Me.PurchaseCarActivity.Name = "PurchaseCarActivity"
    AddHandler Me.PurchaseCarActivity.ExecuteCode, AddressOf Me.PurchaseCar
    '
    'CreditCheckFailed
    '
    Me.CreditCheckFailed.Activities.Add(Me.ProcessCreditRiskActivity)
    Me.CreditCheckFailed.Activities.Add(Me.ShowDenyMessageActivity)
    Me.CreditCheckFailed.Name = "CreditCheckFailed"
    '
    'CreditCheckOK
    '
    Me.CreditCheckOK.Activities.Add(Me.PurchaseCarActivity)
    ruleconditionreference1.ConditionName = "Condition1"
    Me.CreditCheckOK.Condition = ruleconditionreference1
    Me.CreditCheckOK.Name = "CreditCheckOK"
    '
    'CreditCheckPassedActivity
    '
    Me.CreditCheckPassedActivity.Activities.Add(Me.CreditCheckOK)
    Me.CreditCheckPassedActivity.Activities.Add(Me.CreditCheckFailed)
    Me.CreditCheckPassedActivity.Name = "CreditCheckPassedActivity"
    '
    'ValidateCreditActivity
    '
    Me.ValidateCreditActivity.Name = "ValidateCreditActivity"
    AddHandler Me.ValidateCreditActivity.ExecuteCode, AddressOf Me.ValidateCredit
    '
    'CreditCheckWF
    '
    Me.Activities.Add(Me.ValidateCreditActivity)
    Me.Activities.Add(Me.CreditCheckPassedActivity)
    Me.Name = "CreditCheckWF"
    Me.CanModifyActivities = False

  End Sub
  Private ShowDenyMessageActivity As System.Workflow.Activities.CodeActivity
  Private PurchaseCarActivity As System.Workflow.Activities.CodeActivity
  Private CreditCheckFailed As System.Workflow.Activities.IfElseBranchActivity
  Private CreditCheckOK As System.Workflow.Activities.IfElseBranchActivity
  Private CreditCheckPassedActivity As System.Workflow.Activities.IfElseActivity
  Private ProcessCreditRiskActivity As System.Workflow.Activities.CodeActivity
  Private ValidateCreditActivity As System.Workflow.Activities.CodeActivity

End Class
