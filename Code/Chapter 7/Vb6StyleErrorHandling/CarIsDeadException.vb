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
  Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, _
    ByVal context As System.Runtime.Serialization.StreamingContext)
    MyBase.New(info, context)
  End Sub
End Class


