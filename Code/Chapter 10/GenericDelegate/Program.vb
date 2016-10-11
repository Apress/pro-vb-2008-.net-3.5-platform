Option Explicit On
Option Strict On

' This generic delegate can point to any method
' taking a single argument (specified at the time
' of creation).
Public Delegate Sub MyGenericDelegate(Of T)(ByVal arg As T)

#Region "Simulating generic delegates with Object."
Public Delegate Sub MyDelegate(ByVal arg As Object)

Module NonGenericDelegateTest
  Sub TestMethod()
    ' Register target with 'traditional' delegate syntax.
    Dim d As New MyDelegate(AddressOf MyTarget)
    d("More string data")

    ' Register target using method group conversion.
    Dim d2 As New MyDelegate(AddressOf MyTarget)
    d2(9)   ' Boxing penalty!
  End Sub

  ' Due to a lack of type safety, we must
  ' determine the underlying type before casting.
  Sub MyTarget(ByVal arg As Object)
    If TypeOf arg Is Integer Then
      Dim i As Integer = CType(arg, Integer)  ' Unboxing penalty!
      Console.WriteLine("++arg is: {0}", ++i)
    End If
    If TypeOf arg Is String Then
      Dim s As String = CType(arg, String)
      Console.WriteLine("arg in uppercase is: {0}", s.ToUpper())
    End If
  End Sub
End Module
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with generic delegates *****")
    Console.WriteLine()

    ' Make instance of delegate pointing to method taking an
    ' integer.
    Dim d As New MyGenericDelegate(Of Integer)(AddressOf IntegerTarget)
    d(100)

    ' Now pointing to a method taking a string.
    Dim d2 As New MyGenericDelegate(Of String)(AddressOf StringTarget)
    d2("Cool!")
  End Sub

  Public Sub IntegerTarget(ByVal arg As Integer)
    Console.WriteLine("You passed me a {0} with the value of {1}", _
      arg.GetType().Name, arg)
  End Sub

  Public Sub StringTarget(ByVal arg As String)
    Console.WriteLine("You passed me a {0} with the value of {1}", _
      arg.GetType().Name, arg)
  End Sub
End Module
