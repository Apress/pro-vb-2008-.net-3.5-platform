Option Explicit On
Option Strict On

Public Class MainWindow

#Region "Menu Handlers"
  Private Sub newToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newToolStripMenuItem.Click
    ' Make a new child window.
    Dim newChild As New ChildPrototypeForm()

    ' Set the Parent Form of the Child window.
    newChild.MdiParent = Me

    ' Display the new form.
    newChild.Show()
  End Sub

  Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
    Application.Exit()
  End Sub

  Private Sub cascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cascadeToolStripMenuItem.Click
    LayoutMdi(MdiLayout.Cascade)
  End Sub

  Private Sub verticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verticalToolStripMenuItem.Click
    LayoutMdi(MdiLayout.TileVertical)
  End Sub

  Private Sub horizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles horizontalToolStripMenuItem.Click
    LayoutMdi(MdiLayout.TileHorizontal)
  End Sub
#End Region

End Class
