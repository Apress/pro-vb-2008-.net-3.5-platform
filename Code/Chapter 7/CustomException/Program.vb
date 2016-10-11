' This example illustrates how to throw, catch and interact with 
' custom exceptions.

Module Program
  Sub Main()
    Console.WriteLine("***** Simple Exception Example *****")
    Console.WriteLine("=> Creating a car and stepping on it!")
    Dim myCar As New Car("Zippy", 20)
    myCar.CrankTunes(True)

    Try
      For i As Integer = 0 To 10
        myCar.Accelerate(10)
      Next
    Catch ex As ArgumentOutOfRangeException
      Console.WriteLine(ex.Message)
    Catch ex As CarIsDeadException
      Console.WriteLine("*** Error! ***")
      Console.WriteLine("Member name: {0}", ex.TargetSite)
      Console.WriteLine("Class defining member: {0}", _
        ex.TargetSite.DeclaringType)
      Console.WriteLine("Member type: {0}", ex.TargetSite.MemberType)
      Console.WriteLine("Message: {0}", ex.Message)
      Console.WriteLine("Source: {0}", ex.Source)
      Console.WriteLine("Stack: {0}", ex.StackTrace)
      Console.WriteLine("Help Link: {0}", ex.HelpLink)

      ' By default, the data field is empty, so check for Nothing.
      Console.WriteLine("-> Custom Data:")
      If (ex.Data IsNot Nothing) Then
        For Each de As DictionaryEntry In ex.Data
          Console.WriteLine("-> {0} : {1}", de.Key, de.Value)
        Next
      End If
    Catch ex As Exception
      Console.WriteLine("Some other exception happened!")
      Console.WriteLine(ex.Message)
    Finally
      ' This will always execute, error or not.
      myCar.CrankTunes(False)
    End Try

    ' The error has been handled, processing continues with the next statement.
    Console.WriteLine("***** Out of exception logic *****")
    Console.ReadLine()
  End Sub
End Module
