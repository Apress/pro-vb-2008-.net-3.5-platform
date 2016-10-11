Option Explicit On
Option Strict On

Module Program
    Sub Main()
        Console.WriteLine("***** Fun with Custom Conversions *****")
        Console.WriteLine()

        ' Create a 5 * 10 Rectangle.
        Dim rect As Rectangle
        rect.Width = 10
        rect.Height = 5
        Console.WriteLine("rect = {0} ", rect)

        DrawSquare(CType(rect, Square))

        ' Convert Rectangle to a 10 * 10 Square.
        Dim sq As Square = CType(rect, Square)
        Console.WriteLine("sq = {0} ", sq)

        ' Implicit cast OK!
        Dim s3 As Square
        s3.Length = 83
        Dim rect2 As Rectangle = s3
        Console.WriteLine("rect2 = {0}", rect2)
        DrawSquare(s3)

        ' Explicit cast syntax still OK!
        Dim s4 As Square
        s4.Length = 3
        Dim rect3 As Rectangle = CType(s4, Rectangle)
        Console.WriteLine("rect3 = {0}", rect3)
        Console.ReadLine()
    End Sub

    ' This method requires a Square type.
    Sub DrawSquare(ByVal sq As Square)
        sq.Draw()
    End Sub
End Module
