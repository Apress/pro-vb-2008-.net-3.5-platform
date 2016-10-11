' Note: I have specified start up arguments using the 
' My Project editor (see Ch.3 for details).

Class Program
  Shared Function Main(ByVal args As String()) As Integer
    Console.WriteLine("***** Fun with Main() *****")
    Dim s As String
    For Each s In args
      Console.WriteLine("Arg: {0}", s)
    Next

    ' OS running this app?
    Console.WriteLine("Current OS: {0}", Environment.OSVersion)

    ' List the drives on this machine.
    Dim drives As String() = Environment.GetLogicalDrives()
    Dim d As String
    For Each d In drives
      Console.WriteLine("You have a drive named {0}.", d)
    Next

    ' Which version of the .NET platform is running this app?
    Console.WriteLine("Executing version of .NET: {0}", _
      Environment.Version)
    Return 0
  End Function
End Class
