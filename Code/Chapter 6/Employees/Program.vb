' This example illustrates the details of building 
' class heirarchies.

' We are enabling this option to ensure that we must
' explicitly cast 
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** The Employee Class Hierarchy *****")
    Console.WriteLine()
    ' A better bonus system!
    Dim chucky As New Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000)
    chucky.GiveBonus(300)
    chucky.DisplayStats()
    Console.WriteLine()

    Dim fran As New SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31)
    fran.GiveBonus(200)
    fran.DisplayStats()
    Console.WriteLine()

    ' This method fires the staff ;-)
    FunWithCasting()
    Console.ReadLine()
  End Sub

#Region "Helper methods"
  Sub FunWithCasting()
    ' A Manager "is-a" System.Object.
    Dim frank As Object = _
      New Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5)

    ' A Manager "is-a" Employee too.
    Dim moonUnit As Employee = New Manager("MoonUnit Zappa", 2, 3001, _
        20000, "101-11-1321", 1)

    ' A PTSalesPerson "is-a" SalesPerson.
    Dim jill As SalesPerson = New PTSalesPerson("Jill", 834, 3002, _
        100000, "111-12-1119", 90)

    ' Streamline the staff.
    FireThisPerson(moonUnit)    ' "moonUnit" was declared as an Employee.
    FireThisPerson(jill)        ' "jill" was declared as a SalesPerson.

    ' OK even with Option Strict enabled.
    FireThisPerson(CType(frank, Manager))
  End Sub

  Public Sub FireThisPerson(ByVal emp As Employee)
    If TypeOf emp Is SalesPerson Then
      Console.WriteLine("Lost a sales person named {0}", emp.Name)
      Console.WriteLine("{0} made {1} sale(s)...", emp.Name, _
        CType(emp, SalesPerson).SalesNumber)
      Console.WriteLine()
    End If
    If TypeOf emp Is Manager Then
      Console.WriteLine("Lost a suit named {0}", emp.Name)
      Console.WriteLine("{0} had {1} stock options...", emp.Name, _
        CType(emp, Manager).StockOptions)
      Console.WriteLine()
    End If
  End Sub
#End Region

End Module


