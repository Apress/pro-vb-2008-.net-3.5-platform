'''''''''''''''''''''''''''''''''''''''''''
' This example illustrates the basics
' of working with Structure types.
' Later chapters in the text will dive
' into further details.
'''''''''''''''''''''''''''''''''''''''''''
#Region "A simple structure type"
Structure Point
  Public X, Y As Integer
  Sub Display()
    Console.WriteLine("X = {0}, Y = {1}", X, Y)
  End Sub
  Sub Increment()
    X += 1 : Y += 1
  End Sub
  Sub Decrement()
    X -= 1 : Y -= 1
  End Sub
  ' Recall that the ‘x’ format flag displays the 
  ' data in hex format. 
  Function PointAsHexString() As String
    Return String.Format("X = {0:x}, Y = {1:x}", X, Y)
  End Function
End Structure
#End Region

Module Program

  Sub Main()
    Console.WriteLine("***** A First Look at Structures *****")
    ' Create an initial Point.
    Dim myPoint As Point
    myPoint.X = 349
    myPoint.Y = 76
    myPoint.Display()

    ' Adjust the X and Y values.
    myPoint.Increment()
    myPoint.Display()
    Console.WriteLine("Point in hex: {0}", myPoint.PointAsHexString())
  End Sub

End Module
