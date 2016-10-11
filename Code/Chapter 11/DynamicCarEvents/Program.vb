Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with AddHandler/RemoveHandler *****")
    ' Note lack of WithEvents keyword. 
    Dim c As New Car("NightRider", 50)

    ' Dynamically hook into event using AddHandler.
    AddHandler c.Exploded, AddressOf CarEventHandler
    AddHandler c.AboutToBlow, AddressOf CarEventHandler

    For i As Integer = 0 To 5
      c.Accelerate(10)
    Next
    Console.ReadLine()
  End Sub

  ' Event Handler for both events 
  '(note lack of Handles keyword).
  Public Sub CarEventHandler(ByVal s As String)
    Console.WriteLine(s)
  End Sub
End Module
