Imports System.Reflection
Imports System.Windows.Forms

Module Program

  Sub Main()
    Console.WriteLine("***** The Amazing AppDomain app *****" & vbLf)

    ' Get info for current AppDomain.
    Dim defaultAD As AppDomain = AppDomain.CurrentDomain()
    MessageBox.Show("Hello")
    PrintAllAssembliesInAppDomain(defaultAD)
    Console.WriteLine()

    ' Programmatically make a new app domain.
    Dim anotherAD As AppDomain = AppDomain.CreateDomain("SecondAppDomain")
    ' Load CarLibrary.dll into this new appdomain.
    anotherAD.Load("CarLibrary")
    PrintAllAssembliesInAppDomain(anotherAD)

    ' Hook into DomainUnload event.
    AddHandler anotherAD.DomainUnload, AddressOf anotherAD_DomainUnload

    ' Now unload anotherAD.
    AppDomain.Unload(anotherAD)

    ' Hook into ProcessExit.
    AddHandler defaultAD.ProcessExit, AddressOf defaultAD_ProcessExit
    Console.ReadLine()
  End Sub

#Region "Handler for unloading app domains"
  Public Sub anotherAD_DomainUnload(ByVal sender As Object, ByVal e As EventArgs)
    Console.WriteLine("***** Unloaded anotherAD! *****")
  End Sub

  Private Sub defaultAD_ProcessExit(ByVal sender As Object, ByVal e As EventArgs)
    Console.WriteLine("***** Unloaded defaultAD! *****")
  End Sub
#End Region

#Region "PrintAllAssembliesInAppDomain"
  Public Sub PrintAllAssembliesInAppDomain(ByVal ad As AppDomain)
    Dim loadedAssemblies As Assembly() = ad.GetAssemblies()
    Console.WriteLine("***** Here are the assemblies loaded in {0} *****", _
      ad.FriendlyName)

    ' Remember!  We need to import System.Reflection to use
    ' the Assembly type.
    For Each a As Assembly In loadedAssemblies
      Console.WriteLine("-> Name: {0}", a.GetName.Name)
      Console.WriteLine("-> Version: {0}", a.GetName.Version)
    Next
  End Sub
#End Region

End Module
