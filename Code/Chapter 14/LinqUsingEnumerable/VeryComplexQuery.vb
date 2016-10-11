Class VeryComplexQueryExpression
  Public Shared Sub QueryStringsWithRawDelegates()
    Console.WriteLine("***** Using Raw Delegates *****")

    Dim currentVideoGames As String() = {"Morrowind", "BioShock", _
                                         "Half Life 2: Episode 1", "The Darkness", _
                                         "Daxter", "System Shock 2"}

    ' Build the necessary Func<> delegates using anonymous methods.
    Dim searchFilter As New Func(Of String, Boolean)(AddressOf Filter)
    Dim itemToProcess As New Func(Of String, String)(AddressOf ProcessItem)

    ' Pass the delegates into the methods of Enumerable.
    Dim subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess)

    ' Print out the results.
    For Each game In subset
      Console.WriteLine("Item: {0}", game)
    Next
    Console.WriteLine()
  End Sub

  ' Delegate targets.
  Public Shared Function Filter(ByVal str As String) As Boolean
    Return str.Length > 6
  End Function
  Public Shared Function ProcessItem(ByVal str As String) As String
    Return str
  End Function
End Class
