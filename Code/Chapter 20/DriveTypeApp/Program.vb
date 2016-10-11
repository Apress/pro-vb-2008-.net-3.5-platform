Option Explicit On
Option Strict On

Imports System.IO

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with DriveInfo *****")
    Dim myDrives As DriveInfo() = DriveInfo.GetDrives()

    ' Print stats about each drive.
    For Each d As DriveInfo In myDrives
      Console.WriteLine("******************************")
      Console.WriteLine("-> Name: {0}", d.Name)
      Console.WriteLine("-> Type: {0}", d.DriveType)

      ' Is the drive mounted?
      If d.IsReady Then
        Console.WriteLine("-> Free space: {0}", d.TotalFreeSpace)
        Console.WriteLine("-> Format: {0}", d.DriveFormat)
        Console.WriteLine("-> Label: {0}", d.VolumeLabel)
      End If
    Next
    Console.ReadLine()
  End Sub
End Module
