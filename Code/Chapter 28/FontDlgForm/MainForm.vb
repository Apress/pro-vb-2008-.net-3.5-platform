Option Explicit On
Option Strict On

Public Class MainForm
    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CenterToScreen()
    End Sub
    Private fontDlg As New FontDialog()
    Private currFont As New Font("Times New Roman", 12)

    Private Sub MainForm_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If fontDlg.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            currFont = fontDlg.Font
            Me.Text = String.Format("Selected Font: {0} ", currFont)
            Invalidate()
        End If
    End Sub

    Private Sub MainForm_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        g.DrawString("Testing...", currFont, Brushes.Black, 0, 0)
    End Sub
End Class
