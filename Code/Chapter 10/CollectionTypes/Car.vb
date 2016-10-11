Option Explicit On
Option Strict On

Public Class Car
  Implements IComparable

  ' Constant for maximum speed.
  Public Const maxSpeed As Integer = 100

  'Internal state data.
  Private currSpeed As Integer
  Private petName As String
  Private carID As Integer

  'Is the car still operational?
  Private carIsDead As Boolean

  'A car has a radio.
  Private theMusicBox As Radio = New Radio

#Region "Properties & constructors"
  ' Properties.
  Public Property Name() As String
    Get
      Return petName
    End Get
    Set(ByVal value As String)
      petName = value
    End Set
  End Property
  Public Property Speed() As Integer
    Get
      Return currSpeed
    End Get
    Set(ByVal value As Integer)
      currSpeed = value
    End Set
  End Property
  Public Property ID() As Integer
    Get
      Return carID
    End Get
    Set(ByVal value As Integer)
      carID = value
    End Set
  End Property

  ' Constructors.
  Public Sub New()
  End Sub
  Public Sub New(ByVal name As String, ByVal currSp As Integer, ByVal id As Integer)
    currSpeed = currSp
    petName = name
    carID = id
  End Sub
#End Region

  Public Sub CrankTunes(ByVal state As Boolean)
    theMusicBox.TurnOn(state)
  End Sub

  ' See if Car has overheated.
  Public Sub Accelerate(ByVal delta As Integer)
    If carIsDead Then
      Console.WriteLine("{0} is out of order...", petName)
    Else
      currSpeed += delta
      If currSpeed >= maxSpeed Then
        carIsDead = True
        currSpeed = 0

        ' We need to call the HelpLink property, thus we need to
        ' create a local variable before throwing the Exception object.
        Dim ex As New Exception(String.Format("{0} has overheated!", petName))
        ex.HelpLink = "http://www.CarsRUs.com"
        ' Stuff in custom data regarding the error.
        ex.Data.Add("TimeStamp", _
             String.Format("The car exploded at {0} ", DateTime.Now))
        ex.Data.Add("Cause", "You have a lead foot.")
        Throw ex
      Else
        Console.WriteLine("=> CurrSpeed = {0} ", currSpeed)
      End If
    End If
  End Sub

  Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
    Dim temp As Car = CType(obj, Car)
    If Me.carID > temp.carID Then
      Return 1
    End If
    If Me.carID < temp.carID Then
      Return -1
    Else
      Return 0
    End If
  End Function

  Public Shared ReadOnly Property SortByPetName() As IComparer
    Get
      Return CType(New PetNameComparer(), IComparer)
    End Get
  End Property
End Class