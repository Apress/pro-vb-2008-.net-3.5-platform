Imports ExtensionMethods.MyExtensionMethods

Public Class Car
  Public Speed As Integer
  Public Function SpeedUp() As Integer
    Speed += 1
    Return Speed
  End Function
End Class

Module Project
  Sub Main()
    Console.WriteLine("***** Fun with Extension Methods *****" + vbLf)

    ' The Integer has assumed a new identity!
    Dim myInt As Integer = 12345678
    MyExtensions.DisplayDefiningAssembly(myInt)

    ' So has the DataSet!
    Dim d = New System.Data.DataSet()
    MyExtensions.DisplayDefiningAssembly(d)

    ' And the SoundPlayer (with details).
    Dim sp As New System.Media.SoundPlayer()
    MyExtensions.DisplayDefiningAssembly(d, True)

    ' Use new integer functionality.
    Console.WriteLine("Value of myInt: {0}", myInt)
    Console.WriteLine("Reversed digits of myInt: {0}", _
                      MyExtensions.ReverseDigits(myInt))

    Console.WriteLine()
    UseCar()
    Console.ReadLine()
  End Sub

  Sub UseCar()
    Dim c As New Car()
    c.Speed = 10
    Console.WriteLine("Speed: {0}", c.SpeedUp())
    Console.WriteLine("Speed: {0}", c.SlowDown())
  End Sub

End Module
