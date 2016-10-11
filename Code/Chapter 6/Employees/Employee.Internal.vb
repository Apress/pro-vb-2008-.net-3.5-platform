Public Class Employee
  ' Field data.
  Private empName As String
  Private empID As Integer
  Private currPay As Single
  Private empAge As Integer
  Private empSSN As String
  Private Shared companyName As String

#Region "Properties"
  ''' <summary>
  ''' Gets or sets the name of the employee.
  ''' </summary>
  ''' <value></value>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Property Name() As String
    Get
      Return empName
    End Get
    Set(ByVal value As String)
      empName = value
    End Set
  End Property

  ''' <summary>
  ''' Gets or sets the ID of the employee.
  ''' </summary>
  ''' <value></value>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Property ID() As Integer
    Get
      Return empID
    End Get
    Set(ByVal value As Integer)
      empID = value
    End Set
  End Property

  ''' <summary>
  ''' Gets or sets the current pay of the employee.
  ''' </summary>
  ''' <value></value>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Property Pay() As Single
    Get
      Return currPay
    End Get
    Set(ByVal value As Single)
      currPay = value
    End Set
  End Property

  ''' <summary>
  ''' Gets or sets the age of the employee.
  ''' </summary>
  ''' <value></value>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Property Age() As Integer
    Get
      Return empAge
    End Get
    Set(ByVal value As Integer)
      empAge = value
    End Set
  End Property
  ''' <summary>
  ''' Read only access to SSN.
  ''' Set this value with a constructor argument.
  ''' </summary>
  ''' <value></value>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public ReadOnly Property SocialSecurityNumber() As String
    Get
      Return empSSN
    End Get
  End Property

  ''' <summary>
  ''' Set the company name of the employees.
  ''' </summary>
  ''' <value></value>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Shared Property Company() As String
    Get
      Return companyName
    End Get
    Set(ByVal value As String)
      companyName = value
    End Set
  End Property
#End Region

#Region "Constructors"
  ''' <summary>
  ''' The default constructor.
  ''' </summary>
  ''' <remarks></remarks>
  Sub New()
  End Sub
  ''' <summary>
  ''' A custom constrctor to set the state of an employee.
  ''' </summary>
  ''' <param name="name"></param>
  ''' <param name="age"></param>
  ''' <param name="id"></param>
  ''' <param name="pay"></param>
  ''' <param name="ssn"></param>
  ''' <remarks></remarks>
  Sub New(ByVal name As String, ByVal age As Integer, _
    ByVal id As Integer, ByVal pay As Single, _
    ByVal ssn As String)
    empName = name
    empAge = age
    empID = id
    empSSN = ssn
    currPay = pay
  End Sub
  ''' <summary>
  ''' This shared constructor sets the shared companyName
  ''' field.
  ''' </summary>
  ''' <remarks></remarks>
  Shared Sub New()
    companyName = "Intertech Training"
  End Sub
#End Region

#Region "Getter / Setter for empName field"
  '' Accessor (get method)
  'Public Function GetName() As String
  '    Return empName
  'End Function

  '' Mutator (set method)
  'Public Sub SetName(ByVal name As String)
  '    ' Remove any illegal characters (!,@,#,$,%),
  '    ' check maximum length or case before making assignment.
  '    empName = name
  'End Sub
  'Public Function get_SocialSecurityNumber() As String
  '    Return empSSN
  'End Function
  'Public Sub set_SocialSecurityNumber(ByVal val As String)
  '    empSSN = val
  'End Sub
#End Region

End Class
