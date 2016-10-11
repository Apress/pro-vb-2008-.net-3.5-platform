Option Explicit On
Option Strict On

Imports System.Configuration

Module Program
  Sub Main()
    Dim ar As New AppSettingsReader()
    Console.WriteLine(ar.GetValue("appConStr", GetType(String)))
    Dim numbOfTimes As Integer = CType(ar.GetValue("timesToSayHello", _
      GetType(Integer)), Integer)

    For i As Integer = 0 To numbOfTimes
      Console.WriteLine("Yo!")
    Next
    Console.ReadLine()
  End Sub
End Module
