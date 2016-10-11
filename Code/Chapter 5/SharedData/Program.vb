' This project illustrates the use of shared data and
' shared constructors.

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Shared Data *****")
    SavingsAccount.SetInterestRate(0.09)
    Dim s1 As New SavingsAccount(50)
    Dim s2 As New SavingsAccount(100)

    ' All three lines print out "Interest Rate is: 0.09"
    Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj())
    Console.WriteLine("Interest Rate is: {0}", s2.GetInterestRateObj())
    Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate())
    Console.ReadLine()
  End Sub

End Module
