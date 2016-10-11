Option Explicit On
Option Strict On

Imports AttributedCarLibrary

' Reflecting on custom attributes using early binding.
Module Program
  Sub Main()
    ' Get a Type representing the Winnebago.
    Dim t As Type = GetType(Winnebago)

    ' Get all attributes on the Winnebago.
    Dim customAtts As Object() = t.GetCustomAttributes(False)

    ' Print the description.
    Console.WriteLine("***** Value of VehicleDescriptionAttribute *****")
    For Each v As VehicleDescriptionAttribute In customAtts
      Console.WriteLine()
      Console.WriteLine("->{0}", v.Description)
    Next
    Console.ReadLine()
  End Sub
End Module
