Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Anonymous Types *****")

    ' Make an anonymous type representing a car.
    Dim myCar = New With {.Color = "Bright Pink", .Make = "Saab", .CurrentSpeed = 55}
    myCar.Color = "Black"

    ' Now show the color and make.
    Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make)

    ' Reflect over what the compiler generated.
    ReflectOverAnonymousType(myCar)
    Console.WriteLine()
    CompositeAnonymousType()
    Console.WriteLine()
    EqualityTest()
    Console.ReadLine()
  End Sub

  Sub ReflectOverAnonymousType(ByVal obj As Object)
    Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name)
    Console.WriteLine("Base class of {0} is {1}", _
      obj.GetType().Name, _
      obj.GetType().BaseType)
    Console.WriteLine("obj.ToString() = {0}", obj.ToString())
    Console.WriteLine("obj.GetHashCode() = {0}", obj.GetHashCode())
    Console.WriteLine()
  End Sub

#Region "Test for equality"
  Sub EqualityTest()

    ' Make 2 anonymous classes with identical name/value pairs.
    Dim firstCar = New With {.Color = "Bright Pink", .Make = "Saab", .CurrentSpeed = 55}
    Dim secondCar = New With {.Color = "Bright Pink", .Make = "Saab", .CurrentSpeed = 55}

    ' Are they considered equal when using Equals()?
    If (firstCar.Equals(secondCar)) Then
      Console.WriteLine("Same anonymous object!")
    Else
      Console.WriteLine("Not the same anonymous object!")
    End If

    ' Error!!  No overloaded = operator for anonymous types!
    'If (firstCar = secondCar) Then
    'Console.WriteLine("Same anonymous object!")
    'Else
    'Console.WriteLine("Not the same anonymous object!")
    'End If

    ' Are these objects the same underlying type?
    If (firstCar.GetType().Name = secondCar.GetType().Name) Then
      Console.WriteLine("We are both the same type!")
    Else
      Console.WriteLine("We are different types!")
    End If

    ' Show all the details.
    Console.WriteLine()
    ReflectOverAnonymousType(firstCar)
    ReflectOverAnonymousType(secondCar)
  End Sub
#End Region

  Sub CompositeAnonymousType()
    ' Make an anonymous type that is composed of another.
    Dim purchaseItem = New With { _
      .TimeBought = DateTime.Now, _
      .ItemBought = New With {.Color = "Red", .Make = "Saab", .CurrentSpeed = 55}, _
      .Price = 34.0}

    ReflectOverAnonymousType(purchaseItem)
  End Sub
End Module
