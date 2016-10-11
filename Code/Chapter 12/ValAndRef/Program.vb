Option Strict On
Option Explicit On

Module Program

  Sub Main()
    ValueTypesRefTypesAndAssignment()
  End Sub

  Sub ValueTypesRefTypesAndAssignment()
    Console.WriteLine("***** Value Types and the Assignment Operator *****")
    Console.WriteLine("-> Creating p1")
    Dim p1 As New MyPoint(100, 100)

    Console.WriteLine("-> Assigning p2 to p1")
    Dim p2 As MyPoint = p1

    ' Here is p1.
    Console.WriteLine("p1.x = {0}", p1.x)
    Console.WriteLine("p1.y = {0}", p1.y)

    ' Here is p2.
    Console.WriteLine("p2.x = {0}", p2.x)
    Console.WriteLine("p2.y = {0}", p2.y)

    ' Change p2.x. This will NOT change p1.x.
    Console.WriteLine("-> Changing p2.x to 900")
    p2.x = 900

    ' Print again.
    Console.WriteLine("-> Here are the X values again...")
    Console.WriteLine("p1.x = {0}", p1.x)
    Console.WriteLine("p2.x = {0}", p2.x)
    Console.ReadLine()
  End Sub

End Module
