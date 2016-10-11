Option Explicit On
Option Strict On

Imports System.Resources
Imports System.Reflection

Public Class MainForm
    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CenterToScreen()
    End Sub

    Private Sub btnLoadResources_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs) Handles btnLoadResources.Click
        ' Make a resource manager.
        Dim rm As ResourceManager = _
        New ResourceManager("MyResourcesWinApp.MyResources", Assembly.GetExecutingAssembly())
        ' Get the embedded string (case sensitive!)
        MessageBox.Show(rm.GetString("WelcomeString"))
        ' Get the embedded bitmap (case sensitive!)
        myPictureBox.Image = CType(rm.GetObject("HappyDude"), Bitmap)
        ' Clean up.
        rm.ReleaseAllResources()
    End Sub
End Class
