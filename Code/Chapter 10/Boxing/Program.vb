Option Explicit On
Option Strict On

' Structures are value types!
Structure MyPoint
  Public x, y As Integer
End Structure

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Boxing / Unboxing *****")
    Console.WriteLine()

    ' Make a short value type.
    Dim s As Short = 25

    ' Because s is passed into a 
    ' method prototyped to take an Object,
    ' it is 'boxed' automatically.
    UseThisObject(s)

    Dim myData As New ArrayList()
    myData.Add(88)
    myData.Add(3.33)
    myData.Add(False)

    ' Unbox first item from ArrayList.
    Dim firstItem As Integer = CType(myData(0), Integer)
    Console.WriteLine("First item is {0} ", firstItem)

    Dim p As MyPoint
    p.x = 10
    p.y = 20
    UseBoxedMyPoint(p)

    Console.ReadLine()
  End Sub

  Sub UseThisObject(ByVal o As Object)
    Console.WriteLine("Value of o is: {0} ", o)
  End Sub

  Sub UseBoxedMyPoint(ByVal o As Object)
    ' Error!  System.Object does not have
    ' member variables named 'x' or 'y'.
    If TypeOf o Is MyPoint Then
      Dim p As MyPoint = CType(o, MyPoint)
      Console.WriteLine("{0}, {1}", p.x, p.y)
    End If
  End Sub
End Module
