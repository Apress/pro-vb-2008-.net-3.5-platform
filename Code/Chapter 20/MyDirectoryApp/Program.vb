Option Explicit On
Option Strict On

Imports System.IO

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Directory(Info) *****")
    Console.WriteLine()

    ShowWindowsDirectoryInfo()
    DisplayImageFiles()
    ModifyWindowsDirectory()
    FunWithDirectoryType()

    Console.ReadLine()
  End Sub

#Region "Helper methods"
  Sub ShowWindowsDirectoryInfo()
    ' Get basic info about C:\Windows
    Dim dir As New DirectoryInfo("C:\Windows")
    Console.WriteLine("***** Directory Info *****")
    Console.WriteLine("FullName: {0}  ", dir.FullName)
    Console.WriteLine("Name: {0}  ", dir.Name)
    Console.WriteLine("Parent: {0}  ", dir.Parent)
    Console.WriteLine("Creation: {0}  ", dir.CreationTime)
    Console.WriteLine("Attributes: {0}  ", dir.Attributes)
    Console.WriteLine("Root: {0}  ", dir.Root)
    Console.WriteLine("**************************")
    Console.WriteLine()
  End Sub

  Sub DisplayImageFiles()
    ' Get all files with a *.jpg extension.
    Dim dir As New DirectoryInfo("C:\Windows\Web\Wallpaper")
    Dim bitmapFiles As FileInfo() = dir.GetFiles("*.jpg")
    Console.WriteLine("Found {0} *.jpg files", bitmapFiles.Length)
    For Each f As FileInfo In bitmapFiles
      Console.WriteLine()
      Console.WriteLine("File name: {0}", f.Name)
      Console.WriteLine("File size: {0}", f.Length)
      Console.WriteLine("Creation: {0}", f.CreationTime)
      Console.WriteLine("Attributes: {0}", f.Attributes)
      Console.WriteLine()
      Console.WriteLine("***************************")
    Next
  End Sub

  Sub ModifyWindowsDirectory()
    Dim dir As New DirectoryInfo("C:\Windows")

    ' Create \MyFolder off initial directory.
    dir.CreateSubdirectory("MyFolder")

    ' Create \MyFolder2\Data off initial directory.
    dir.CreateSubdirectory("MyFolder2\Data")
  End Sub

  Sub FunWithDirectoryType()
    ' Use Directory type.
    Dim drives As String() = Directory.GetLogicalDrives()
    Console.WriteLine("Here are your drives:")
    For Each s As String In drives
      Console.WriteLine("—>{0}", s)
    Next

    ' Delete the directories we created. 
    Console.WriteLine("Press Enter to delete directories")
    Console.ReadLine()
    Try
      Directory.Delete("C:\Windows\MyFolder")
      Directory.Delete("C:\Windows\MyFolder2\Data")
    Catch e As IOException
      Console.WriteLine(e.Message)
    End Try
  End Sub
#End Region

End Module

