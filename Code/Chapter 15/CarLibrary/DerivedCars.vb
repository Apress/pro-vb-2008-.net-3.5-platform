Option Explicit On
Option Strict On

Imports System.Windows.Forms

#Region "SportsCar"
Public Class SportsCar
  Inherits Car

  Public Sub New()
  End Sub

  Public Sub New(ByVal carName As String, ByVal max As Short, ByVal curr As Short)
    MyBase.New(carName, max, curr)
  End Sub

  Public Overrides Sub TurboBoost()
    MessageBox.Show("Ramming speed!", "Faster is better...")
  End Sub
End Class
#End Region

#Region "MiniVan"
Public Class MiniVan
  Inherits Car

  Public Sub New()
  End Sub

  Public Sub New(ByVal carName As String, ByVal max As Short, ByVal curr As Short)
    MyBase.New(carName, max, curr)
  End Sub

  ' Minivans have poor turbo capabilities!
  Public Overrides Sub TurboBoost()
    egnState = EngineState.engineDead
    MessageBox.Show("Time to call AAA", "Your car is dead")
  End Sub
End Class
#End Region
