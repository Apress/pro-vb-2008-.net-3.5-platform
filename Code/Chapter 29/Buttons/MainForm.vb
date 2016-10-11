Option Explicit On
Option Strict On

Public Class MainForm
  ' Hold the current text alignment
  Private currAlignment As ContentAlignment = ContentAlignment.MiddleCenter
  Private currEnumPos As Integer = 0

  Private Sub btnStandard_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnStandard.Click
    ' Get all possible values
    ' of the ContentAlignment enum.
    Dim values As Array = [Enum].GetValues(currAlignment.GetType())

    ' Bump the current position in the enum.
    ' & check for wrap around.
    currEnumPos += 1
    If currEnumPos >= values.Length Then
      currEnumPos = 0
    End If

    ' Bump the current enum value.
    currAlignment = CType([Enum].Parse(currAlignment.GetType(), _
      values.GetValue(currEnumPos).ToString()), ContentAlignment)
    btnStandard.TextAlign = currAlignment

    ' Paint enum value name on button.
    btnStandard.Text = currAlignment.ToString()

    ' Now assign the location of the icon on
    ' btnImage...
    btnImage.ImageAlign = currAlignment
  End Sub
End Class
