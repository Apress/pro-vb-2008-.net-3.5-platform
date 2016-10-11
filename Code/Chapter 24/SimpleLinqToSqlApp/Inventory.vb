Imports System.Data.Linq.Mapping

<Table()> _
Public Class Inventory
  <Column()> _
  Public Make As String
  <Column()> _
  Public Color As String
  <Column()> _
  Public PetName As String

  ' Identify the primary key.
  <Column(IsPrimaryKey:=True)> _
  Public CarID As Integer

  Public Overrides Function ToString() As String
    Return String.Format("ID = {0}; Make = {1}; Color = {2}; PetName = {3}", _
      CarID, Make.Trim(), Color.Trim(), PetName.Trim())
  End Function
End Class

