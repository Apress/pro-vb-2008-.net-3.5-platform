Option Explicit On
Option Strict On

Imports System.Reflection

Module Program
  Sub Main()
    Console.WriteLine("***** External Assembly Viewer *****")
    Dim asmName As String = String.Empty
    Dim asm As Assembly = Nothing
    Do
      Console.WriteLine()
      Console.WriteLine("Enter an assembly to evaluate")
      Console.Write("or enter Q to quit: ")

      ' Get name of assembly.
      asmName = Console.ReadLine()

      ' Does user want to quit?
      If asmName.ToUpper = "Q" Then
        Exit Do
      End If

      Try ' Try to load assembly.
        asm = Assembly.Load(asmName)
        DisplayTypesInAsm(asm)
      Catch
        Console.WriteLine("Sorry, can't find assembly named {0}.", asmName)
      End Try
    Loop
  End Sub

  Sub DisplayTypesInAsm(ByVal asm As Assembly)
    Console.WriteLine()
    Console.WriteLine("***** Types in Assembly *****")
    Console.WriteLine("->{0}", asm.FullName)
    Dim types As Type() = asm.GetTypes()
    For Each t As Type In types
      Console.WriteLine("Type: {0}", t)
    Next
    Console.WriteLine()
  End Sub
End Module
