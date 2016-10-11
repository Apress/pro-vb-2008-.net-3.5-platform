Option Explicit On
Option Strict On

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with System.Collections *****" & vbLf)
    ArrayListTest()
    Console.WriteLine()
    QueueTest()
    Console.WriteLine()
    StackTest()
    Console.ReadLine()
  End Sub

#Region "ArrayList Test"
  Sub ArrayListTest()
    ' Make ArrayList and add a range of Cars.
    Dim carArList As New ArrayList()
    carArList.AddRange(New Car() {New Car("Fred", 90, 10), _
      New Car("Mary", 100, 50), New Car("MB", 190, 11)})
    Console.WriteLine("Items in carArList: {0}", carArList.Count)

    ' Iterate over contents using For / Each.
    For Each c As Car In carArList
      Console.WriteLine("Car pet name: {0}", c.Name)
    Next

    ' Insert new car.
    Console.WriteLine("->Inserting new Car.")
    carArList.Insert(2, New Car("TheNewCar", 0, 12))
    Console.WriteLine("Items in carArList: {0}", carArList.Count)

    ' Get the subobjects as an array.
    Dim arrayOfCars As Object() = carArList.ToArray()
    Dim i As Integer = 0

    ' Now iterate over array using While loop / Length property.
    While i < arrayOfCars.Length
      Console.WriteLine("Car pet name: {0}", CType(arrayOfCars(i), Car).Name)
      i = i + 1
    End While
  End Sub

#End Region

#Region "Queue Test"
  Public Sub WashCar(ByVal c As Car)
    Console.WriteLine("Cleaning {0}", c.Name)
  End Sub

  Sub QueueTest()
    ' Make a Q with three items.
    Dim carWashQ As New Queue()
    carWashQ.Enqueue(New Car("FirstCar", 0, 1))
    carWashQ.Enqueue(New Car("SecondCar", 0, 2))
    carWashQ.Enqueue(New Car("ThirdCar", 0, 3))

    ' Peek at first car in Q.
    Console.WriteLine("First in Q is {0}", _
      CType(carWashQ.Peek(), Car).Name)

    ' Remove each item from Q.
    WashCar(CType(carWashQ.Dequeue(), Car))
    WashCar(CType(carWashQ.Dequeue(), Car))
    WashCar(CType(carWashQ.Dequeue(), Car))

    ' Try to de-Q again?
    Try
      WashCar(CType(carWashQ.Dequeue(), Car))
    Catch ex As Exception
      Console.WriteLine("Error!! {0}", ex.Message)
    End Try
  End Sub
#End Region

#Region "Stack Test"
  Sub StackTest()
    Dim stringStack As New Stack()
    stringStack.Push("One")
    stringStack.Push("Two")
    stringStack.Push("Three")

    ' Now look at the top item, pop it, and look again.
    Console.WriteLine("Top item is: {0}", stringStack.Peek())
    Console.WriteLine("Popped off {0}", stringStack.Pop())
    Console.WriteLine("Top item is: {0}", stringStack.Peek())
    Console.WriteLine("Popped off {0}", stringStack.Pop())
    Console.WriteLine("Top item is: {0}", stringStack.Peek())
    Console.WriteLine("Popped off {0}", stringStack.Pop())

    Try
      Console.WriteLine("Top item is: {0} ", stringStack.Peek())
      Console.WriteLine("Popped off {0} ", stringStack.Pop())
    Catch ex As Exception
      Console.WriteLine("Error!! {0} ", ex.Message)
    End Try
  End Sub

#End Region

End Module
