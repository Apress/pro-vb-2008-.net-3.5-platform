Option Strict On 
''''''''''''''''''''''''''''''''''''''''''''''''''''
' This program illustrates how to define and 
' manipulate Enum types.
''''''''''''''''''''''''''''''''''''''''''''''''''''
' Build an alias to System.Enum
Imports DotNetEnum = System.Enum

#Region "Enum definition"
' A custom enumeration.
' Elements of an enumeration need not be sequential!
' This time, EmpType maps to an underlying Byte.
Enum EmpType As Byte
  Manager = 10
  Grunt = 1
  Contractor = 100
  VicePresident = 9
End Enum
#End Region

Module Program
  Sub Main()
    Console.WriteLine("**** Fun with Enums *****")
    Dim emp As EmpType
    emp = EmpType.Contractor
    ' Prints out "Contractor = 100".
    Console.WriteLine("{0} = {1}", emp.ToString(), CInt(emp))

    Dim e2 As EmpType
    Dim day As DayOfWeek
    Dim cc As ConsoleColor
    EvaluateEnum(e2)
    EvaluateEnum(day)
    EvaluateEnum(cc)
  End Sub

#Region "Evaulate enum"
  ' This method will print out the details of any enum.
  Sub EvaluateEnum(ByVal e As [Enum])
    Console.WriteLine("=> Information about {0}", e.GetType().Name)

    Console.WriteLine("Underlying storage type: {0}", _
      [Enum].GetUnderlyingType(e.GetType()))

    ' Get all name / value pairs for incoming parameter.
    Dim enumData As Array = [Enum].GetValues(e.GetType())
    Console.WriteLine("This enum has {0} members.", enumData.Length)

    ' Now show the string name and associated value.
    For i As Integer = 0 To enumData.Length - 1
      Console.WriteLine("Name: {0}, Value: {1}", enumData.GetValue(i).ToString(), CInt(enumData.GetValue(i)))
    Next
    Console.WriteLine()
  End Sub
#End Region

#Region "Ask for bonus"
  ' Enums as parameters.
  Sub AskForBonus(ByVal e As EmpType)
    Select Case (e)
      Case EmpType.Contractor
        Console.WriteLine("You already get enough cash...")
      Case EmpType.Grunt
        Console.WriteLine("You have got to be kidding...")
      Case EmpType.Manager
        Console.WriteLine("How about stock options instead?")
      Case EmpType.VicePresident
        Console.WriteLine("VERY GOOD, Sir!")
    End Select
  End Sub
#End Region

End Module
