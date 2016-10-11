<ServiceContract(Namespace:="www.intertech.com")> _
Public Interface IBasicMath
  <OperationContract()> _
  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
End Interface
