Option Explicit On
Option Strict On

Imports CarLibrary

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with CodeBases *****")
    Dim c As New SportsCar()
    Console.WriteLine("Sports car has been allocated.")
    Console.ReadLine()
  End Sub
End Module