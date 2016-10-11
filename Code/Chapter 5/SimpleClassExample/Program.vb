' This project examines the basics of class design and usage 
' (Constructors, the New keyword and the Me keyword).

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Class Types *****")

    ' Allocate and configure a Car object.
    Dim myCar As New Car()
    myCar.petName = "Henry"
    myCar.currSpeed = 10

    ' Speed up the car a few times and print out the
    ' new state.
    For i As Integer = 0 To 10
      myCar.SpeedUp(5)
      myCar.PrintState()
    Next
    Console.WriteLine()

    ' Make a Car called Chuck going 10 MPH.
    Dim chuck As New Car()
    chuck.PrintState()

    ' Make a Car called Mary going 0 MPH.
    Dim mary As New Car("Mary")
    mary.PrintState()

    ' Make a Car called Daisy going 75 MPH.
    Dim daisy As New Car("Daisy", 75)
    daisy.PrintState()
    Console.WriteLine()

    ' Make a Motorcycle.
    Dim c As New Motorcycle(5)
    c.SetDriverName("Tiny")
    c.PopAWheely()
    Console.WriteLine("Rider name is {0}", c.driverName)
    Console.ReadLine()
  End Sub
End Module
