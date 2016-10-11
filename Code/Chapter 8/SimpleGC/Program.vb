Module Program
  Sub Main()
    Console.WriteLine("***** Fun with System.GC *****")

    ' Print out estimated number of bytes on heap.
    Console.WriteLine("Estimated bytes on heap: {0}", _
      GC.GetTotalMemory(False))

    ' MaxGeneration is zero based.
    Console.WriteLine("This OS has {0} object generations.", _
      (GC.MaxGeneration + 1))

    Dim refToMyCar As New Car("Zippy", 100)
    Console.WriteLine(refToMyCar.ToString())

    ' Print out generation of refToMyCar.
    Console.WriteLine("Generation of refToMyCar is: {0}", _
      GC.GetGeneration(refToMyCar))

    ' Make a ton of objects for testing purposes.
    Dim tonsOfObjects(5000) As Object
    For i As Integer = 0 To UBound(tonsOfObjects)
      tonsOfObjects(i) = New Object()
    Next

    ' Collect only gen 0 objects.
    GC.Collect(0)
    GC.WaitForPendingFinalizers()

    ' Print out generation of refToMyCar.
    Console.WriteLine("Generation of refToMyCar is: {0}", _
      GC.GetGeneration(refToMyCar))

    ' See if tonsOfObjects(4000) is still alive.
    If (tonsOfObjects(4000) IsNot Nothing) Then
      Console.WriteLine("Generation of tonsOfObjects(4000) is: {0}", _
        GC.GetGeneration(tonsOfObjects(4000)))
    Else
      Console.WriteLine("tonsOfObjects(4000) is no longer alive.")
    End If

    ' Print out how many times a generation has been swept.
    Console.WriteLine("Gen 0 has been swept {0} times", _
      GC.CollectionCount(0))
    Console.WriteLine("Gen 1 has been swept {0} times", _
      GC.CollectionCount(1))
    Console.WriteLine("Gen 2 has been swept {0} times", _
      GC.CollectionCount(2))
    Console.ReadLine()
  End Sub

  Sub MakeACar()
    ' If myCar is the only reference to the Car object,
    ' it may be destroyed when the method returns.
    Dim myCar As New Car()
    myCar = Nothing
  End Sub

End Module
