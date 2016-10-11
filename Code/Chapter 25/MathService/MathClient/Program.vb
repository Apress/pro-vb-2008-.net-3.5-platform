Imports MathClient.ServiceReference1
Imports System.Threading

Module Program
  Private proxy As New BasicMathClient

  Sub Main()
    Console.WriteLine("***** The Async Math Client *****")

    proxy.Open()

    Dim result As IAsyncResult = proxy.BeginAdd(10, 10, _
      New AsyncCallback(AddressOf AddCallback), Nothing)

    While Not result.IsCompleted
      Thread.Sleep(200)
    End While

    proxy.Close()
    Console.ReadLine()
  End Sub

  Sub AddCallback(ByVal i As IAsyncResult)
    Console.WriteLine("10 + 10 = {0}", proxy.EndAdd(i))
  End Sub
End Module
