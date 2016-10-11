Option Explicit On
Option Strict On

Imports System.Runtime.Serialization

#Region "Using ISerializable"
<Serializable()> _
Class MyStringData
  Implements ISerializable

  Public dataItemOne As String
  Public dataItemTwo As String

  Public Sub New()
  End Sub

  ' Called by formatter when object graph is being deseralized. 
  Private Sub New(ByVal si As SerializationInfo, ByVal ctx As StreamingContext)
    dataItemOne = si.GetString("First_Item").ToLower()
    dataItemTwo = si.GetString("dataItemTwo").ToLower()
  End Sub

  ' Called by formatter when object is being serialized. 
  Public Sub GetObjectData(ByVal info As SerializationInfo, _
    ByVal context As StreamingContext) Implements ISerializable.GetObjectData
    info.AddValue("First_Item", dataItemOne.ToUpper())
    info.AddValue("dataItemTwo", dataItemTwo.ToUpper())
  End Sub
End Class
#End Region

#Region "Using attributes"
<Serializable()> _
Class MoreStringData
  Public dataItemOne As String
  Public dataItemTwo As String

  ' This method is called by the formatter when the 
  ' object is being serialized. 
  <OnSerializing()> _
  Private Sub OnSerializing(ByVal context As StreamingContext)
    dataItemOne = dataItemOne.ToUpper()
    dataItemTwo = dataItemTwo.ToUpper()
  End Sub

  ' This method is called by the formatter when the 
  ' object is being deserialized.
  <OnDeserialized()> _
  Private Sub OnDeserialized(ByVal context As StreamingContext)
    dataItemOne = dataItemOne.ToLower()
    dataItemTwo = dataItemTwo.ToLower()
  End Sub
End Class

#End Region