Option Explicit On
Option Strict On

#Region "Helper classes"
'Class DatabaseReader
'  ' Nullable data fields.
'  Public numericValue As Nullable(Of Integer)
'  Public boolValue As Nullable(Of Boolean) = True

'  ' Note the nullable return type. 
'  Public Function GetIntFromDatabase() As Nullable(Of Integer)
'    Return numericValue
'  End Function

'  ' Note the nullable return type. 
'  Public Function GetBoolFromDatabase() As Nullable(Of Boolean)
'    Return boolValue
'  End Function
'End Class

Class DatabaseReader
  ' Note the use of the ? operator in the class
  ' definition.
  Public numericValue As Integer?
  Public boolValue As Boolean? = True

  ' Note the nullable return type. 
  Public Function GetIntFromDatabase() As Integer?
    Return numericValue
  End Function

  ' Note the nullable return type. 
  Public Function GetBoolFromDatabase() As Boolean?
    Return boolValue
  End Function
End Class
#End Region

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Nullable Data *****" & vbLf)
    Dim dr As New DatabaseReader()

    ' Get int from 'database'.
    Dim i As Integer? = dr.GetIntFromDatabase()
    If (i.HasValue) Then
      Console.WriteLine("Value of 'i' is: {0}", i.Value)
    Else
      Console.WriteLine("Value of 'i' is undefined.")
    End If

    ' Get bool from 'database'.
    Dim b As Boolean? = dr.GetBoolFromDatabase()
    If (b.HasValue) Then
      Console.WriteLine("Value of 'b' is: {0}", b.Value)
    Else
      Console.WriteLine("Value of 'b' is undefined.")
    End If

    Console.ReadLine()
  End Sub

#Region "Main with Nullable (Of T)"
  'Sub Main()
  '  Console.WriteLine("***** Fun with Nullable Data *****")
  '  Console.WriteLine()
  '  Dim dr As New DatabaseReader()

  '  ' Get int from 'database'.
  '  Dim i As Nullable(Of Integer) = dr.GetIntFromDatabase()
  '  If (i.HasValue) Then
  '    Console.WriteLine("Value of 'i' is: {0}", i.Value)
  '  Else
  '    Console.WriteLine("Value of 'i' is undefined.")
  '  End If

  '  ' Get bool from 'database'.
  '  Dim b As Nullable(Of Boolean) = dr.GetBoolFromDatabase()
  '  If (b.HasValue) Then
  '    Console.WriteLine("Value of 'b' is: {0}", b.Value)
  '  Else
  '    Console.WriteLine("Value of 'b' is undefined.")
  '  End If
  '  Console.ReadLine()
  'End Sub
#End Region

End Module
