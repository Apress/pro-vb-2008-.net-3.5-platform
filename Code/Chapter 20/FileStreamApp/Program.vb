Option Explicit On
Option Strict On

Imports System.IO
Imports System.Text

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with FileStreams *****")
    Console.WriteLine()

    ' Obtain a FileStream object.
    Using fStream As FileStream = File.Open("C:\myMessage.dat", FileMode.Create)
      ' Encode a string as an array of bytes.
      Dim msg As String = "Hello!"
      Dim msgAsByteArray As Byte() = Encoding.Default.GetBytes(msg)

      ' Write byte[] to file.
      fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length)

      ' Reset internal position of stream.
      fStream.Position = 0

      ' Read the types from file and display to console.
      Console.Write("Your message as an array of bytes: ")
      Dim bytesFromFile(msgAsByteArray.Length) As Byte
      Dim i As Integer = 0
      While i < msgAsByteArray.Length
        bytesFromFile(i) = CType(fStream.ReadByte, Byte)
        Console.Write(bytesFromFile(i))
        i = i + 1
      End While

      ' Display decoded messages.
      Console.WriteLine()
      Console.Write("Decoded Message: ")
      Console.WriteLine(Encoding.Default.GetString(bytesFromFile))
    End Using
    Console.ReadLine()
  End Sub
End Module
