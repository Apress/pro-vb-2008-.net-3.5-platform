Option Explicit On
Option Strict On

#Region "Helper types for testing"
Interface ITurboBoost
  Sub TurboCharge(ByVal onOff As Boolean)
End Interface

Class Car
End Class

Class SportsCar
  Inherits Car
  Implements ITurboBoost
  Public Sub TurboCharge(ByVal onOff As Boolean) _
    Implements ITurboBoost.TurboCharge
  End Sub
End Class
#End Region

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with CType / DirectCast / TryCast ******" & vbLf)

    Dim myCar As New Car
    Dim iTB As ITurboBoost

    ' CType()throws 
    ' exceptions if the types are not compatible. 
    Try
      iTB = CType(myCar, ITurboBoost)
    Catch ex As InvalidCastException
      Console.WriteLine(ex.Message)
      Console.WriteLine()
    End Try


    ' CType() can also be used to narrow or widen
    ' between primitive types.
    Dim i As Integer = 200
    Dim b As Byte = CType(i, Byte)

    ' Like CType(), DirectCast() throws 
    ' exceptions if the types are not compatible. 
    Dim myViper As New SportsCar
    Try
      iTB = DirectCast(myViper, ITurboBoost)
    Catch ex As Exception
      Console.WriteLine(ex.Message)
      Console.WriteLine()
    End Try

    ' TryCast() returns Nothing if the types are not
    ' compatible. 
    Dim c As Car = TryCast(myViper, Car)
    If c Is Nothing Then
      Console.WriteLine("Sorry, types are not compatable...")
    Else
      Console.WriteLine(c.ToString())
    End If
    Console.ReadLine()
  End Sub
End Module
