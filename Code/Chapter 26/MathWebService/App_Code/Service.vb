Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

<WebService(Namespace:="http://intertech.com/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
Public Class MathService
  Inherits System.Web.Services.WebService
  <WebMethod()> _
  Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
  <WebMethod()> _
  Public Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x - y
  End Function
  <WebMethod()> _
  Public Function Multiply(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x * y
  End Function
  <WebMethod()> _
  Public Function Divide(ByVal x As Integer, ByVal y As Integer) As Integer
    If y = 0 Then
      Return 0
    Else
      Return x / y
    End If
  End Function
End Class

