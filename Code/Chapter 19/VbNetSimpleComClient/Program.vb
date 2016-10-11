' You will need to compile the VB 6 project
' included in Appendix A in order for VS 2008
' to find the interop assembly.
Imports SimpleComServer

' As explained the the text, there are THREE different
' ways to interact with a COM object, each shown below.
' Uncomment / Comment a block to test.

Module Program
  Sub Main()
    Console.WriteLine("***** The .NET COM Client App *****")

    'Dim comObj As New ComCalc()
    'Console.WriteLine("COM server says 10 + 832 is {0}", _
    '  comObj.Add(10, 832))
    'Console.ReadLine()

    '' Now using the Class-suffixed type.
    'Dim comObj As New ComCalcClass()
    'Console.WriteLine("COM server says 10 + 832 is {0}", _
    '  comObj.Add(10, 832))
    'Console.ReadLine()

    ' Now manually obtain the hidden interface.
    Dim i As _ComCalc
    Dim c As New ComCalc()
    i = c
    Console.WriteLine("COM server says 10 + 832 is {0}", _
      i.Add(10, 832))
    Console.ReadLine()
  End Sub
End Module
