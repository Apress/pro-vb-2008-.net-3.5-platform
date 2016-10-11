Option Explicit On
Option Strict On

Imports System.Runtime.Serialization
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Custom Serialization *****")
    Console.WriteLine()

    ' Persist MyStringData
    Dim sd As MyStringData = New MyStringData()
    sd.dataItemOne = "This is some data."
    sd.dataItemTwo = "Here is some more data"
    Dim s As Stream = New FileStream("MyData.soap", FileMode.Create, _
      FileAccess.Write, FileShare.None)
    Dim sf As SoapFormatter = New SoapFormatter()
    sf.Serialize(s, sd)
    s.Close()

    ' Deserialize.
    s = File.OpenRead("MyData.soap")
    sd = CType(sf.Deserialize(s), MyStringData)
    Console.WriteLine("Item 1: {0}", sd.dataItemOne)
    Console.WriteLine("Item 2: {0}", sd.dataItemTwo)

    ' Persist MoreData
    Dim md As MoreStringData = New MoreStringData()
    md.dataItemOne = "Testing 1, 2, 3."
    md.dataItemTwo = "One more test..."
    s = New FileStream("MoreStringData.soap", FileMode.Create, FileAccess.Write, FileShare.None)
    sf = New SoapFormatter()
    sf.Serialize(s, md)
    s.Close()

    ' Deserialize 
    s = File.OpenRead("MoreStringData.soap")
    md = CType(sf.Deserialize(s), MoreStringData)
    Console.WriteLine("Item 1: {0}", md.dataItemOne)
    Console.WriteLine("Item 2: {0}", md.dataItemTwo)
    Console.WriteLine("Done!")
    Console.ReadLine()
  End Sub
End Module




