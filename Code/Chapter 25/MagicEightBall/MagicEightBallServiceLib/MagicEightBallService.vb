' The key WCF namespace.
Imports System.ServiceModel

<ServiceContract(Namespace:="http://Intertech.com")> _
Public Interface IEightBall
  ' Ask a question, receive an answer!
  <OperationContract()> _
  Function ObtainAnswerToQuestion(ByVal userQuestion As String) As String
End Interface


Public Class MagicEightBallService
  Implements IEightBall
  ' Just for display purposes on the host.
  Public Sub New()
    Console.WriteLine("The 8-Ball awaits your question...")
  End Sub

  Public Function ObtainAnswerToQuestion(ByVal userQuestion As String) As String _
  Implements IEightBall.ObtainAnswerToQuestion
    Dim answers As String() = {"Future Uncertain", "Yes", "No", _
                               "Hazy", "Ask again later", "Definitely"}

    ' Return a random response.
    Dim r As New Random()
    Return String.Format("{0}? {1}.", userQuestion, answers(r.Next(answers.Length)))
  End Function
End Class
