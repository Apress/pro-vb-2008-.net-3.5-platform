Option Explicit On
Option Strict On

Imports System.Xml.Serialization

<Serializable()> _
Public Class Radio
  Public hasTweeters As Boolean
  Public hasSubWoofers As Boolean
  Public stationPresets As Double()
  <NonSerialized()> _
  Public radioID As String = "XF-552RR6"
End Class

<Serializable()> _
Public Class Car
  Public theRadio As Radio = New Radio
  Public isHatchBack As Boolean
End Class

<Serializable(), XmlRoot(Namespace:="http://www.intertechtraining.com")> _
Public Class JamesBondCar
  Inherits Car

  Public Sub New(ByVal SkyWorthy As Boolean, ByVal SeaWorthy As Boolean)
    canFly = SkyWorthy
    canSubmerge = SeaWorthy
  End Sub

  Public Sub New()
  End Sub
  <XmlAttribute()> _
  Public canFly As Boolean
  <XmlAttribute()> _
  Public canSubmerge As Boolean
End Class


