<%@ WebService Language="VB" Class="HelloWebService" %>
Imports System 
Imports System.Web.Services 

Public Class HelloWebService
  <WebMethod()> _
  Public Function HelloWorld() As String
    Return "Hello World" 
  End Function
End Class
