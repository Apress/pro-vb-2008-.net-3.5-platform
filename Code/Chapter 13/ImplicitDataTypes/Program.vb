' Do not allow VB 6.0 style late binding.
Option Strict On

' Remember this is the default. 
Option Infer On

#Region "Simple car types for testing purposes."
Public Class Car
End Class
Public Class SportsCar
  Inherits Car
End Class
Public Class MiniVan
  Inherits Car
End Class
#End Region

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Impliict Typing *****")
    Console.WriteLine()

    ImplicitTyping()
    Console.WriteLine()

    ImplicitTypingInForEach()
    Console.WriteLine()

    QueryOverInts()
    Console.ReadLine()
  End Sub

#Region "Explicit typing example"
  Public Sub ExplicitTyping()
    ' Local variables are declared as so:
    ' Dim variableName As dataType = initialValue 
    Dim myInt As Integer = 0
    Dim myBool As Boolean = True
    Dim myString As String = "Time, marches on..."
  End Sub
#End Region

#Region "Implicit typing examples"
  Public Sub ImplicitTyping()
    ' Implicitly typed local variables.
    Dim myInt = 0
    Dim myBool = True
    Dim myString = "Time, marches on..."

    ' Print out the underlying type.
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name)
    Console.WriteLine("myBool is a: {0}", myBool.GetType().Name)
    Console.WriteLine("myString is a: {0}", myString.GetType().Name)

    ' Assume we have classes of type SportsCar
    ' and MiniVan somewhere in the project. 
    Dim evenNumbers = New Integer() {2, 4, 6, 8}

    Dim myMinivans = New List(Of MiniVan)()
    Dim myCar = New SportsCar()

    Console.WriteLine("evenNumbers is a: {0}", evenNumbers.GetType().Name)
    Console.WriteLine("myMinivans is a: {0}", myMinivans.GetType().Name)
    Console.WriteLine("myCar is a: {0}", myCar.GetType().Name)
  End Sub

  Public Sub ImplicitTypingInForEach()
    ' Use implicit typing in a standard for each loop.
    Dim evenNumbers() = New Integer() {2, 4, 6, 8}

    ' Here, explicitly define the iterator type.
    For Each item As Integer In evenNumbers
      Console.WriteLine("Item value: {0}", item)
    Next
  End Sub
#End Region

#Region "Simple LINQ query w/ implicit typing"
  Sub QueryOverInts()
    Dim numbers() As Integer = {10, 20, 30, 40, 1, 2, 3, 8}
    Dim subset = From i In numbers Where i < 10 Select i

    Console.Write("Values in subset: ")
    For Each i In subset
      Console.Write("{0} ", i)
    Next
    Console.WriteLine()

    ' Humm...what type is subset?
    Console.WriteLine("subset is a: {0}", subset.GetType().Name)
    Console.WriteLine("Namespace of subset is: {0}", subset.GetType().Namespace)
  End Sub
#End Region

End Module
