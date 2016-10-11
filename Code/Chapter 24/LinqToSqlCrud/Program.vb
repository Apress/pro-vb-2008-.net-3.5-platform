Module Program

  Sub Main()
    Console.WriteLine("***** CRUD with LINQ to SQL *****")

    Dim ctx As New AutoLotObjectsDataContext()
    InsertNewCars(ctx)
    UpdateCar(ctx)
    DeleteCar(ctx)
    Console.ReadLine()
  End Sub

#Region "Insert car"
  Sub InsertNewCars(ByVal ctx As AutoLotObjectsDataContext)

    Console.WriteLine("***** Adding 2 Cars *****")
    Dim newCarID As Integer = 0
    Console.Write("Enter ID for Betty: ")
    newCarID = Integer.Parse(Console.ReadLine())

    ' Add a new row using "longhand" notation.
    Dim newCar As New Inventory()
    newCar.Make = "Yugo"
    newCar.Color = "Pink"
    newCar.PetName = "Betty"
    newCar.CarID = newCarID
    ctx.Inventories.InsertOnSubmit(newCar)
    ctx.SubmitChanges()

    Console.Write("Enter ID for Henry: ")
    newCarID = Integer.Parse(Console.ReadLine())

    ' Add another row using "shorthand" object init syntax.
    newCar = New Inventory With {.Make = "BMW", .Color = "Silver", _
      .PetName = "Henry", .CarID = newCarID}

    ctx.Inventories.InsertOnSubmit(newCar)
    ctx.SubmitChanges()
  End Sub
#End Region

#Region "Update car"
  Sub UpdateCar(ByVal ctx As AutoLotObjectsDataContext)
    Console.WriteLine("***** Updating color of 'Betty' *****")

    ' Update Betty's color to light pink.
    Dim betty = (From c In ctx.Inventories Where _
                (c.PetName = "Betty") Select c).First()
    betty.Color = "Pink"
    ctx.SubmitChanges()
  End Sub
#End Region

#Region "Delete car"
  Sub DeleteCar(ByVal ctx As AutoLotObjectsDataContext)
    Dim carToDelete As Integer = 0
    Console.Write("Enter ID of car to delete: ")
    carToDelete = Integer.Parse(Console.ReadLine())

    ' Remove specified car.
    ctx.Inventories.DeleteOnSubmit((From c In ctx.Inventories _
                            Where c.CarID = carToDelete _
                            Select c).First())
    ctx.SubmitChanges()
  End Sub
#End Region

End Module
