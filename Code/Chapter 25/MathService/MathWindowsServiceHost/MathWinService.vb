' Be sure to import these namespaces:
Imports MathServiceLibrary
Imports System.ServiceModel

Partial Public Class MathWinService
  ' A member variable of type ServiceHost.
  Private myHost As ServiceHost

  Public Sub New()
    InitializeComponent()
  End Sub

  Protected Overloads Overrides Sub OnStart(ByVal args As String())
    ' Just to be really safe.
    If myHost IsNot Nothing Then
      myHost.Close()
      myHost = Nothing
    End If

    ' Create the host. 
    myHost = New ServiceHost(GetType(MathService))

    ' The ABCs in code!
    Dim address As New Uri("http://localhost:8080/MathServiceLibrary")
    Dim binding As New WSHttpBinding()
    Dim contract As Type = GetType(IBasicMath)

    ' Add this endpoint.
    myHost.AddServiceEndpoint(contract, binding, address)

    ' Open the host.
    myHost.Open()
  End Sub

  Protected Overloads Overrides Sub OnStop()
    ' Shut down the host.
    If myHost IsNot Nothing Then
      myHost.Close()
    End If
  End Sub
End Class
