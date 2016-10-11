<ServiceContract()> _
Public Interface IAutoLotService
  <OperationContract()> _
  Sub InsertCar(ByVal id As Integer, ByVal make As String, ByVal color As String, ByVal petname As String)

  <OperationContract(Name:="InsertCarWithDetails")> _
  Sub InsertCar(ByVal car As InventoryRecord)

  <OperationContract()> _
  Function GetInventory() As InventoryRecord()
End Interface

<DataContract()> _
Public Class InventoryRecord
  <DataMember()> _
  Public ID As Integer
  <DataMember()> _
  Public Make As String
  <DataMember()> _
  Public Color As String
  <DataMember()> _
  Public PetName As String
End Class
