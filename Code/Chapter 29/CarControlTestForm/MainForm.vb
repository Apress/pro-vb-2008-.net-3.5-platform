Option Explicit On
Option Strict On

Public Class MainForm
    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CenterToScreen()

        lblCurrentSpeed.Text = String.Format("Current Speed: {0} ", Me.myCarControl.Speed.ToString())
        numericUpDownCarSpeed.Value = myCarControl.Speed

        ' Configure the car control.
        myCarControl.Animate = True
        myCarControl.PetName = "Zippy"
    End Sub
    Private Sub myCarControl_AboutToBlow(ByVal msg As System.String) Handles myCarControl.AboutToBlow
        lblEventData.Text = String.Format("Event Data: {0} ", msg)
    End Sub

    Private Sub myCarControl_BlewUp(ByVal msg As System.String) Handles myCarControl.BlewUp
        lblEventData.Text = String.Format("Event Data: {0} ", msg)
    End Sub

    Private Sub numericUpDownCarSpeed_ValueChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles numericUpDownCarSpeed.ValueChanged
        ' Assume the min of this NumericUpDown is 0 and max is 300.       
        Me.myCarControl.Speed = CType(numericUpDownCarSpeed.Value, Integer)
        lblCurrentSpeed.Text = String.Format("Current Speed: {0} ", Me.myCarControl.Speed.ToString())
    End Sub
End Class
