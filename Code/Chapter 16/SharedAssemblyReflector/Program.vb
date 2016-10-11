Option Explicit On
Option Strict On

Imports System.Reflection

Module Program
  Sub Main()
    Console.WriteLine("***** The Shared Asm Reflector App *****")
    Console.WriteLine()
    Dim displayName As String = Nothing
    displayName = "System.Windows.Forms, Version=2.0.0.0, PublicKeyToken=b77a5c561934e089, Culture=neutral"
    Dim asm As Assembly = Assembly.Load(displayName)
    DisplayInfo(asm)
    Console.ReadLine()
  End Sub

  Sub DisplayInfo(ByVal a As Assembly)
    Console.WriteLine("***** Info about Assembly *****")
    Console.WriteLine("Loaded from GAC? {0} ", a.GlobalAssemblyCache())
    Console.WriteLine("Asm Name: {0} ", a.GetName().Name)
    Console.WriteLine("Asm Version: {0} ", a.GetName().Version)
    Console.WriteLine("Asm Culture: {0} ", a.GetName().CultureInfo.DisplayName)
    Dim types As Type() = a.GetTypes()

    ' Just print out the first 20 types.
    For i As Integer = 0 To 19
      Try
        Console.WriteLine("Type: {0}", types(i))
      Catch ex As Exception
        Console.WriteLine(ex.Message)
      End Try
    Next
  End Sub
End Module
