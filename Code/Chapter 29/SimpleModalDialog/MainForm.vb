Option Explicit On
Option Strict On

Public Class MainForm
    Private userMessage As String = "Default Message"
    Private textIsItalic As Boolean = False

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CenterToScreen()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub configureToolStripMenuItem_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles configureToolStripMenuItem.Click
        Dim dlg As ItalicUserMessageDialog = New ItalicUserMessageDialog()
        dlg.Message = userMessage
        dlg.Italic = textIsItalic

        ' If user clicked OK button, render his message.
        If Windows.Forms.DialogResult.OK = dlg.ShowDialog() Then
            userMessage = dlg.Message
            textIsItalic = dlg.Italic
            Invalidate()
        End If

        ' Have dialog clean up internal widgets now, rather 
        ' than when the GC destroys the object.
        dlg.Dispose()
    End Sub

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim f As Font = Nothing
        If textIsItalic Then
            f = New Font("Times New Roman", 24, FontStyle.Italic)
        Else
            f = New Font("Times New Roman", 24)
        End If
        g.DrawString(userMessage, f, Brushes.DarkBlue, 50, 50)
    End Sub
End Class
