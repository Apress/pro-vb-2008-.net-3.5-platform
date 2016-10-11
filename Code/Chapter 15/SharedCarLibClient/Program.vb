Option Explicit On
Option Strict On

Imports CarLibrary

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Shared Assemblies *****")
    Dim mycar As New SportsCar()
    mycar.TurboBoost()
    Console.ReadLine()
  End Sub
End Module
