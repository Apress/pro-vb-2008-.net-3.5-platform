' This project illustrates the use of encapsulation
' services (the first pillar of OOP).
Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Encapsulation *****")
    Console.WriteLine("These folks work at {0}", Employee.Company)

    Dim emp As New Employee("Marvin", 24, 456, 30000, "111-11-1111")
    emp.GiveBonus(1000)
    emp.DisplayStats()

    Console.ReadLine()
  End Sub

End Module
