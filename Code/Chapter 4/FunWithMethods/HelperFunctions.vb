Module HelperFunctions

#Region "ByRef / ByVal"
  ' Subroutines have no return value.
  Sub PrintMessage(ByRef msg As String)
    Console.WriteLine("Your message is: {0}", msg)
    ' Caller will see this change!
    msg = "Thank you for calling this method"
  End Sub

  ' Functions have a return value.
  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Dim answer As Integer = x + y
    ' Try to set the params to a new value.
    x = 22 : y = 30
    Return answer
  End Function

  ' This will not compile if Option Strict is on!
  Function Test()  ' As Object assumed.
    Return 5
  End Function
#End Region

#Region "Optional args"
  Sub PrintFormattedMessage(ByVal msg As String, _
        Optional ByVal upperCase As Boolean = False, _
        Optional ByVal timesToRepeat As Integer = 0, _
        Optional ByVal textColor As ConsoleColor = ConsoleColor.Green)
    ' Store current console foreground color.
    Dim fGroundColor As ConsoleColor = Console.ForegroundColor
    ' Set Console foreground color.
    Console.ForegroundColor = textColor
    ' Print mesage in correct case x number of times.
    For i As Integer = 0 To timesToRepeat
      Console.WriteLine(msg)
    Next
    ' Reset current console forground color.
    Console.ForegroundColor = fGroundColor
  End Sub
#End Region

#Region "Param array"
  Function CalculateAverage(ByVal ParamArray itemsToAvg() As Integer) As Double
    Dim itemCount As Integer = UBound(itemsToAvg)
    Dim result As Integer
    For i As Integer = 0 To itemCount
      result += itemsToAvg(i)
    Next
    Return result / itemCount
  End Function
#End Region

#Region "Static data in method"
  Sub PrintLocalCounter()
    ' Note the Static keyword.
    Static Dim localCounter As Integer
    localCounter += 1
    Console.Write("{0} ", localCounter)
  End Sub
#End Region

End Module
