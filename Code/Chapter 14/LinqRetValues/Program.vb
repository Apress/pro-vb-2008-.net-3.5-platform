#Region "Car class for testing"
Public Class Car
  Public PetName As String = String.Empty
  Public Color As String = String.Empty
  Public Speed As Integer
  Public Make As String = String.Empty

  Public Overloads Overrides Function ToString() As String
    Return String.Format("Make={0}, Color={1}, Speed={2}, PetName={3}", _
      Make, Color, Speed, PetName)
  End Function
End Class
#End Region

Module Program

  Sub Main()
    Console.WriteLine("***** LINQ Transformations *****" + vbLf)
    Dim subset As IEnumerable(Of String) = GetStringSubset()
    For Each item As String In subset
      Console.WriteLine(item)
    Next

    Dim objs As Array = GetProjectedSubset()
    For Each o As Object In objs
      Console.WriteLine(o)  ' Calls ToString() on each anonymous object.
    Next

    Console.ReadLine()
  End Sub

  Function GetStringSubset() As IEnumerable(Of String)
    Dim currentVideoGames() As String = {"Morrowind", "BioShock", _
      "Half Life 2: Episode 1", "The Darkness", _
      "Daxter", "System Shock 2"}

    ' Note subset is an IEnumerable(OfString) compatable object.
    Dim subset As IEnumerable(Of String) = _
    From g In currentVideoGames Where g.Length > 6 Order By g Select g
    Return subset
  End Function

  ' Return value is now an Array.
  Public Function GetProjectedSubset() As Array
    ' This array will be the basis of our testing...
    Dim myCars As Car() = {New Car With _
                 {.PetName = "Henry", .Color = "Silver", _
                  .Speed = 100, .Make = "BMW"}, _
    New Car With {.PetName = "Daisy", .Color = "Tan", .Speed = 90, .Make = "BMW"}, _
    New Car With {.PetName = "Zippy", .Color = "Yellow", .Speed = 55, .Make = "VW"}}

    Dim makesColors = From c In myCars Select New With {c.Make, c.Color}

    ' Map set of anonymous objects to an Array object.
    ' Here were are relying on type inference of the generic
    ' type parameter, as we don't know the type of type!
    Return makesColors.ToArray()
  End Function

End Module
