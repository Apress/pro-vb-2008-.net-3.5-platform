Imports System.Runtime.Serialization

#Region "CarIsDeadException take one"
'Public Class CarIsDeadException
'  Inherits ApplicationException

'  ' Default error message.
'  Private messageDetails As String = "Car Error"

'  ' Constructors.
'  Public Sub New()
'  End Sub
'  Public Sub New(ByVal msg As String)
'    messageDetails = msg
'  End Sub

'  ' Override the Exception.Message property.
'  Public Overrides ReadOnly Property Message() As String
'    Get
'      Return String.Format("Car Error Message: {0}", messageDetails)
'    End Get
'  End Property
'End Class
#End Region

#Region "CarIsDeadException take two"
'Public Class CarIsDeadException
'  Inherits ApplicationException
'  Public Sub New()
'  End Sub
'  Public Sub New(ByVal msg As String)
'    MyBase.New(msg)
'  End Sub
'End Class
#End Region

#Region "CarIsDeadException take three"
<Serializable()> _
Public Class CarIsDeadException
  Inherits ApplicationException
  Public Sub New()
  End Sub
  Public Sub New(ByVal message As String)
    MyBase.New(message)
  End Sub
  Public Sub New(ByVal message As String, ByVal inner As System.Exception)
    MyBase.New(message, inner)
  End Sub
  Protected Sub New(ByVal info As SerializationInfo, _
    ByVal context As StreamingContext)
    MyBase.New(info, context)
  End Sub
End Class
#End Region
