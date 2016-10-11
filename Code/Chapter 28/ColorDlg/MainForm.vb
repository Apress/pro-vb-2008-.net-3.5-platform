Option Explicit On
Option Strict On

Public Class MainForm
    Private colorDlg As ColorDialog
    Private currColor As Color = Color.DimGray

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CenterToScreen()
        colorDlg = New ColorDialog()
        Text = "Click on me to change the color"
    End Sub

    Private Sub MainForm_MouseDown(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs) _
    Handles MyBase.MouseDown
        If colorDlg.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            currColor = colorDlg.Color
            Me.BackColor = currColor
            ' Show current color.
            Dim strARGB As String = colorDlg.Color.ToString()
            MessageBox.Show(strARGB, "Color is:")
        End If
    End Sub
End Class
