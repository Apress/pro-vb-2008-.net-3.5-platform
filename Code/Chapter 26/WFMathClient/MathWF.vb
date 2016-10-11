Public Enum MathOperation
  Add
  Subtract
  Multiply
  Divide
End Enum

Public Class MathWF
  Inherits SequentialWorkflowActivity

#Region "Properties / backing fields"
  Private numb1 As Integer
  Public Property FirstNumber() As Integer
    Get
      Return numb1
    End Get
    Set(ByVal value As Integer)
      numb1 = value
    End Set
  End Property

  Private numb2 As Integer
  Public Property SecondNumber() As Integer
    Get
      Return numb2
    End Get
    Set(ByVal value As Integer)
      numb2 = value
    End Set
  End Property

  Private res As Integer
  Public Property Result() As Integer
    Get
      Return res
    End Get
    Set(ByVal value As Integer)
      res = value
    End Set
  End Property

  Private mathOp As MathOperation
  Public Property Operation() As MathOperation
    Get
      Return mathOp
    End Get
    Set(ByVal value As MathOperation)
      mathOp = value
    End Set
  End Property
#End Region

  Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Operation = MathOperation.Add
  End Sub

  Private Sub GetNumbInput(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' For simplicity, we are not bothering to verify that
    ' the input values are indeed numerical.
    Console.Write("Enter first number: ")
    FirstNumber = Integer.Parse(Console.ReadLine())

    Console.Write("Enter second number: ")
    SecondNumber = Integer.Parse(Console.ReadLine())
  End Sub

  Private Sub GetOpInput(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Console.WriteLine("Do you wish to A[dd], S[ubtract],")
    Console.Write("Do you wish to M[ultiply] or D[ivide]: ")
    Dim op As String = Console.ReadLine()

    Select Case op.ToUpper()
      Case "A"
        Operation = MathOperation.Add
        Exit Select
      Case "S"
        Operation = MathOperation.Subtract
        Exit Select
      Case "M"
        Operation = MathOperation.Multiply
        Exit Select
      Case "D"
        Operation = MathOperation.Divide
        Exit Select
      Case Else
        Operation = MathOperation.Add
        Exit Select
    End Select
  End Sub

  Private Sub ShowResult(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Console.WriteLine("{0} {1} {2} = {3}", _
      FirstNumber, Operation.ToString().ToUpper(), SecondNumber, Result)
  End Sub

  Private Sub WCFResult(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Console.WriteLine("***** WCF Service Addition *****")
    Console.WriteLine("{0} + {1} = {2}", _
     FirstNumber, SecondNumber, Result)
  End Sub
End Class
