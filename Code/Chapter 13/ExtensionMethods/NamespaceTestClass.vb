' Here is our only imports directive.
Imports System

' Comment this out to receive a coding error. 
Imports ExtensionMethods.MyExtensionMethods

Namespace MyNewApp

  Class JustATest
    Sub SomeMethod()
      ' Error! Need to import MyExtensionMethods
      ' namespace to extend integer with ReverseDigits()!
      Dim i As Integer = 0
      i.ReverseDigits()
    End Sub
  End Class

End Namespace
