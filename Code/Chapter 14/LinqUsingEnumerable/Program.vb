Module Program

  ' Comment / uncomment to see results.
  Sub Main()
    Console.WriteLine("***** Fun with LINQ *****")
    QueryStringArrayWithOperators()
    QueryStringsWithEnumerableAndLambdas()
    VeryComplexQueryExpression.QueryStringsWithRawDelegates()

    Console.ReadLine()
  End Sub

#Region "LINQ query with operators"
  Sub QueryStringArrayWithOperators()
    Console.WriteLine("***** Using LINQ Query Operators *****")

    Dim currentVideoGames As String() = {"Morrowind", "BioShock", _
      "Half Life 2: Episode 1", "The Darkness", _
      "Daxter", "System Shock 2"}

    ' Build a LINQ query with VB LINQ operators. 
    Dim subset = From g In currentVideoGames _
      Where g.Length > 6 Order By g Select g

    For Each s As String In subset
      Console.WriteLine("Item: {0}", s)
    Next
    Console.WriteLine()
  End Sub
#End Region

#Region "LINQ query with Enumerable / Lambdas"
  Sub QueryStringsWithEnumerableAndLambdas()

    Console.WriteLine("***** Using Enumerable / Lambda Expressions *****")

    Dim currentVideoGames() As String = {"Morrowind", "BioShock", _
    "Half Life 2: Episode 1", "The Darkness", _
    "Daxter", "System Shock 2"}

    ' Build a query expression using extension methods
    ' granted to the Array via the Enumerable type.    
    'Dim subset = currentVideoGames.Where(Function(game) game.Length > 6). _
    'OrderBy(Function(game) game).Select(Function(game) game)

    Dim subset = Enumerable.Where(currentVideoGames, Function(game) game.Length > 6). _
      OrderBy(Function(game) game).Select(Function(game) game)

    ' Print out the results.
    For Each game In subset
      Console.WriteLine("Item: {0}", game)
    Next
    Console.WriteLine()
  End Sub

#End Region

End Module
