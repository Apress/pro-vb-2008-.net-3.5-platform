Option Explicit On
Option Strict On

Imports MyCodeLibrary.MyTypes.MyEnums

' A type alias!
Imports TypeIWant = MyCodeLibrary.MyTypes.SomeClass

Public Class Class2
    Public Sub MySub()
        Dim e As TestEnum

        ' 's' is now of type MyCodeLibrary.MyTypes.SomeClass
        Dim s As New TypeIWant

        ' Use the object test bench to invoke this member
        ' to verify. 
        MsgBox(s.GetType().FullName)
    End Sub
End Class
