Option Explicit On
Option Strict On

Imports Microsoft.VisualBasic

Public Class CarLotInfo
    Public Sub New(ByVal sPerson As String, _
      ByVal saleCar As String, ByVal popularColor As String)
        salesPersonOfTheMonth = sPerson
        currentCarOnSale = saleCar
        mostPopularColorOnLot = popularColor
    End Sub

    ' Public for easy access.
    Public salesPersonOfTheMonth As String
    Public currentCarOnSale As String
    Public mostPopularColorOnLot As String
End Class

