' This project illustrates the use of the Shared keyword.
Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Shared Methods *****")
    For i As Integer = 0 To 5
      Console.WriteLine(Teenager.Complain())
    Next

    Console.WriteLine()

    ' VB-ism!  This will be a compiler error
    ' by setting the Instance variable accesses 
    ' shared member condition to "Error" using the My Project window.
    Dim bob As New Teenager()
    For i As Integer = 0 To 5
      Console.WriteLine(bob.Complain())
    Next

    Console.ReadLine()
  End Sub

End Module
