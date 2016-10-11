Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Prim and Proper Events *****")
    Dim c As New Car("NightRider", 50)

    ' Dynamically hook into event using AddressOf.
    AddHandler c.Exploded, AddressOf ExplodedHandler
    AddHandler c.AboutToBlow, AddressOf AboutToBlowHandler

    For i As Integer = 0 To 5
      c.Accelerate(10)
    Next
    Console.ReadLine()
  End Sub

  ' Event Handler for both events 
  '(note lack of Handles keyword).
  Public Sub AboutToBlowHandler(ByVal sender As Object, ByVal e As CarEventArgs)
    Console.WriteLine("{0} says: {1}", sender, e.msgData)
  End Sub

  Public Sub ExplodedHandler(ByVal sender As Object, ByVal e As CarEventArgs)
    If TypeOf sender Is Car Then
      Dim c As Car = CType(sender, Car)
      c.CrankTunes(False)
    End If
    Console.WriteLine("Critical message from {0}: {1}", sender, e.msgData)
  End Sub
End Module