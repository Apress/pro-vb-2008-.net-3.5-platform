Module Program

  Sub Main()
    Console.WriteLine("***** Value type containing reference type *****" & vbLf)

    ' Create the first MyRectangle.
    Console.WriteLine("-> Creating r1")
    Dim r1 As New MyRectangle("This is my first rect")

    ' Now assign a new MyRectangle to r1.
    Console.WriteLine("-> Assigning r2 to r1")
    Dim r2 As MyRectangle
    r2 = r1

    ' Change values of r2.
    Console.WriteLine("-> Changing all values of r2")
    r2.rectInfo.infoString = "This is new info!"
    r2.bottom = 4444

    ' Print values
    Console.WriteLine("-> Values after change:")
    Console.WriteLine("-> r1.rectInfo.infoString: {0}", r1.rectInfo.infoString)
    Console.WriteLine("-> r2.rectInfo.infoString: {0}", r2.rectInfo.infoString)
    Console.WriteLine("-> r1.bottom: {0}", r1.bottom)
    Console.WriteLine("-> r2.bottom: {0}", r2.bottom)
    Console.ReadLine()
  End Sub

End Module
