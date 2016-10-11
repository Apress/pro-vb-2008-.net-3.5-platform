Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Namespace AutoLotDisconnectedLayer
  Public Class InventoryDALDisLayer
    ' Field data.
    Private cnString As String = String.Empty
    Private dAdapt As SqlDataAdapter = Nothing

    Public Sub New(ByVal connectionString As String)
      cnString = connectionString

      ' Configure the SqlDataAdapter.
      ConfigureAdapter(dAdapt)
    End Sub

    Private Sub ConfigureAdapter(ByRef dAdapt As SqlDataAdapter)
      ' Create the adapter and set up the SelectCommand
      dAdapt = New SqlDataAdapter("Select * From Inventory", cnString)

      ' Obtain the remaining Command objects dynamically at runime
      ' using the SqlCommandBuilder.
      Dim builder As New SqlCommandBuilder(dAdapt)
    End Sub

    Public Function GetAllInventory() As DataTable
      Dim inv As New DataTable("Inventory")
      dAdapt.Fill(inv)
      Return inv
    End Function

    Public Sub UpdateInventory(ByVal modifiedTable As DataTable)
      dAdapt.Update(modifiedTable)
    End Sub
  End Class
End Namespace
