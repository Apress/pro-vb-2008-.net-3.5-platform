<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathWF

  'NOTE: The following procedure is required by the Workflow Designer
  'It can be modified using the Workflow Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Private Sub InitializeComponent()
    Me.CanModifyActivities = True
    Dim activitybind1 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding1 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind2 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding2 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind3 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding3 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind4 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding4 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind5 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding5 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind6 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding6 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind7 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding7 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind8 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding8 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind9 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding9 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind10 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding10 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind11 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding11 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind12 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding12 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim ruleconditionreference1 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Dim ruleconditionreference2 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Dim ruleconditionreference3 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Dim ruleconditionreference4 As System.Workflow.Activities.Rules.RuleConditionReference = New System.Workflow.Activities.Rules.RuleConditionReference
    Dim channeltoken1 As System.Workflow.Activities.ChannelToken = New System.Workflow.Activities.ChannelToken
    Dim activitybind13 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding13 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind14 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding14 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim activitybind15 As System.Workflow.ComponentModel.ActivityBind = New System.Workflow.ComponentModel.ActivityBind
    Dim workflowparameterbinding15 As System.Workflow.ComponentModel.WorkflowParameterBinding = New System.Workflow.ComponentModel.WorkflowParameterBinding
    Dim typedoperationinfo1 As System.Workflow.Activities.TypedOperationInfo = New System.Workflow.Activities.TypedOperationInfo
    Me.invokeWebServiceActivity4 = New System.Workflow.Activities.InvokeWebServiceActivity
    Me.invokeWebServiceActivity3 = New System.Workflow.Activities.InvokeWebServiceActivity
    Me.invokeWebServiceActivity2 = New System.Workflow.Activities.InvokeWebServiceActivity
    Me.invokeWebServiceActivity1 = New System.Workflow.Activities.InvokeWebServiceActivity
    Me.IfDivideOp = New System.Workflow.Activities.IfElseBranchActivity
    Me.IfMultiplyOp = New System.Workflow.Activities.IfElseBranchActivity
    Me.IfSubOp = New System.Workflow.Activities.IfElseBranchActivity
    Me.IfAddOp = New System.Workflow.Activities.IfElseBranchActivity
    Me.codeActivity1 = New System.Workflow.Activities.CodeActivity
    Me.WCFSendAddActivity = New System.Workflow.Activities.SendActivity
    Me.DisplayResult = New System.Workflow.Activities.CodeActivity
    Me.ifElseActivity1 = New System.Workflow.Activities.IfElseActivity
    Me.GetMathOpInput = New System.Workflow.Activities.CodeActivity
    Me.GetNumericalInput = New System.Workflow.Activities.CodeActivity
    '
    'invokeWebServiceActivity4
    '
    Me.invokeWebServiceActivity4.MethodName = "Divide"
    Me.invokeWebServiceActivity4.Name = "invokeWebServiceActivity4"
    activitybind1.Name = "MathWF"
    activitybind1.Path = "Result"
    workflowparameterbinding1.ParameterName = "(ReturnValue)"
    workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind1, System.Workflow.ComponentModel.ActivityBind))
    activitybind2.Name = "MathWF"
    activitybind2.Path = "FirstNumber"
    workflowparameterbinding2.ParameterName = "x"
    workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind2, System.Workflow.ComponentModel.ActivityBind))
    activitybind3.Name = "MathWF"
    activitybind3.Path = "SecondNumber"
    workflowparameterbinding3.ParameterName = "y"
    workflowparameterbinding3.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind3, System.Workflow.ComponentModel.ActivityBind))
    Me.invokeWebServiceActivity4.ParameterBindings.Add(workflowparameterbinding1)
    Me.invokeWebServiceActivity4.ParameterBindings.Add(workflowparameterbinding2)
    Me.invokeWebServiceActivity4.ParameterBindings.Add(workflowparameterbinding3)
    Me.invokeWebServiceActivity4.ProxyClass = GetType(WFMathClient.localhost.MathService)
    '
    'invokeWebServiceActivity3
    '
    Me.invokeWebServiceActivity3.MethodName = "Multiply"
    Me.invokeWebServiceActivity3.Name = "invokeWebServiceActivity3"
    activitybind4.Name = "MathWF"
    activitybind4.Path = "FirstNumber"
    workflowparameterbinding4.ParameterName = "x"
    workflowparameterbinding4.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind4, System.Workflow.ComponentModel.ActivityBind))
    activitybind5.Name = "MathWF"
    activitybind5.Path = "SecondNumber"
    workflowparameterbinding5.ParameterName = "y"
    workflowparameterbinding5.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind5, System.Workflow.ComponentModel.ActivityBind))
    activitybind6.Name = "MathWF"
    activitybind6.Path = "Result"
    workflowparameterbinding6.ParameterName = "(ReturnValue)"
    workflowparameterbinding6.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind6, System.Workflow.ComponentModel.ActivityBind))
    Me.invokeWebServiceActivity3.ParameterBindings.Add(workflowparameterbinding4)
    Me.invokeWebServiceActivity3.ParameterBindings.Add(workflowparameterbinding5)
    Me.invokeWebServiceActivity3.ParameterBindings.Add(workflowparameterbinding6)
    Me.invokeWebServiceActivity3.ProxyClass = GetType(WFMathClient.localhost.MathService)
    '
    'invokeWebServiceActivity2
    '
    Me.invokeWebServiceActivity2.MethodName = "Subtract"
    Me.invokeWebServiceActivity2.Name = "invokeWebServiceActivity2"
    activitybind7.Name = "MathWF"
    activitybind7.Path = "FirstNumber"
    workflowparameterbinding7.ParameterName = "x"
    workflowparameterbinding7.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind7, System.Workflow.ComponentModel.ActivityBind))
    activitybind8.Name = "MathWF"
    activitybind8.Path = "SecondNumber"
    workflowparameterbinding8.ParameterName = "y"
    workflowparameterbinding8.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind8, System.Workflow.ComponentModel.ActivityBind))
    activitybind9.Name = "MathWF"
    activitybind9.Path = "Result"
    workflowparameterbinding9.ParameterName = "(ReturnValue)"
    workflowparameterbinding9.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind9, System.Workflow.ComponentModel.ActivityBind))
    Me.invokeWebServiceActivity2.ParameterBindings.Add(workflowparameterbinding7)
    Me.invokeWebServiceActivity2.ParameterBindings.Add(workflowparameterbinding8)
    Me.invokeWebServiceActivity2.ParameterBindings.Add(workflowparameterbinding9)
    Me.invokeWebServiceActivity2.ProxyClass = GetType(WFMathClient.localhost.MathService)
    '
    'invokeWebServiceActivity1
    '
    Me.invokeWebServiceActivity1.MethodName = "Add"
    Me.invokeWebServiceActivity1.Name = "invokeWebServiceActivity1"
    activitybind10.Name = "MathWF"
    activitybind10.Path = "FirstNumber"
    workflowparameterbinding10.ParameterName = "x"
    workflowparameterbinding10.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind10, System.Workflow.ComponentModel.ActivityBind))
    activitybind11.Name = "MathWF"
    activitybind11.Path = "SecondNumber"
    workflowparameterbinding11.ParameterName = "y"
    workflowparameterbinding11.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind11, System.Workflow.ComponentModel.ActivityBind))
    activitybind12.Name = "MathWF"
    activitybind12.Path = "Result"
    workflowparameterbinding12.ParameterName = "(ReturnValue)"
    workflowparameterbinding12.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind12, System.Workflow.ComponentModel.ActivityBind))
    Me.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding10)
    Me.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding11)
    Me.invokeWebServiceActivity1.ParameterBindings.Add(workflowparameterbinding12)
    Me.invokeWebServiceActivity1.ProxyClass = GetType(WFMathClient.localhost.MathService)
    '
    'IfDivideOp
    '
    Me.IfDivideOp.Activities.Add(Me.invokeWebServiceActivity4)
    ruleconditionreference1.ConditionName = "Condition4"
    Me.IfDivideOp.Condition = ruleconditionreference1
    Me.IfDivideOp.Name = "IfDivideOp"
    '
    'IfMultiplyOp
    '
    Me.IfMultiplyOp.Activities.Add(Me.invokeWebServiceActivity3)
    ruleconditionreference2.ConditionName = "Condition3"
    Me.IfMultiplyOp.Condition = ruleconditionreference2
    Me.IfMultiplyOp.Name = "IfMultiplyOp"
    '
    'IfSubOp
    '
    Me.IfSubOp.Activities.Add(Me.invokeWebServiceActivity2)
    ruleconditionreference3.ConditionName = "Condition2"
    Me.IfSubOp.Condition = ruleconditionreference3
    Me.IfSubOp.Name = "IfSubOp"
    '
    'IfAddOp
    '
    Me.IfAddOp.Activities.Add(Me.invokeWebServiceActivity1)
    ruleconditionreference4.ConditionName = "Condition1"
    Me.IfAddOp.Condition = ruleconditionreference4
    Me.IfAddOp.Name = "IfAddOp"
    '
    'codeActivity1
    '
    Me.codeActivity1.Name = "codeActivity1"
    AddHandler Me.codeActivity1.ExecuteCode, AddressOf Me.WCFResult
    '
    'WCFSendAddActivity
    '
    channeltoken1.EndpointName = "WSHttpBinding_IBasicMath"
    channeltoken1.Name = "WSHttpBinding_IBasicMath"
    channeltoken1.OwnerActivityName = "WCFSendAddActivity"
    Me.WCFSendAddActivity.ChannelToken = channeltoken1
    Me.WCFSendAddActivity.Name = "WCFSendAddActivity"
    activitybind13.Name = "MathWF"
    activitybind13.Path = "Result"
    workflowparameterbinding13.ParameterName = "(ReturnValue)"
    workflowparameterbinding13.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind13, System.Workflow.ComponentModel.ActivityBind))
    activitybind14.Name = "MathWF"
    activitybind14.Path = "FirstNumber"
    workflowparameterbinding14.ParameterName = "x"
    workflowparameterbinding14.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind14, System.Workflow.ComponentModel.ActivityBind))
    activitybind15.Name = "MathWF"
    activitybind15.Path = "SecondNumber"
    workflowparameterbinding15.ParameterName = "y"
    workflowparameterbinding15.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, CType(activitybind15, System.Workflow.ComponentModel.ActivityBind))
    Me.WCFSendAddActivity.ParameterBindings.Add(workflowparameterbinding13)
    Me.WCFSendAddActivity.ParameterBindings.Add(workflowparameterbinding14)
    Me.WCFSendAddActivity.ParameterBindings.Add(workflowparameterbinding15)
    typedoperationinfo1.ContractType = GetType(WFMathClient.ServiceReference1.IBasicMath)
    typedoperationinfo1.Name = "Add"
    Me.WCFSendAddActivity.ServiceOperationInfo = typedoperationinfo1
    '
    'DisplayResult
    '
    Me.DisplayResult.Name = "DisplayResult"
    AddHandler Me.DisplayResult.ExecuteCode, AddressOf Me.ShowResult
    '
    'ifElseActivity1
    '
    Me.ifElseActivity1.Activities.Add(Me.IfAddOp)
    Me.ifElseActivity1.Activities.Add(Me.IfSubOp)
    Me.ifElseActivity1.Activities.Add(Me.IfMultiplyOp)
    Me.ifElseActivity1.Activities.Add(Me.IfDivideOp)
    Me.ifElseActivity1.Name = "ifElseActivity1"
    '
    'GetMathOpInput
    '
    Me.GetMathOpInput.Name = "GetMathOpInput"
    AddHandler Me.GetMathOpInput.ExecuteCode, AddressOf Me.GetOpInput
    '
    'GetNumericalInput
    '
    Me.GetNumericalInput.Name = "GetNumericalInput"
    AddHandler Me.GetNumericalInput.ExecuteCode, AddressOf Me.GetNumbInput
    '
    'MathWF
    '
    Me.Activities.Add(Me.GetNumericalInput)
    Me.Activities.Add(Me.GetMathOpInput)
    Me.Activities.Add(Me.ifElseActivity1)
    Me.Activities.Add(Me.DisplayResult)
    Me.Activities.Add(Me.WCFSendAddActivity)
    Me.Activities.Add(Me.codeActivity1)
    Me.Name = "MathWF"
    Me.CanModifyActivities = False

  End Sub
  Private WCFSendAddActivity As System.Workflow.Activities.SendActivity
  Private codeActivity1 As System.Workflow.Activities.CodeActivity
  Private IfDivideOp As System.Workflow.Activities.IfElseBranchActivity
  Private IfMultiplyOp As System.Workflow.Activities.IfElseBranchActivity
  Private IfSubOp As System.Workflow.Activities.IfElseBranchActivity
  Private IfAddOp As System.Workflow.Activities.IfElseBranchActivity
  Private ifElseActivity1 As System.Workflow.Activities.IfElseActivity
  Private invokeWebServiceActivity1 As System.Workflow.Activities.InvokeWebServiceActivity
  Private invokeWebServiceActivity2 As System.Workflow.Activities.InvokeWebServiceActivity
  Private invokeWebServiceActivity3 As System.Workflow.Activities.InvokeWebServiceActivity
  Private invokeWebServiceActivity4 As System.Workflow.Activities.InvokeWebServiceActivity
  Private DisplayResult As System.Workflow.Activities.CodeActivity
  Private GetMathOpInput As System.Workflow.Activities.CodeActivity
  Private GetNumericalInput As System.Workflow.Activities.CodeActivity

End Class
