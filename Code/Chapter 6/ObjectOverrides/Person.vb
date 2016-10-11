' Remember! Person extends Object.
Class Person
  Public Sub New(ByVal firstName As String, ByVal lastName As String, _
    ByVal age As Byte)
    fName = firstName
    lName = lastName
    personAge = age
  End Sub
  Sub New()
  End Sub

  ' Public only for simplicity. Properties and Private data
  ' would obviously be perferred.
  Public fName As String
  Public lName As String
  Public personAge As Byte

#Region "System.Object overrides"
  Public Overrides Function ToString() As String
    Dim myState As String
    myState = String.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", _
        fName, lName, personAge)
    Return myState
  End Function

  'Public Overrides Function Equals(ByVal obj As Object) As Boolean
  '    If TypeOf obj Is Person AndAlso obj IsNot Nothing Then
  '      Dim temp As Person = CType(obj, Person)
  '        If temp.fName = Me.fName AndAlso _
  '          temp.lName = Me.fName AndAlso _
  '          temp.personAge = Me.personAge Then
  '            Return True
  '        Else
  '            Return False
  '        End If
  '        Return False
  '    End If
  'End Function

  Public Overrides Function Equals(ByVal obj As Object) As Boolean
    ' No need to cast 'obj' to a Person anymore,
    ' as everyting has a ToString() method.
    Return obj.ToString = Me.ToString()
  End Function

  ' Return a hash code based on the person's ToString() value.
  Public Overrides Function GetHashCode() As Integer
    Return Me.ToString().GetHashCode()
  End Function

#End Region

End Class
