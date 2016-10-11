#Region "Simple Car for testing"
Class Car
  Implements IDisposable
  Public Sub Dispose() Implements IDisposable.Dispose
    Console.WriteLine("In Car Dispose")
  End Sub
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Dispose *****")
    Using rw As New MyResourceWrapper(), _
          rw2 As New MyResourceWrapper(), _
          myCar As New Car()
      ' Use the objects, Dispose() automatically called!
    End Using
    Console.ReadLine()
  End Sub
End Module
