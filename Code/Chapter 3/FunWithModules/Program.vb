Module Program
  Sub Main()
    ' Show banner.
    DisplayBanner()

    ' Get user name and say howdy.
    GreetUser()

    ' Add some numbers.
    Console.WriteLine("10 + 10 is {0}.", Add(10, 10))

    ' Subtract some numbers
    ' (module prefix optional)
    Console.WriteLine("10 - 10 is {0}.", MyMathModule.Subtract(10, 10))

    ' Nope! Error, can't allocated modules!
    ' Dim m As New Module1()

    ' Set userName and call second form of GreetUser().
    UserName = "Fred"
    MyModule.GreetUser()
    Console.ReadLine()

  End Sub

#Region "Helper methods"
  Sub DisplayBanner()
    ' Get the current color of the console text.
    Dim currColor As ConsoleColor = Console.ForegroundColor

    ' Set text color to yellow.
    Console.ForegroundColor = ConsoleColor.Yellow
    Console.WriteLine("******* Welcome to FunWithModules *******")
    Console.WriteLine("This simple program illustrates the role")
    Console.WriteLine("of the Module type.")
    Console.WriteLine("*****************************************")

    ' Reset to previous color of your console text.
    Console.ForegroundColor = currColor
    Console.WriteLine()
  End Sub

  Sub GreetUser()
    Dim userName As String
    Console.Write("Please enter your name: ")
    userName = Console.ReadLine()
    Console.WriteLine("Hello there {0}. Nice to meet ya.", userName)
  End Sub
#End Region

End Module

#Region "Extra Modules"
Module MyModule
  Public UserName As String
  Public Sub GreetUser()
    Console.WriteLine("Hello, {0}.", UserName)
  End Sub
End Module

Module MyMathModule
  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
  Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x - y
  End Function
End Module
#End Region