Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Delegates as event enablers *****")
    Dim c1 As New Car("SlugBug", 10)

    ' Register multiple event handlers!
    c1.OnAboutToBlow(AddressOf CarAboutToBlow)
    c1.OnAboutToBlow(AddressOf CarIsAlmostDoomed)
    c1.OnExploded(AddressOf CarExploded)

    Console.WriteLine("***** Speeding up *****")
    For i As Integer = 0 To 5
      c1.Accelerate(20)
    Next

    ' Remove CarExploded from list.
    c1.RemoveExploded(AddressOf CarExploded)

    ' This will not fire the Exploded event. 
    For i As Integer = 0 To 5
      c1.Accelerate(20)
    Next
    Console.ReadLine()
  End Sub

  Public Sub CarAboutToBlow(ByVal msg As String)
    Console.WriteLine(msg)
  End Sub

  Public Sub CarIsAlmostDoomed(ByVal msg As String)
    Console.WriteLine("Critical Message from Car: {0} ", msg)
  End Sub

  Public Sub CarExploded(ByVal msg As String)
    Console.WriteLine(msg)
  End Sub
End Module
