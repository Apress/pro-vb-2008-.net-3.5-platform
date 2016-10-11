Option Explicit On
Option Strict On

Imports System.IO
Imports System.Text
Imports System.Threading

Module Program
  Sub Main()
    Console.WriteLine("**** Asynch File IO *****")
    Console.WriteLine()

    Console.WriteLine("Main thread started. ThreadID = {0}", _
      Thread.CurrentThread.GetHashCode)

    ' Must use this ctor to get a FileStream with asynchronous
    ' read or write access.
    Dim fs As FileStream = New FileStream("logfile.txt", FileMode.Append, FileAccess.Write, FileShare.None, 4096, True)
    Dim msg As String = "this is a test"
    Dim buffer As Byte() = Encoding.ASCII.GetBytes(msg)

    ' Start the asynchronous write. WriteDone invoked when finished.
    ' Note that the FileStream object is passed as state info to the
    ' callback method.
    fs.BeginWrite(buffer, 0, buffer.Length, AddressOf WriteDone, fs)
  End Sub

  Private Sub WriteDone(ByVal ar As IAsyncResult)
    Console.WriteLine("AsyncCallback method on ThreadID = {0}", _
      Thread.CurrentThread.GetHashCode)
    Dim s As Stream = CType(ar.AsyncState, Stream)
    s.EndWrite(ar)
    s.Close()
  End Sub
End Module
