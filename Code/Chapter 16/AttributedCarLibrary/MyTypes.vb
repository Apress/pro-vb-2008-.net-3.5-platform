Option Explicit On
Option Strict On

' Enforce CLS compliance for all public types in this assembly.
<Assembly: System.CLSCompliantAttribute(True)> 

#Region "Our custom attribute"
<AttributeUsage(AttributeTargets.Class Or _
AttributeTargets.Struct, AllowMultiple:=False, Inherited:=False)> _
Public NotInheritable Class VehicleDescriptionAttribute
  Inherits System.Attribute
  Private msgData As String

  Public Sub New(ByVal description As String)
    msgData = description
  End Sub

  Public Sub New()
  End Sub

  Public Property Description() As String
    Get
      Return msgData
    End Get
    Set(ByVal value As String)
      msgData = value
    End Set
  End Property
End Class
#End Region

<Serializable(), VehicleDescription(Description:="My rocking Harley")> _
Public Class Motorcycle
  ' However this field will not be persisted.
  <NonSerialized()> _
  Private weightOfCurrentPassengers As Single

  ' These fields are still serializable.
  Private hasRadioSystem As Boolean
  Private hasHeadSet As Boolean
  Private hasSissyBar As Boolean
End Class

<SerializableAttribute()> _
<Obsolete("This class is obsolete, use another vehicle!"), _
VehicleDescription("The old grey Mare she ain't what she used to be...")> _
Public Class HorseAndBuggy
End Class

<VehicleDescription("A very long, slow but feature rich auto")> _
Public Class Winnebago
  ' This will generate a warning, as UInt64 is not
  ' CLS compilant, and we have specified the <CLSCompilant> attribute!
  ' Public notCompliant As UInt64
End Class