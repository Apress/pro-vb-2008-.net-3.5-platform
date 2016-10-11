Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Console IO *****")
    ' Echo some information to the console.
    Console.Write("Enter your name: ")
    Dim s As String = Console.ReadLine()
    Console.WriteLine("Hello, {0}", s)
    Console.Write("Enter your age: ")
    s = Console.ReadLine()
    Console.WriteLine("You are {0} years old", s)

    ' Specify string placeholders and values to use at
    ' runtime.
    Dim theInt As Integer = 90
    Dim theDouble As Double = 9.99
    Dim theBool As Boolean = True
    Console.WriteLine("Value of theInt: {0}", theInt)
    Console.WriteLine("theDouble is {0} and theBool is {1}.", _
      theDouble, theBool)

    ' John says...
    Console.WriteLine("{0}, Number {0}, Number {0}", 9)

    ' Prints: 20, 10, 30
    Console.WriteLine("{1}, {0}, {2}", 10, 20, 30)

    ' Various formatting options.
    Console.WriteLine("C format: {0:C}", 99989.987)
    Console.WriteLine("D9 format: {0:D9}", 99999)
    Console.WriteLine("E format: {0:E}", 99999.76543)
    Console.WriteLine("F3 format: {0:F3}", 99999.9999)
    Console.WriteLine("N format: {0:N}", 99999)
    Console.WriteLine("X format: {0:X}", 99999)
    Console.WriteLine("x format: {0:x}", 99999)

    ' Use the shared String.Format() method to build a new string.
    Dim formatStr As String
    formatStr = _
      String.Format("Don't you wish you had {0:C} in your account?", 99989.987)
    Console.WriteLine(formatStr)
  End Sub

End Module
