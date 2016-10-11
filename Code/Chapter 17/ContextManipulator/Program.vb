Imports System.Runtime.Remoting.Contexts  ' For Context type.
Imports System.Threading  ' For Thread type.

#Region "Car types for context testing"
' SportsCar has no special contextual
' needs and will be loaded into the
' default context of the app domain.
Public Class SportsCar
  Public Sub New()
    ' Get context information and print out context ID.
    Dim ctx As Context = Thread.CurrentContext()
    Console.WriteLine("{0} object in context {1}", Me.ToString(), ctx.ContextID)
    For Each prop As IContextProperty In ctx.ContextProperties
      Console.WriteLine("-> Ctx Prop: {0}", prop.Name)
    Next
  End Sub
End Class

' SportsCarTS demands to be loaded in
' a synchronization context.
<Synchronization()> _
Public Class SportsCarTS
  Inherits ContextBoundObject

  Public Sub New()
    ' Get context information and print out context ID.
    Dim ctx As Context = Thread.CurrentContext()
    Console.WriteLine("{0} object in context {1}", Me.ToString(), ctx.ContextID)
    For Each prop As IContextProperty In ctx.ContextProperties
      Console.WriteLine("-> Ctx Prop: {0}", prop.Name)
    Next
  End Sub
End Class
#End Region

Module Program

  Sub Main()
    Console.WriteLine("***** The Amazing Context Application *****")
    Console.WriteLine()

    ' Objects will display contextual info upon creation.
    Dim sport As New SportsCar()
    Console.WriteLine()

    Dim sport2 As New SportsCar()
    Console.WriteLine()

    Dim synchroSport As New SportsCarTS()
    Console.ReadLine()
  End Sub

End Module
