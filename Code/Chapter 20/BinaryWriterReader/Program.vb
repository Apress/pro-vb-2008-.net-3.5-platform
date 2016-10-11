Option Explicit On
Option Strict On

Imports System.IO

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Binary Writers / Readers *****" & vbLf)

    ' Open a binary writer for a file.
    Dim f As New FileInfo("BinFile.dat")

    Using bw As New BinaryWriter(f.OpenWrite())
      ' Print out the type of BaseStream.
      ' (System.IO.FileStream in this case).
      Console.WriteLine("Base stream is: {0}", bw.BaseStream)

      ' Create some data to save in the file
      Dim aDouble As Double = 1234.67
      Dim anInt As Integer = 34567
      Dim aString As String = "A, B, C"

      ' Write the data
      bw.Write(aDouble)
      bw.Write(anInt)
      bw.Write(aString)
    End Using

    ' Read the data as raw bytes
    Using br As New BinaryReader(f.OpenRead())
      Console.WriteLine(br.ReadDouble())
      Console.WriteLine(br.ReadInt32())
      Console.WriteLine(br.ReadString())
    End Using

    Console.ReadLine()
  End Sub
End Module
