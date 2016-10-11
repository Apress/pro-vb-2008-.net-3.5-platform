Option Explicit On
Option Strict On

Imports System.IO

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with StreamWriter / StreamReader *****")
    Console.WriteLine()

    ' Get a StreamWriter and write string data.
    Using writer As StreamWriter = File.CreateText("reminders.txt")
      writer.WriteLine("Don't forget Mother's Day this year...")
      writer.WriteLine("Don't forget Father's Day this year...")
      writer.WriteLine("Don't forget these numbers:")
      For i As Integer = 0 To 10
        writer.Write(String.Format("{0},", i))
      Next

      ' Insert a new line and close. 
      writer.Write(writer.NewLine)
    End Using
    Console.WriteLine("Created file and wrote some thoughts...")

    Console.WriteLine("Here are your thoughts:")
    Using sr As StreamReader = File.OpenText("reminders.txt")
      Console.WriteLine(sr.ReadToEnd())
    End Using
    Console.ReadLine()
  End Sub
End Module
