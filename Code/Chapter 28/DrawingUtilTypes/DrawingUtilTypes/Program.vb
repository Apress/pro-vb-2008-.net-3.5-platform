Option Strict On
Option Explicit On

Imports System.Drawing

Module Program
  Sub Main()
    Console.WriteLine("***** Working with Drawing utility types *****")
    Console.WriteLine()
    UsePoint()
    Console.WriteLine()
    UseRectangle()
    Console.ReadLine()
  End Sub

#Region "Use Point"
  Sub UsePoint()
    Console.WriteLine("***** Exercise Point *****")

    ' Create and offset a point.
    Dim pt As New Point(100, 72)
    Console.WriteLine(pt)
    pt.Offset(20, 20)
    Console.WriteLine(pt)

    ' Overloaded Point operators.
    Dim pt2 As Point = pt
    If pt = pt2 Then
      Console.WriteLine("Points are the same")
    Else
      Console.WriteLine("Different points")
    End If

    ' Change pt2's X value.
    pt2.X = 4000

    ' Now show each point's value
    Console.WriteLine("First point: {0}", pt)
    Console.WriteLine("Second point: {0}", pt2)
  End Sub
#End Region

#Region "Use Rectangle"
  Sub UseRectangle()
    Console.WriteLine("***** Point in Rect? *****")
    Dim r1 As New Rectangle(0, 0, 100, 100)
    Dim pt3 As Point = New Point(101, 101)
    If r1.Contains(pt3) Then
      Console.WriteLine("Point is within the rect!")
    Else
      Console.WriteLine("Point is not within the rect!")
    End If

    ' Now place point in rectangle's area.
    pt3.X = 50
    pt3.Y = 30
    If r1.Contains(pt3) Then
      Console.WriteLine("Point is within the rect!")
    Else
      Console.WriteLine("Point is not within the rect!")
    End If
  End Sub
#End Region

End Module
