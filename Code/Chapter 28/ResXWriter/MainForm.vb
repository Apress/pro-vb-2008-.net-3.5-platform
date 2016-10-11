Imports System.Resources

Public Class MainForm

  Private Sub btnGenResX_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnGenResX.Click
    ' Make an resx writer & specify the file to write to.
    Dim w As ResXResourceWriter = New ResXResourceWriter("C:\ResXForm.resx")
    ' Add happy dude & string.
    Dim bMap As Bitmap = New Bitmap("happyDude.bmp")
    w.AddResource("happyDude", bMap)
    w.AddResource("welcomeString", "Hello new resource format!")
    ' Commit it.
    w.Generate()
    w.Close()
  End Sub
End Class
