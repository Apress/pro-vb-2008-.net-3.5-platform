Option Explicit On
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Strongly Typed Collections *****")
    Console.WriteLine()

    Dim myPeople As New PeopleCollection()
    myPeople.AddPerson(New Person("Homer", "Simpson", 40))
    myPeople.AddPerson(New Person("Marge", "Simpson", 38))
    myPeople.AddPerson(New Person("Lisa", "Simpson", 9))
    myPeople.AddPerson(New Person("Bart", "Simpson", 7))
    myPeople.AddPerson(New Person("Maggie", "Simpson", 2))

    ' This would be a compile-time error!
    ' Uncomment line below to test.
    ' myPeople.AddPerson(New Car)

    For Each p As Person In myPeople
      Console.WriteLine(p)
    Next

    ' Use the generic List type to hold only people.
    Dim morePeople As New List(Of Person)
    morePeople.Add(New Person())

    ' Use the generic List type to hold only cars.
    Dim moreCars As New List(Of Car)
    moreCars.Add(New Car())

    ' Compile-time error!
    ' Uncomment line below to test.
    ' moreCars.Add(New Person())

    ' Get / Set new Person object using type indexer.
    myPeople(5) = New Person("Waylon", "Smithers", 47)
    Console.WriteLine("Person #5 is {0}", myPeople(5))

    Console.ReadLine()

  End Sub
End Module
