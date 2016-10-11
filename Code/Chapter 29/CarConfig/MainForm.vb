Option Explicit On
Option Strict On

Public Class MainForm

  Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    CenterToScreen()
  End Sub

#Region "Button Click logic"
  Private Sub btnOrder_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnOrder.Click
    ' Build a string to display information.
    Dim orderInfo As String = ""
    If comboSalesPerson.Text <> "" Then
      orderInfo &= "Sales Person: " + comboSalesPerson.Text & Chr(10)
    Else
      orderInfo &= "You did not select a sales person!" & "" & Chr(10)
    End If
    If carMakeList.SelectedItem IsNot Nothing Then
      orderInfo &= "Make: " & carMakeList.SelectedItem.ToString() & "" & Chr(10)
    End If
    If checkFloorMats.Checked Then
      orderInfo &= "You want floor mats." & Chr(10)
    End If
    If radioRed.Checked Then
      orderInfo &= "You want a red exterior." & Chr(10)
    End If
    If radioYellow.Checked Then
      orderInfo &= "You want a yellow exterior." & Chr(10)
    End If
    If radioGreen.Checked Then
      orderInfo &= "You want a green exterior." & Chr(10)
    End If
    If radioPink.Checked Then
      orderInfo &= "Why do you want a PINK exterior?" & Chr(10)
    End If

    orderInfo += "--------------------------------" & Chr(10)
    For i As Integer = 0 To checkedBoxRadioOptions.Items.Count - 1
      ' For each item in the CheckedListBox...
      ' Is the current item checked?
      If checkedBoxRadioOptions.GetItemChecked(i) Then
        ' Get text of current item.
        orderInfo &= "Radio Item: "
        orderInfo &= checkedBoxRadioOptions.Items(i).ToString()
        orderInfo &= "" & Chr(10) & ""
      End If
    Next
    orderInfo += "--------------------------------" & Chr(10)

    ' Get ship date.
    Dim startD As DateTime = monthCalendar.SelectionStart
    Dim endD As DateTime = monthCalendar.SelectionEnd

    ' Get correct string representation.
    '
    Dim dateStartStr As String = startD.Date.ToShortDateString()
    Dim dateEndStr As String = endD.Date.ToShortDateString()
    If dateStartStr <> dateEndStr Then
      orderInfo &= "Car will be sent between" & Chr(10) & dateStartStr & " and" & Chr(10) & dateEndStr
    Else
      orderInfo &= "Car will be sent on" & Chr(10) + dateStartStr
      ' they picked a single date.
    End If
    ' Set order info.
    infoLabel.Text = orderInfo
  End Sub
#End Region

  Private Sub groupBoxColor_Enter(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles groupBoxColor.Enter
    groupBoxColor.Text = "Exterior Color: You are in the group..."
  End Sub

  Private Sub groupBoxColor_Leave(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles groupBoxColor.Leave
    groupBoxColor.Text = "Exterior Color: Thanks for visiting the group..."
  End Sub
End Class
