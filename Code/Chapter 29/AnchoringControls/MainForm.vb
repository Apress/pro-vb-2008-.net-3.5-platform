Option Explicit On
Option Strict On

Public Class MainForm

#Region "Menu handlers"
    Private Sub ancTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancTop.Click
        btnTheButton.Anchor = AnchorStyles.Top
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancLeft.Click
        btnTheButton.Anchor = AnchorStyles.Left
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancBottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancBottom.Click
        btnTheButton.Anchor = AnchorStyles.Bottom
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancRight.Click
        btnTheButton.Anchor = AnchorStyles.Right
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancNone.Click
        btnTheButton.Anchor = AnchorStyles.None
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancTopLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancTopLeft.Click
        btnTheButton.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancTopRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancTopRight.Click
        btnTheButton.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancBotLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancBotLeft.Click
        btnTheButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub ancBotRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ancBotRight.Click
        btnTheButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub dockTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dockTop.Click
        btnTheButton.Dock = DockStyle.Top
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub dockBottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dockBottom.Click
        btnTheButton.Dock = DockStyle.Bottom
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub dockLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dockLeft.Click
        btnTheButton.Dock = DockStyle.Left
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub dockRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dockRight.Click
        btnTheButton.Dock = DockStyle.Right
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub dockFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dockFill.Click
        btnTheButton.Dock = DockStyle.Fill
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub

    Private Sub dockNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dockNone.Click
        btnTheButton.Dock = DockStyle.None
        btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() + "" & Chr(10) & "Dock: " + btnTheButton.Dock.ToString()
    End Sub
#End Region

End Class
