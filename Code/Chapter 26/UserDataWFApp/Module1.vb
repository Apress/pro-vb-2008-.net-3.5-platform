Module Module1
  Class Program

    Shared WaitHandle As New AutoResetEvent(False)

    Shared Sub Main()
      ' Ensure the runtime shuts down when we are finished.
      Using workflowRuntime As New WorkflowRuntime()

        ' Handle events that capture when the engine completes
        ' the workflow process and if the engine shuts down with an error.
        AddHandler workflowRuntime.WorkflowCompleted, AddressOf OnWorkflowCompleted
        AddHandler workflowRuntime.WorkflowTerminated, AddressOf OnWorkflowTerminated

        ' Define two parameters for use by our workflow.
        ' Remember!  These must be mapped to identically named
        ' properties in our workflow class type.
        Dim parameters As New Dictionary(Of String, Object)()
        parameters.Add("ErrorMessage", "Ack!  Your name is too long!")
        parameters.Add("NameLength", 5)

        ' Now, create a WF instance that represents our type.
        Dim workflowInstance As WorkflowInstance
        workflowInstance = workflowRuntime.CreateWorkflow(GetType(ProcessUsernameWorkflow), parameters)
        workflowInstance.Start()
        WaitHandle.WaitOne()
      End Using
    End Sub

    Shared Sub OnWorkflowCompleted(ByVal sender As Object, ByVal e As WorkflowCompletedEventArgs)
      WaitHandle.Set()
    End Sub

    Shared Sub OnWorkflowTerminated(ByVal sender As Object, ByVal e As WorkflowTerminatedEventArgs)
      Console.WriteLine(e.Exception.Message)
      WaitHandle.Set()
    End Sub

  End Class
End Module

