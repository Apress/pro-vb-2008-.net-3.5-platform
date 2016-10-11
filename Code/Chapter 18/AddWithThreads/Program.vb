Option Explicit On
Option Strict On

Imports System.Threading

#Region "AddParams helper class"
Class AddParams
  Public a As Integer
  Public b As Integer
  Public Sub New(ByVal numb1 As Integer, ByVal numb2 As Integer)
    a = numb1
    b = numb2
  End Sub
End Class
#End Region

Module Program
  Sub Main(ByVal args As String())
    Console.WriteLine("***** Adding with Thread objects *****")
    Console.WriteLine()

    Console.WriteLine("ID of thread in Main(): {0}", Thread.CurrentThread.ManagedThreadId)
    Dim ap As AddParams = New AddParams(10, 10)
    Dim t As Thread = New Thread(AddressOf Add)
    t.Start(ap)
    Console.ReadLine()
  End Sub

  Public Sub Add(ByVal data As Object)
    If TypeOf data Is AddParams Then
      Console.WriteLine("ID of thread in Add(): {0}", Thread.CurrentThread.ManagedThreadId)
      Dim ap As AddParams = CType(data, AddParams)
      Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b)
    End If
  End Sub
End Module
