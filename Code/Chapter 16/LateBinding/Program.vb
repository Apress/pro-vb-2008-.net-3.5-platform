Option Explicit On

' If you disable Option Strict, you are able to 
' Simplify your late biniding, as shown in the 
' commented out EasyMain() method below.
Option Strict On

Imports System.Reflection
Imports System.IO

Module Program

#Region "This logic will when Option Strict is On or Off"
  Sub Main()
    Console.WriteLine("***** Fun with Late Binding *****")

    ' Try to load a local copy of CarLibrary.
    Dim a As Assembly = Nothing
    Try
      a = Assembly.Load("CarLibrary")
    Catch e As FileNotFoundException
      Console.WriteLine(e.Message)
      Return
    End Try

    ' If we found it, get type information about
    ' the minivan and create an instance. 
    Dim miniVan As Type = a.GetType("CarLibrary.MiniVan")
    Dim obj As Object = Activator.CreateInstance(miniVan)

    ' Get info for TurboBoost.
    Dim mi As MethodInfo = miniVan.GetMethod("TurboBoost")

    ' Invoke method ('Nothing' for no parameters).
    mi.Invoke(obj, Nothing)

    '' Bind late to a method taking params.
    '' If you updated MiniVan with a TellChildToBeQuiet() method
    '' (see Ch. 14) you can test with the following.
    'Dim args(1) As Object
    'args(0) = "Fred"
    'args(1) = 4
    'mi = miniVan.GetMethod("TellChildToBeQuiet")
    'mi.Invoke(obj, args)

    Console.ReadLine()
  End Sub
#End Region

#Region "This logic will ONLY work if Option Strict is Off"
  'Sub EasyMain()
  '    Console.WriteLine("You must disable Option Strict for this to work!")

  '    ' Try to load a local copy of CarLibrary.
  '    Dim a As Assembly = Nothing
  '    Try
  '        a = Assembly.Load("CarLibrary")
  '    Catch e As FileNotFoundException
  '        Console.WriteLine(e.Message)
  '        Return
  '    End Try

  '    ' If we found it, get type information about
  '    ' the minivan and create an instance. 
  '    Dim miniVan As Type = a.GetType("CarLibrary.MiniVan")
  '    Dim obj As Object = Activator.CreateInstance(miniVan)
  '    obj.TurboBoost()
  '    obj.TellChildToBeQuiet("Fred", 4)
  'End Sub
#End Region

End Module
