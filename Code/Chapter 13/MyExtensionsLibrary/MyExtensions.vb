Imports System.Runtime.CompilerServices

#Region "MyExtensions module"
Public Module MyExtensions

  '' This method allows any object to display the assembly
  '' it is defined in.
  '<Extension()> _
  'Public Sub DisplayDefiningAssembly(ByVal obj As Object)
  '  Console.WriteLine("{0} lives here: {1}", obj.GetType().Name, _
  '    obj.GetType().Assembly)
  '  Console.WriteLine()
  'End Sub

  ' This version takes a booelan argument when calling the method.
  <Extension()> _
  Public Sub DisplayDefiningAssembly(ByVal obj As Object, Optional ByVal showDetails As Boolean = False)
    Console.WriteLine("Defining Assembly:  {0}", obj.GetType().Assembly)

    If showDetails Then
      Console.WriteLine("Name of type: {0}", obj.GetType().Name)
      Console.WriteLine("Parent of type: {0}", obj.GetType().BaseType)
      Console.WriteLine("Is generic?: {0}", obj.GetType().IsGenericType)
    End If
  End Sub

  ' This method allows any integer to reverse its digits.
  ' For example, 56 would return 65.
  <Extension()> _
  Public Function ReverseDigits(ByVal i As Integer) As Integer
    ' Translate int into a string, and then
    ' get all the characters.
    Dim digits() As Char = i.ToString().ToCharArray()

    ' Now reverse items in the array.
    Array.Reverse(digits)

    ' Put back into string.
    Dim newDigits As String = New String(digits)

    ' Finally, return the modified string back as an int.
    Return Integer.Parse(newDigits)
  End Function
End Module
#End Region
