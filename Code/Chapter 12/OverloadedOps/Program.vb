Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Operator Overloading *****" & vbLf)
    'AddSubtractMyPointsWithMethodCalls()
    'AddSubtractMyPointsWithOperators()
    'TestMyPointsForEquality()
    TestMyPointsForGreaterLessThan()
    Console.ReadLine()
  End Sub

  Sub AddSubtractMyPointsWithMethodCalls()
    Dim p As New MyPoint(10, 10)
    Dim p2 As New MyPoint(20, 30)

    ' Add two MyPoints.
    Dim newPoint As MyPoint = MyPoint.Add(p, p2)
    Console.WriteLine("p + p2 = {0}", newPoint)

    ' Subtract two MyPoints.
    Console.WriteLine("p - p2 = {0}", MyPoint.Subtract(p, p2))
  End Sub

  Sub AddSubtractMyPointsWithOperators()
    Dim p As New MyPoint(10, 10)
    Dim p2 As New MyPoint(20, 30)

    ' Really calls: MyPoint.Operator+(p, p2)
    Dim newPoint As MyPoint = p + p2
    Console.WriteLine("p + p2 = {0}", newPoint)

    ' Really calls: MyPoint.Operator-(p, p2)
    Console.WriteLine("p - p2 = {0}", p - p2)
  End Sub

  ' Make use of the overloaded equality operators.
  Sub TestMyPointsForEquality()
    Dim ptOne As New MyPoint(10, 2)
    Dim ptTwo As New MyPoint(10, 44)

    Console.WriteLine("ptOne = ptTwo : {0}", ptOne = ptTwo)   ' False!
    Console.WriteLine("ptOne <> ptTwo : {0}", ptOne <> ptTwo) ' True!
  End Sub

  Sub TestMyPointsForGreaterLessThan()
    Dim ptOne As New MyPoint(5, 2)
    Dim ptTwo As New MyPoint(5, 44)

    Console.WriteLine("ptOne > ptTwo : {0}", ptOne > ptTwo)   ' False!
    Console.WriteLine("ptOne < ptTwo : {0}", ptOne < ptTwo) ' False!
    Console.WriteLine("ptOne >= ptTwo : {0}", ptOne >= ptTwo)   ' True!
    Console.WriteLine("ptOne <= ptTwo : {0}", ptOne <= ptTwo) ' True!
  End Sub
End Module
