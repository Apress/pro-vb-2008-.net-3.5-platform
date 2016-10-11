Option Explicit On
Option Strict On

Imports System.IO
Imports System.Text

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with StringWriter / StringReader *****")
    Console.WriteLine()

    ' Create a StringWriter and emit character data 
    ' to memory.
    Using strWriter As New StringWriter()
      strWriter.Write("Don't forget Mother's Day this year...")
      ' Get a copy of the contents (stored in a string) and pump
      ' to console.
      Console.WriteLine("Contents of StringWriter: {0}", strWriter)


      ' Get the internal StringBuilder.
      Dim sb As StringBuilder = strWriter.GetStringBuilder()
      sb.Insert(0, "Hey!! ")
      Console.WriteLine("-> {0}", sb.ToString())

      ' Remove the inserted string.
      sb.Remove(0, "Hey!! ".Length)
      Console.WriteLine("-> {0}", sb.ToString())

      ' Now dump using a StringReader.
      Console.WriteLine("-> Here are your thoughts:")
      Using strReader As New StringReader(strWriter.ToString())
        Dim input As String = strReader.ReadToEnd()
        Console.WriteLine(input)
      End Using
    End Using

    Console.ReadLine()
  End Sub
End Module
