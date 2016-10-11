'''''''''''''''''''''''''''''''''''''''''''''''
' This program illustrates the construction of 
' methods and the ByVal, ByRef, ParamArray and
' Optional keywords as well as static local
' data. 
'''''''''''''''''''''''''''''''''''''''''''''''
Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Methods *****")
    ' Pass two Integers by value.
    Dim x, y As Integer
    x = 10 : y = 20
    Console.WriteLine("{0} + {1} = {2}", x, y, Add(x, y))

    ' X is still 10 and y is still 20.
    Console.WriteLine("After call x = {0} and y = {1}", x, y)
    Console.WriteLine()

    ' Pass a string by value, via ().
    Dim msg As String = "Hello from Main!"
    PrintMessage(msg)
    Console.WriteLine("After call msg = {0}", msg)
    Console.WriteLine()

    ' Call PrintFormattedMessage() using various optional args.
    ' Accept all defaults for the optional args.
    PrintFormattedMessage("Call One")

    ' Provide each optional argument.
    PrintFormattedMessage("Call Two", True, 5, ConsoleColor.Yellow)

    ' Print this message in current case, one time, in gray.
    PrintFormattedMessage("Call Three", , , ConsoleColor.Gray)

    ' Same as previously shown, but cleaner!
    PrintFormattedMessage("Call Four", textColor:=ConsoleColor.Gray)

    ' ParamArray data can be sent as a caller supplied array
    ' or a comma-delimited list of arguments.
    Console.WriteLine(CalculateAverage(10, 11, 12, 44))
    Dim data() As Integer = {22, 33, 44, 55}
    Console.WriteLine(CalculateAverage(data))
    Console.WriteLine()

    ' Call method with static local data.
    For i As Integer = 0 To 10
      PrintLocalCounter()
    Next
    Console.WriteLine()
    Console.ReadLine()
  End Sub

End Module
