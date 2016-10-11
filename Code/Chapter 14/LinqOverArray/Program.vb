Option Explicit On
Option Strict On

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with LINQ *****")
    'QueryOverStrings()
    Console.WriteLine()
    QueryOverInts()
    Console.ReadLine()
  End Sub

#Region "Simple query over strings and integers"
  Sub QueryOverStrings()
    ' Assume we have an array of strings.
    ' that have more than 6 letters.
    Dim currentVideoGames As String() = {"Morrowind", "BioShock", _
      "Half Life 2: Episode 1", "The Darkness", _
      "Daxter", "System Shock 2"}

    Dim subset As IEnumerable(Of String) = From game In currentVideoGames _
      Where game.Length > 6 Order By game Select game
    ReflectOverQueryResults(subset)

    ' Print out the results.
    For Each s As String In subset
      Console.WriteLine("Item: {0}", s)
    Next
    Console.WriteLine()
  End Sub

  Sub QueryOverInts()
    Dim numbers() As Integer = {10, 20, 30, 40, 1, 2, 3, 8}

    ' Only print items less than 10.
    ' (note use of implicit typing)
    Dim subset = From i In numbers Where i < 10 Select i

    ' LINQ statment evaluated here!
    For Each i In subset
      Console.WriteLine("{0} < 10", i)
    Next

    ' Change some data in the array.
    numbers(0) = 4
    Console.WriteLine()

    ' Evaluate again.
    For Each i In subset
      Console.WriteLine("{0} < 10", i)
    Next
    ReflectOverQueryResults(subset)
  End Sub

#End Region

#Region "Immediate execution"
  Sub ImmediateExecution()
    Dim numbers() As Integer = {10, 20, 30, 40, 1, 2, 3, 8}

    ' Get data RIGHT NOW as Integer().
    Dim subsetAsIntArray() As Integer = _
      (From i In numbers Where i < 10 Select i).ToArray()

    ' Get data RIGHT NOW as List(Of Integer).
    Dim subsetAsListOfInts As List(Of Integer) = _
      (From i In numbers Where i < 10 Select i).ToList()
  End Sub
#End Region

  Sub ReflectOverQueryResults(ByVal resultSet As Object)
    Console.WriteLine("***** Info about your query *****")
    Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name)
    Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly)
    Console.WriteLine()
  End Sub

End Module
