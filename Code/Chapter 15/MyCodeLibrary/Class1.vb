Option Explicit On
Option Strict On

' This type is in the root namespace,
' which is (by default) the same name
' as the initial project. 
Public Class SomeClass
End Class

' This namespace is nested within the 
' root.  Therefore the fully qualified 
' name of this class is MyCodeLibrary.MyTypes.SomeClass
Namespace MyTypes
    Public Class SomeClass
    End Class

    ' It is possible to nest namespaces within other
    ' namespaces to gain a greater level of structure.
    ' Thus, the fully qualified name of this enum is:
    ' MyCodeLibrary.MyTypes.MyEnums.TestEnum
    Namespace MyEnums
        Public Enum TestEnum
            TestValue
        End Enum
    End Namespace
End Namespace
