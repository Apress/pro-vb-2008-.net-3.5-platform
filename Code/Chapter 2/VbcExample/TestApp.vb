' A simple VB 2008 application.
Imports System

' Don't need this anymore.
' Imports System.Windows.Forms

Module TestApp
  Sub Main()
    Console.WriteLine("Testing! 1, 2, 3")

    ' Don't need this anymore either.
    ' MessageBox.Show("Hello!")
        
    ' Exercise the HelloMessage class! 
    Dim hello As New HelloMessage()
    hello.Speak()
  End Sub 
End Module
