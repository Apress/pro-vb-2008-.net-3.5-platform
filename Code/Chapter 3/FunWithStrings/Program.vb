Imports System.Text  ' StringBuilder lives here!

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Strings *****")
    Console.WriteLine()

    Dim firstName As String = "June"
    Console.WriteLine("Value of firstName: {0}", firstName)
    Console.WriteLine("firstName has {0} characters.", firstName.Length)
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper())
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower())

    Console.WriteLine()

    Dim myValue As Integer = 3456787

    Console.WriteLine("Hex vaule of myValue is: {0:X}", myValue)
    Console.WriteLine("Currency value of myValue is: {0:C}", myValue)

    Console.WriteLine()

    Dim s1 As String = "Programming the "
    Dim s2 As String = "PsychoDrill (PTP)"
    Dim s3 As String = String.Concat(s1, s2)
    s3 &= vbLf & "was a great industral project."
    Console.WriteLine(s3)

    Console.WriteLine()

    Dim strA As String = "Hello!"
    Dim strB As String = "Yo!"
    ' False!
    Console.WriteLine("strA = strB?: {0}", strA = strB)
    strB = "HELLO!"
    ' False!
    Console.WriteLine("strA = strB?: {0}", strA = strB)
    strB = "Hello!"
    ' True!
    Console.WriteLine("strA = strB?: {0}", strA = strB)

    Console.WriteLine()

    ' Set initial string value
    Dim initialString As String = "This is my string."
    Console.WriteLine("Initial value: {0}", initialString)

    ' Uppercase the initialString?
    Dim upperString As String = initialString.ToUpper()
    Console.WriteLine("Upper case copy: {0}", upperString)

    ' Nope!  initialString is in the same format!
    Console.WriteLine("Initial value: {0}", initialString)

    Console.WriteLine()

    'Dim strObjA As String = "String A reporting."
    'strObjA = "This is a new string"

    ' Use the StringBuilder.
    Dim sb As New StringBuilder("**** Fantastic Games ****")
    sb.Append(vbLf)
    sb.AppendLine("Half Life 2")
    sb.AppendLine("Beyond Good and Evil")
    sb.AppendLine("Deus Ex 1 and 2")
    sb.Append("System Shock")
    sb.Replace("2", "Deus Ex: Invisible War")
    Console.WriteLine(sb)
    Console.WriteLine("sb has {0} chars.", sb.Length)
    Console.ReadLine()
  End Sub
End Module
