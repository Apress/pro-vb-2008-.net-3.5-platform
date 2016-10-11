Option Explicit On
Option Strict On

Imports Microsoft.VisualBasic

Public Class UserShoppingCart
  Public desiredCar As String
  Public desiredCarColor As String
  Public downPayment As Single
  Public isLeasing As Boolean
  Public dateOfPickUp As DateTime

  Public Overrides Function ToString() As String
    Return String.Format("Car: {0}<br>Color: {1}<br>" & _
      "$ Down: {2}<br>Lease: {3} <br>Pick-up Date: {4}", _
      desiredCar, desiredCarColor, downPayment, _
      isLeasing, dateOfPickUp.ToShortDateString())
  End Function
End Class

