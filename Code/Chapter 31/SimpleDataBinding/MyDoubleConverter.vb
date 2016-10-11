Class MyDoubleConverter
  Implements IValueConverter
  Public Function Convert(ByVal value As Object, ByVal targetType As Type, _
                          ByVal parameter As Object, _
                          ByVal culture As System.Globalization.CultureInfo) As Object _
                          Implements IValueConverter.Convert
    ' Convert the double to an int.
    Dim v As Double = CDbl(value)
    Return CInt(v)
  End Function

  Public Function ConvertBack(ByVal value As Object, _
                              ByVal targetType As Type, _
                              ByVal parameter As Object, _
                              ByVal culture As System.Globalization.CultureInfo) As Object _
                              Implements IValueConverter.ConvertBack
    ' Return the incoming value directly.
    ' this will be used for 2-way bindings.
    ' In our example, when the user tabs
    ' of the TextBlock.
    Return value
  End Function
End Class
