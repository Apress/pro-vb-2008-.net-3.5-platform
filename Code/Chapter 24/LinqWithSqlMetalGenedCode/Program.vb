Imports LinqWithSqlMetalGenedCode.AutoLotDatabase

Module Program
  Const cnStr As String = "Data Source=(local)\SQLEXPRESS;" & _
    "Initial Catalog=AutoLot;Integrated Security=True"

  Sub Main()
    Console.WriteLine("***** More Fun with LINQ to SQL *****" & vbLf)
    Dim carsDB As New AutoLot(cnStr)

    InvokeStoredProc(carsDB)
    PrintOrderForCustomer(carsDB)

    Console.ReadLine()
  End Sub

#Region "Invoke stored proc"
  Sub InvokeStoredProc(ByVal carsDB As AutoLot)
    Dim carID As Integer = 0
    Dim petName As String = ""
    Console.Write("Enter ID: ")
    carID = Integer.Parse(Console.ReadLine())

    ' Invoke stored proc and print out the petname.
    carsDB.GetPetName(carID, petName)
    Console.WriteLine("Car ID {0} has the petname: {1}", carID, petName)
  End Sub
#End Region

#Region "Printer order for customer"
  Sub PrintOrderForCustomer(ByVal carsDB As AutoLot)
    Dim custID As Integer = 0
    Console.Write("Enter customer ID: ")
    custID = Integer.Parse(Console.ReadLine())

    Dim customerOrders = _
    From cust In carsDB.Customers _
    From o In cust.Orders _
    Where cust.CustID = custID _
    Select New With {cust, o}

    Console.WriteLine("***** Order Info for Customer ID: {0}. *****", custID)
    For Each q In customerOrders

      Console.WriteLine("{0} {1} is order ID # {2}.", _
        q.cust.FirstName.Trim(), _
        q.cust.LastName.Trim(), _
        q.o.OrderID)
      Console.WriteLine("{0} bought Car ID # {1}.", _
        q.cust.FirstName.Trim(), q.o.CarID)
    Next
    Console.WriteLine("customerOrders as a string: {0}", customerOrders)
  End Sub
#End Region

End Module
