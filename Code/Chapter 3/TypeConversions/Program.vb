' Option directives must be the very first code statements in a *.vb file!
Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** The Amazing Addition Program *****")
    Dim a As Short = 9
    Dim b As Short = 10
    ' Nope...Dim answer As Short = Add(a, b)
    Dim answer As Integer = Add(a, b)
    Console.WriteLine("a + b = {0}", answer)

    Dim myByte As Byte
    Dim myInt As Integer = 200
    myByte = CByte(myInt)
    myByte = CType(myInt, Byte)
    myByte = Convert.ToByte(myInt)
    Console.WriteLine("Value of myByte: {0}", myByte)

  End Sub

  Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
    Return x + y
  End Function
End Module
