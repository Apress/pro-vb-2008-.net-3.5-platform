Imports MyExtensionsLibrary

Module Program

  Sub Main()
    Console.WriteLine("***** Using Library with Extensions *****")
    ' This time, these extension methods
    ' have been defined within an external
    ' .NET class library.
    Dim myInt As Integer = 987
    myInt.DisplayDefiningAssembly()
    Console.WriteLine("{0} is reversed to {1}", _
        myInt, myInt.ReverseDigits())
    Console.ReadLine()
  End Sub

End Module
