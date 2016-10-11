Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Object Init Syntax *****")
    ' Make a Point by setting each property manually...
    Dim firstPoint As New Point()
    firstPoint.X = 10
    firstPoint.Y = 10
    Console.WriteLine(firstPoint.ToString())

    ' ...or make a Point via a custom constructor...
    Dim anotherPoint As New Point(20, 20)
    Console.WriteLine(anotherPoint.ToString())

    ' ...or make a Point types using the new object init syntax.
    Dim finalPoint As New Point() With {.X = 30, .Y = 30}
    Console.WriteLine(finalPoint.ToString())

    Dim p As New Point With {.xPos = 2, .yPos = 3, .X = 900}
    Console.WriteLine(p.ToString())

    ' Calling a custom constructor.
    Dim pt As New Point(10, 16) With {.X = 100, .Y = 100}
    Console.WriteLine(pt.ToString())

    ' Calling a more interesting custom constructor with init syntax.
    Dim goldPoint As New Point(PointColor.Gold) With {.X = 90, .Y = 20}
    Console.WriteLine("Value of Point is: {0}", goldPoint)


    ' Create and initialize a Rectangle.
    Dim myRect As New Rectangle() With _
    { _
      .TopLeft = New Point() With {.X = 10, .Y = 10}, _
      .BottomRight = New Point() With {.X = 200, .Y = 200} _
    }
    Console.WriteLine(myRect)
    Console.ReadLine()
  End Sub

End Module
