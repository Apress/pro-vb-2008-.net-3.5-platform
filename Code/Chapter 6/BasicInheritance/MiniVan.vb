' This class cannot be extended!
Public NotInheritable Class MiniVan
  Inherits Car
  ' Here, we can now define members which are unique to 
  ' the MiniVan type.
End Class

' Error!  Cannot extend
' a class marked NotInheritable!
'Public Class BetterMiniVan
'    Inherits MiniVan
'End Class
