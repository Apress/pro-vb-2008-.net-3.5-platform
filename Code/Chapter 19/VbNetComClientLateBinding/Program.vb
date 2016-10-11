' If you uncomment the following line,
' using CreateObject() within Main()
' will result in a compiler error!
' Option Strict On

Imports System.Reflection

Module Program
  Sub Main()
    Console.WriteLine("***** The Late Bound .NET Client *****")

    ' First get IDispatch reference from coclass.
    Dim calcObj As Type = _
      Type.GetTypeFromProgID("SimpleCOMServer.ComCalc")
    Dim calcDisp As Object = Activator.CreateInstance(calcObj)

    ' Make the array of args.
    Dim addArgs() As Object = {100, 24}

    ' Invoke the Add() method and obtain summation.
    Dim sum As Object
    sum = calcObj.InvokeMember("Add", BindingFlags.InvokeMethod, _
      Nothing, calcDisp, addArgs)

    ' Display result.
    Console.WriteLine("Late bound adding: 100 + 24 is: {0}", sum)

    ' This will only compile if Option Strict is disabled.
    Dim c As Object = CreateObject("SimpleCOMServer.ComCalc")
    Console.WriteLine("10 + 10 = {0}", c.Add(10, 10))
    Console.ReadLine()
  End Sub
End Module
