Option Explicit On
Option Strict On

Imports System.ComponentModel

' Helper enum for images.
Public Enum AnimFrames
  Lemon1
  Lemon2
  Lemon3
  AboutToBlow
  EngineBlown
End Enum

<DefaultEvent("AboutToBlow"), _
DefaultProperty("Animate"), _
ToolboxBitmap(GetType(CarControl), "CarControl")> _
Public Class CarControl

  Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()
    StretchBox()
  End Sub

  ' State data.
  Private currFrame As AnimFrames = AnimFrames.Lemon1
  Private currMaxFrame As AnimFrames = AnimFrames.Lemon3
  Private IsAnim As Boolean
  Private currSp As Integer = 50
  Private maxSp As Integer = 100
  Private carPetName As String = "Lemon"
  Private bottomRect As Rectangle = New Rectangle()

  ' Car events.
  <Category("Car Configuration"), _
   Description("Sent when the car is approaching terminal speed.")> _
  Public Event AboutToBlow(ByVal msg As String)

  <Category("Car Configuration"), _
   Description("Sent when the engine block has exploded.")> _
  Public Event BlewUp(ByVal msg As String)

  Private Sub StretchBox()
    ' Configure picture box.
    currentImage.Top = 0
    currentImage.Left = 0
    currentImage.Height = Me.Height - 50
    currentImage.Width = Me.Width
    currentImage.Image = carImages.Images(CType(AnimFrames.Lemon1, Integer))
    ' Figure out size of bottom rect.
    bottomRect.X = 0
    bottomRect.Y = Me.Height - 50
    bottomRect.Height = Me.Height - currentImage.Height
    bottomRect.Width = Me.Width
  End Sub

#Region "Properties"
  ' Used to configure the internal Timer type.
  <Category("Car Configuration"), _
   Description("Do you want to animate?"), _
   DefaultValue("false")> _
  Public Property Animate() As Boolean
    Get
      Return IsAnim
    End Get
    Set(ByVal value As Boolean)
      IsAnim = value
      imageTimer.Enabled = IsAnim
    End Set
  End Property

  ' Configure pet name.
  <Category("Car Configuration"), _
   Description("Name your car!"), _
   DefaultValue("Lemon")> _
  Public Property PetName() As String
    Get
      Return carPetName
    End Get
    Set(ByVal value As String)
      carPetName = value
      Invalidate()
    End Set
  End Property

  ' Adjust currSp and currMaxFrame, and fire our events.
  <Category("Car Configuration"), _
   Description("Speed of the car"), _
   DefaultValue("50")> _
  Public Property Speed() As Integer
    Get
      Return currSp
    End Get
    Set(ByVal value As Integer)
      ' Within safe speed?
      If currSp <= maxSp Then
        currSp = value
        currMaxFrame = AnimFrames.Lemon3
      End If
      ' About to explode?
      If (maxSp - currSp) <= 10 Then

        RaiseEvent AboutToBlow("Slow down dude!")
        currMaxFrame = AnimFrames.AboutToBlow
      End If
      ' Maxed out?
      If currSp >= maxSp Then
        currSp = maxSp
        RaiseEvent BlewUp("Ug...you're toast...")
        currMaxFrame = AnimFrames.EngineBlown
      End If
    End Set
  End Property
#End Region

#Region "Event handlers"
  Private Sub imageTimer_Tick(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles imageTimer.Tick
    If IsAnim Then
      currentImage.Image = carImages.Images(CType(currFrame, Integer))
    End If
    ' Bump frame.
    Dim nextFrame As Integer = (CType(currFrame, Integer)) + 1
    currFrame = CType(nextFrame, AnimFrames)
    If currFrame > currMaxFrame Then
      currFrame = AnimFrames.Lemon1
    End If
  End Sub

  Private Sub CarControl_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) _
    Handles MyBase.Paint
    ' Render the pet name on the bottom of the control.
    Dim g As Graphics = e.Graphics
    g.FillRectangle(Brushes.GreenYellow, bottomRect)
    g.DrawString(PetName, New Font("Times New Roman", 15), Brushes.Black, bottomRect)
  End Sub
#End Region

End Class
