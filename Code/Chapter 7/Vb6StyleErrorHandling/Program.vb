Module Program
  Sub Main()
    Console.WriteLine("***** VB 6.0 Style Error Handling *****")
    On Error GoTo OOPS

    Dim myCar As New Car("Sven", 80)
    For i As Integer = 0 To 10
      myCar.Accelerate(10)
    Next
OOPS:
    ' Use Err object.
    Console.WriteLine("=> Handling error with Err object.")
    Console.WriteLine(Err.Description)
    Console.WriteLine(Err.Source)

    ' Use Err object to get exception object.
    Console.WriteLine("=> Handling error with exception.")
    Console.WriteLine(Err.GetException().StackTrace)
    Console.WriteLine(Err.GetException().TargetSite)
    Console.ReadLine()
  End Sub
End Module
