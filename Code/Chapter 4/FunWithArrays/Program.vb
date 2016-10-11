'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'' This program illustrates how to create and manipulate
'' array types. 
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Module Program
  ' Comment / Uncomment method calls within Main() to test.
  Sub Main()
    Console.WriteLine("***** Fun with Arrays *****")
    ' SimpleArrays()
    ' ArrayOfObjects()
    ' ArrayLowerBounds()
    ' RedimPreserve()
    ' MultiDimArray()
    SystemArrayFunctionality()
  End Sub

End Module

Module HelperMethods

#Region "Simple arrays"
  Sub SimpleArrays()
    Console.WriteLine("=> Simple Array Creation.")
    ' Create and fill an array of 3 Integers
    Dim myInts() As Integer = {100, 200, 300}
    ' Now print each value.
    For Each i As Integer In myInts
      Console.WriteLine(i)
    Next

    ' String array with assigned data.
    Dim myStrs(2) As String
    myStrs(0) = "Cerebus"
    myStrs(1) = "Jaka"
    myStrs(2) = "Astoria"
    For Each s As String In myStrs
      Console.WriteLine(s)
    Next
  End Sub
#End Region

#Region "Array of Objects"
  Sub ArrayOfObjects()
    Console.WriteLine("=> Array of Objects.")

    ' An array of Objects can be anything at all.
    Dim myObjects(3) As Object
    myObjects(0) = 10
    myObjects(1) = False
    myObjects(2) = New DateTime(1969, 3, 24)
    myObjects(3) = "Form & Void"

    For Each obj As Object In myObjects
      ' Print the type and value for each item in array.
      Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj)
    Next
    Console.WriteLine()
  End Sub
#End Region

#Region "Array w/ lower bounds"
  Sub ArrayLowerBounds()
    Console.WriteLine("=> Using Array.CreateInstance().")
    ' An array representing the length of each dimension
    Dim myLengths() As Integer = {3}
    ' An array representing the lower bound of each dimension.
    Dim myBounds() As Integer = {5}

    ' Call Array.CreateInstance() specifying
    ' the type of array, length and bounds.
    Dim mySpecialArray As Array = _
      Array.CreateInstance(GetType(Integer), myLengths, myBounds)
    Console.WriteLine("Lower Bound: {0}", LBound(mySpecialArray))
    Console.WriteLine("Upper Bound: {0}", UBound(mySpecialArray))
    Console.WriteLine()
  End Sub

#End Region

#Region "Redim / preserve"
  Sub RedimPreserve()
    Console.WriteLine("=> Redim / Preserve keywords.")
    ' Make an array with 10 slots.
    Dim myValues(9) As Integer
    For i As Integer = 0 To 9
      myValues(i) = i
    Next
    For i As Integer = 0 To UBound(myValues)
      Console.Write("{0} ", myValues(i))
    Next

    ' ReDim the array with extra slots.
    ReDim Preserve myValues(15)
    For i As Integer = 9 To UBound(myValues)
      myValues(i) = i
    Next
    For i As Integer = 0 To UBound(myValues)
      Console.Write("{0} ", myValues(i))
    Next
    Console.WriteLine()
  End Sub
#End Region

#Region "multidim-array"
  Sub MultiDimArray()
    Console.WriteLine("=> Multidimensional arrays.")
    Dim myMatrix(6, 6) As Integer  ' makes a 7x7 array
    ' Populate array.
    Dim k As Integer, j As Integer
    For k = 0 To 6
      For j = 0 To 6
        myMatrix(k, j) = k * j
      Next j
    Next k
    ' Show array.
    For k = 0 To 6
      For j = 0 To 6
        Console.Write(myMatrix(k, j) & "  ")
      Next j
      Console.WriteLine()
    Next k
    Console.WriteLine()
  End Sub

#End Region

#Region "Using System.Array"
  Sub SystemArrayFunctionality()
    Console.WriteLine("=> Working with System.Array.")
    ' Initialize items at startup.
    Dim gothicBands() As String = _
      {"Tones on Tail", "Bauhaus", "Sisters of Mercy"}

    ' Print out names in declared order.
    Console.WriteLine(" -> Here is the array:")
    For i As Integer = 0 To gothicBands.GetUpperBound(0)
      ' Print a name
      Console.Write(gothicBands(i) & " ")
    Next
    Console.WriteLine()
    Console.WriteLine()

    ' Reverse them...
    Array.Reverse(gothicBands)
    Console.WriteLine(" -> The reversed array")
    ' ... and print them.
    For i As Integer = 0 To gothicBands.GetUpperBound(0)
      ' Print a name
      Console.Write(gothicBands(i) & " ")
    Next
    Console.WriteLine()
    Console.WriteLine()

    ' Clear out all but the final member.
    Console.WriteLine(" -> Cleared out all but one...")
    Array.Clear(gothicBands, 1, 2)
    For i As Integer = 0 To gothicBands.GetUpperBound(0)
      ' Print a name
      Console.Write(gothicBands(i) & " ")
    Next
    Console.WriteLine()
  End Sub
#End Region

End Module