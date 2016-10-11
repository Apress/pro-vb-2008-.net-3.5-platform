Module Program

  Sub Main()
    '' Passing ref types by value.
    'Console.WriteLine("***** Passing Person object by reference *****" & vbLf)
    'Dim fred As Person = New Person("Fred", 12)
    'Console.WriteLine("Before by value call, Person is:")
    'Console.WriteLine(fred)
    'SendAPersonByValue(fred)
    'Console.WriteLine("After by value call, Person is:")
    'Console.WriteLine(fred)
    'Console.ReadLine()

    ' Passing ref types by ref.
    Console.WriteLine("***** Passing Person object by reference *****")
    Dim mel As New Person("Mel", 23)
    Console.WriteLine("Before by ref call, Person is:")
    Console.WriteLine(mel)
    SendAPersonByReference(mel)
    Console.WriteLine("After by ref call, Person is:")
    Console.WriteLine(mel)
    Console.ReadLine()

  End Sub

  Sub SendAPersonByValue(ByVal p As Person)
    ' Change the age of 'p'?
    p.age = 99

    ' Will the caller see this reassignment?
    p = New Person("Nikki", 999)
  End Sub

  Sub SendAPersonByReference(ByRef p As Person)
    ' Change some data of 'p'.
    p.age = 555

    ' 'p' is now pointing to a new object on the heap!
    p = New Person("Nikki", 999)
  End Sub

End Module
