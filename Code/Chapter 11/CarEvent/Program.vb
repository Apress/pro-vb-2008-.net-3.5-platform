Option Explicit On
Option Strict On

Module Program
  ' Declare variables 'WithEvents' to 
  ' receive the outbound events. 
  Private WithEvents c As New Car("NightRider", 50)

  Sub Main()
    Console.WriteLine("***** Fun with Events *****")
    Console.WriteLine()

    Dim i As Integer
    For i = 0 To 5
      c.Accelerate(10)
    Next
    Console.ReadLine()
  End Sub

  ' Event Handlers.
  Public Sub MyExplodedHandler(ByVal s As String) _
  Handles c.Exploded, c.AboutToBlow
    Console.WriteLine(s)
  End Sub
End Module