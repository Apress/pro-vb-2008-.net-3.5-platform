Option Explicit On
Option Strict On

Public Class Radio
    Public Sub TurnOn(ByVal state As Boolean)
        If state = True Then
            Console.WriteLine("Jamming...")
        Else
            Console.WriteLine("Quiet time...")
        End If
    End Sub
End Class