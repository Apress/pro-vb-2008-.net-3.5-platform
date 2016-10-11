Option Explicit On
Option Strict On

Imports System.Windows.Forms

' Represents the state of the engine.
Public Enum EngineState
  engineAlive
  engineDead
End Enum

' Holds source of music.
Public Enum MusicMedia
  musicCd
  musicTape
  musicRadio
  musicMp3
End Enum

#Region "Car base class"
' The abstract base class in the hierarchy.
Public MustInherit Class Car
  Protected name As String
  Protected speed As Short
  Protected max_speed As Short
  Protected egnState As EngineState = EngineState.engineAlive

  Public MustOverride Sub TurboBoost()
  Public Sub TurnOnRadio(ByVal musicOn As Boolean, ByVal mm As MusicMedia)
    If musicOn Then
      MessageBox.Show(String.Format("Jamming {0} ", mm))
    Else
      MessageBox.Show("Quiet time...")
    End If
  End Sub
  Public Sub New()
    MessageBox.Show("Car 2.0.0.0")
  End Sub

  Public Sub New(ByVal carName As String, ByVal max As Short, ByVal curr As Short)
    MessageBox.Show("Car 2.0.0.0")
    name = carName
    max_speed = max
    speed = curr
  End Sub

  Public Property PetName() As String
    Get
      Return name
    End Get
    Set(ByVal value As String)
      name = value
    End Set
  End Property

  Public Property CurrSpeed() As Short
    Get
      Return speed
    End Get
    Set(ByVal value As Short)
      speed = value
    End Set
  End Property

  Public ReadOnly Property MaxSpeed() As Short
    Get
      Return max_speed
    End Get
  End Property

  Public ReadOnly Property EngineState() As EngineState
    Get
      Return egnState
    End Get
  End Property
End Class
#End Region
