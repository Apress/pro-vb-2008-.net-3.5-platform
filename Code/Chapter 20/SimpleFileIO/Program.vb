Imports System.IO

Module Program
  Sub Main()
    ' Write these strings to a new file on the C drive.
    Dim myTasks As String() = {"Fix bathroom sink", _
      "Call Dave", "Call Mom and Dad", _
      "Play Xbox 360"}
    File.WriteAllLines("C:\tasks.txt", myTasks)

    ' Now read in each one and print to the console.
    For Each task As String In File.ReadAllLines("C:\tasks.txt")
      Console.WriteLine("TODO: {0}.", task)
    Next

    Console.ReadLine()

  End Sub
End Module
