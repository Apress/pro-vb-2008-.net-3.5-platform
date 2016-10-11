Option Explicit On
Option Strict On

Public Interface IAppFunctionality
  Sub DoIt()
End Interface

<AttributeUsage(AttributeTargets.Class)> _
Public NotInheritable Class CompanyInfoAttribute
  Inherits System.Attribute
  Private companyName As String
  Private companyUrl As String

  Public Sub New()
  End Sub

  Public Property Name() As String
    Get
      Return companyName
    End Get
    Set(ByVal value As String)
      companyName = value
    End Set
  End Property

  Public Property Url() As String
    Get
      Return companyUrl
    End Get
    Set(ByVal value As String)
      companyUrl = value
    End Set
  End Property
End Class