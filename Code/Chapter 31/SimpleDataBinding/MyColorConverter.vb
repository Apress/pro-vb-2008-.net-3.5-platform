Class MyColorConverter
  Implements IValueConverter
  Public Function Convert(ByVal value As Object, _
                          ByVal targetType As Type, _
                          ByVal parameter As Object, _
                          ByVal culture As System.Globalization.CultureInfo) As Object _
                          Implements IValueConverter.Convert
    ' Use value of thumb to build a varied green brush.
    Dim d As Double = CDbl(value)
    Dim v As Byte = CByte(d)

    Dim color As New Color()
    color.A = 255
    color.G = CByte((155 + v))
    Return New SolidColorBrush(color)
  End Function

  Public Function ConvertBack(ByVal value As Object, _
                              ByVal targetType As Type, _
                              ByVal parameter As Object, _
                              ByVal culture As System.Globalization.CultureInfo) As Object _
                              Implements IValueConverter.ConvertBack
    Return value
  End Function
End Class
