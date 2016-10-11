Imports System.ServiceModel
Imports MagicEightBallServiceLib

Module Program

  Sub Main()
    Console.WriteLine("***** Console Based WCF Host *****")

    Using svcHost As New ServiceHost(GetType(MagicEightBallService))
      ' Open the host and start listening for incoming messages.
      svcHost.Open()
      DisplayHostInfo(svcHost)
      ' Keep the service running until the Enter key is pressed.
      Console.WriteLine("The service is ready.")
      Console.WriteLine("Press the Enter key to terminate service.")
      Console.ReadLine()
    End Using
  End Sub

  Private Sub DisplayHostInfo(ByVal host As ServiceHost)
    Console.WriteLine()
    Console.WriteLine("***** Host Info *****")

    Console.WriteLine("Name: {0}", host.Description.ConfigurationName)
    Console.WriteLine("Port: {0}", host.BaseAddresses(0).Port)
    Console.WriteLine("LocalPath: {0}", host.BaseAddresses(0).LocalPath)
    Console.WriteLine("Uri: {0}", host.BaseAddresses(0).AbsoluteUri)
    Console.WriteLine("Scheme: {0}", host.BaseAddresses(0).Scheme)
    Console.WriteLine("**********************")
    Console.WriteLine()
  End Sub
End Module
