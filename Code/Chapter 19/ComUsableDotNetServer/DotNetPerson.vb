<ComClass(DotNetPerson.ClassId, DotNetPerson.InterfaceId, DotNetPerson.EventsId)> _
Public Class DotNetPerson

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "6ff9b796-d080-4515-9fed-ddd7ffe225b2"
    Public Const InterfaceId As String = "14147f5a-a7b9-48c5-a545-3c2d66f089ad"
    Public Const EventsId As String = "19d005f1-4164-4116-8066-585f6ad6b2eb"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

  Public Function GetMessage() As String
    Return "I am alive..."
  End Function

End Class


