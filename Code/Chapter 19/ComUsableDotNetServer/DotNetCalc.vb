' We need this to obtain the necessary
' interop attributes.
Imports System.Runtime.InteropServices

<ClassInterface(ClassInterfaceType.AutoDual)> _
<Guid("45C738B7-A424-4932-8D75-4BBB6330EB1F")> _
Public Class DotNetCalc
  Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
  Public Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x - y
  End Function
End Class
