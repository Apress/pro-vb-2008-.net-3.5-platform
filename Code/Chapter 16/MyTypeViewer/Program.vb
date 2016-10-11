Option Explicit On
Option Strict On

Imports System.Reflection

Module Program
  Sub Main()
    Console.WriteLine("***** Welcome to MyTypeViewer *****")
    Dim typeName As String = String.Empty

    Do
      Console.WriteLine()
      Console.WriteLine("Enter a type name to evaluate")
      Console.Write("or enter Q to quit: ")

      ' Get name of type.
      typeName = Console.ReadLine()

      ' Does user want to quit?
      If typeName.ToUpper() = "Q" Then
        Exit Do
      End If

      ' Try to display type
      Try
        Dim t As Type = Type.GetType(typeName)
        Console.WriteLine()
        ListVariousStats(t)
        ListFields(t)
        ListProps(t)
        ListMethods(t)
        ListInterfaces(t)
      Catch
        Console.WriteLine("Sorry, can't find {0}.", typeName)
      End Try
    Loop
  End Sub

#Region "Helper methods"
  ' Display method names of type.
  Public Sub ListMethods(ByVal t As Type)
    Console.WriteLine("***** Methods *****")
    Dim mi As MethodInfo() = t.GetMethods()
    For Each m As MethodInfo In mi
      Dim retVal As String = m.ReturnType.FullName()
      Dim paramInfo As String = "( "
      For Each pi As ParameterInfo In m.GetParameters()
        paramInfo &= String.Format("{0} {1} ", pi.ParameterType, pi.Name)
      Next
      paramInfo &= ")"
      Console.WriteLine("->{0} {1} {2}", retVal, m.Name, paramInfo)
    Next
    Console.WriteLine()
  End Sub

  ' Display field names of type.
  Public Sub ListFields(ByVal t As Type)
    Console.WriteLine("***** Fields *****")
    Dim fi As FieldInfo() = t.GetFields()
    For Each field As FieldInfo In fi
      Console.WriteLine("->{0} ", field.Name)
    Next
    Console.WriteLine()
  End Sub

  ' Display property names of type.
  Public Sub ListProps(ByVal t As Type)
    Console.WriteLine("***** Properties *****")
    Dim pi As PropertyInfo() = t.GetProperties()
    For Each prop As PropertyInfo In pi
      Console.WriteLine("->{0} ", prop.Name)
    Next
    Console.WriteLine()
  End Sub

  ' Display implemented interfaces.
  Public Sub ListInterfaces(ByVal t As Type)
    Console.WriteLine("***** Interfaces *****")
    Dim ifaces As Type() = t.GetInterfaces()
    For Each i As Type In ifaces
      Console.WriteLine("->{0} ", i.Name)
    Next
    Console.WriteLine()
  End Sub

  ' Just for good measure.
  Public Sub ListVariousStats(ByVal t As Type)
    Console.WriteLine("***** Various Statistics *****")
    Console.WriteLine("Base class is: {0} ", t.BaseType)
    Console.WriteLine("Is type abstract? {0} ", t.IsAbstract)
    Console.WriteLine("Is type sealed? {0} ", t.IsSealed)
    Console.WriteLine("Is type generic? {0} ", t.IsGenericTypeDefinition)
    Console.WriteLine("Is type a class type? {0} ", t.IsClass)
    Console.WriteLine()
  End Sub
#End Region

End Module
