Imports MagicEightBallServiceClient.ServiceReference1

Module Program
  Sub Main()
    Console.WriteLine("***** Ask the Magic 8 Ball *****" & Chr(10) & "")

    Using ball As New EightBallClient()
      Console.Write("Your question: ")
      Dim question As String = Console.ReadLine()
      Dim answer As String = ball.ObtainAnswerToQuestion(question)
      Console.WriteLine("8-Ball says: {0}", answer)
    End Using
    Console.ReadLine()
  End Sub
End Module
