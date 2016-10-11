Option Explicit On
Option Strict On

Imports System.IO

Module Program
  Sub Main()
    Console.WriteLine("***** The Amazing File Watcher App *****")

    ' Create and configre the watcher.
    Dim watcher As New FileSystemWatcher()
    Try
      watcher.Path = "C:\MyFolder"
    Catch ex As ArgumentException
      Console.WriteLine(ex.Message)
      Return
    End Try
    watcher.NotifyFilter = NotifyFilters.LastAccess Or _
                           NotifyFilters.LastWrite Or _
                           NotifyFilters.FileName Or _
                           NotifyFilters.DirectoryName
    watcher.Filter = "*.txt"

    ' Establish event handlers. 
    AddHandler watcher.Changed, AddressOf OnFileModified
    AddHandler watcher.Created, AddressOf OnFileModified
    AddHandler watcher.Deleted, AddressOf OnFileModified
    AddHandler watcher.Renamed, AddressOf OnFileRenamed
    watcher.EnableRaisingEvents = True

    Console.WriteLine("Press 'q' to quit app.")
    Console.ReadLine()
  End Sub

  ' Event handlers.
  Sub OnFileModified(ByVal source As Object, ByVal e As FileSystemEventArgs)
    ' Specify what is done when a file is changed, created, or deleted.
    Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType)
  End Sub

  Sub OnFileRenamed(ByVal source As Object, ByVal e As RenamedEventArgs)
    ' Specify what is done when a file is renamed.
    Console.WriteLine("File: {0} renamed to {1}.", e.OldFullPath, e.FullPath)
  End Sub
End Module

