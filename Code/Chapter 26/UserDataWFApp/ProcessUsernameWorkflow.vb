Public Class ProcessUsernameWorkflow
  Inherits SequentialWorkflowActivity

#Region "Properties / backing fields"
  ' To hold the name of the user.
  Private usrName As String
  Public Property UserName() As String
    Get
      Return usrName
    End Get
    Set(ByVal value As String)
      usrName = value
    End Set
  End Property

  Private errMsg As String
  Public Property ErrorMessage() As String
    Get
      Return errMsg
    End Get
    Set(ByVal value As String)
      errMsg = value
    End Set
  End Property

  Private nameLen As Integer
  Public Property NameLength() As Integer
    Get
      Return nameLen
    End Get
    Set(ByVal value As Integer)
      nameLen = value
    End Set
  End Property
#End Region

  Private Sub GetAndValidateUserName(ByVal sender As System.Object, ByVal e As System.Workflow.Activities.ConditionalEventArgs)
    Console.Write("Please enter name, which must be less than {0} chars: ", NameLength)
    UserName = Console.ReadLine()

    ' See if name is correct length, and set the result.
    e.Result = (UserName.Length >= NameLength)
  End Sub

  Private Sub NameNotValid(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Console.WriteLine(ErrorMessage)
  End Sub

  Private Sub ShowInstructions(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim previousColor As ConsoleColor = Console.ForegroundColor
    Console.ForegroundColor = ConsoleColor.Yellow
    Console.WriteLine("*******************************************")
    Console.WriteLine("***** Welcome to the first WF Example *****")
    Console.WriteLine("*******************************************" & vbLf)
    Console.WriteLine("I will now ask for your name and validate the data..." & vbLf)
    Console.ForegroundColor = previousColor
  End Sub
End Class
