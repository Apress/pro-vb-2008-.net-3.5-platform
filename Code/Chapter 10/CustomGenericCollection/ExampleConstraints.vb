Option Explicit On
Option Strict On

' Contained items must have a default ctor.
Public Class MyGenericClass(Of T As New)
End Class

' Contained items must implement ICloneable 
' and support a default ctor.
Public Class MyGenericClass2(Of T As {ICloneable, New})
End Class

' MyGenericClass derives from SomBaseClass and implements ISomeInterface,
' while the contained items must be structures. 
Public Class MyGenericClass3(Of T As Structure)
  Inherits SomeBaseClass
  Implements ISomeInterface
End Class

' (Of K) must have a default ctor, while (Of T) must
' implement the generic IComparable interface.
Public Class MyGenericClass(Of K As New, T As IComparable(Of T))
End Class

#Region "Just so the previous code compiles..."
Public Class SomeBaseClass
End Class

Public Interface ISomeInterface
End Interface
#End Region
