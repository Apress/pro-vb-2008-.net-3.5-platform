Partial Public Class AddNewCarDialog

  Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
    DialogResult = True
  End Sub

  Public ReadOnly Property SelectedCar() As Car
    Get
      ' Cast selected item on grid to an XmlElement.
      Dim carRow As System.Xml.XmlElement = _
        DirectCast(lstCars.SelectedItem, System.Xml.XmlElement)

      ' Make sure the user selected something!
      If carRow Is Nothing Then
        Return Nothing
      Else
        ' Generate a random speed.
        Dim r As New Random()
        Dim speed As Integer = r.Next(100)

        ' Return new Car based on the data in selected XmlElement/speed.
        Return New Car(speed, carRow("Make").InnerText, _
                       carRow("Color").InnerText, _
                       carRow("PetName").InnerText)
      End If
    End Get
  End Property
End Class
