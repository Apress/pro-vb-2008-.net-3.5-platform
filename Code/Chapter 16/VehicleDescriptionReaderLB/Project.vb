Option Explicit On
Option Strict On

Imports System.Reflection

Module Project

  Sub Main()
    Console.WriteLine("***** Descriptions of Your Vehicles *****")
    Console.WriteLine()

    ' the local copy of AttributedCarLibrary.
    Dim asm As Assembly = Assembly.Load("AttributedCarLibrary")

    ' Get type info of VehicleDescriptionAttribute.
    Dim vehicleDesc As Type = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute")

    ' Get type info of the Description property.
    Dim propDesc As PropertyInfo = vehicleDesc.GetProperty("Description")

    ' Get all types in the assembly.
    Dim types As Type() = asm.GetTypes()

    ' Iterate over each attribute.
    For Each t As Type In types
      Dim objs As Object() = t.GetCustomAttributes(vehicleDesc, False)
      For Each o As Object In objs
        Console.WriteLine("-> {0} : {1}", t.Name, propDesc.GetValue(o, Nothing))
      Next
    Next
    Console.ReadLine()
  End Sub

End Module
