Imports Vb6ComCarServer

Module Program
  ' Create the COM class using
  ' Early binding.
  Public WithEvents myCar As New CoCar()

  Sub Main()
    Console.WriteLine("***** CoCar Client App *****")

    ' Call the Create() method.
    myCar.Create(50, 10, CarType.BMW)

    ' Set name of driver.
    Dim itf As IDriverInfo
    itf = myCar
    itf.driverName = "Fred"
    Console.WriteLine("Driver is named: {0}", itf.driverName)

    ' Print type of car.
    Console.WriteLine("Your car is a {0}.", myCar.CarMake())
    Console.WriteLine()

    ' Get the Engine and print name of all Cylinders.
    Dim eng As Engine = myCar.GetEngine()
    Console.WriteLine("Your Cylinders are named:")
    Dim names() As String = eng.GetCylinders()
    For Each s As String In names
      Console.WriteLine(s)
    Next
    Console.WriteLine()

    ' Speed up car to trigger event.
    For i As Integer = 0 To 3
      myCar.SpeedUp()
    Next
    Console.ReadLine()
  End Sub

  Private Sub myCar_BlewUp() Handles myCar.BlewUp
    Console.WriteLine("***** Ek!  Car is doomed...! *****")
  End Sub
End Module
