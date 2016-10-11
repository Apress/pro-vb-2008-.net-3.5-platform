Imports AutoLotConnectedLayer

Module Program

  Sub Main()
    Console.WriteLine("***** Simple Transaction Example *****" & vbLf)

    ' A simple way to allow the tx to work or not.
    Dim throwEx As Boolean = True
    Dim userAnswer As String = String.Empty

    Console.Write("Do you want to throw an exception (Y or N): ")
    userAnswer = Console.ReadLine()
    If userAnswer.ToLower() = "n" Then
      throwEx = False
    End If

    Dim dal As New InventoryDAL()
    dal.OpenConnection("Data Source=(local);Integrated Security=SSPI;" & _
                       "Initial Catalog=AutoLot")

    ' Process customer 999.
    dal.ProcessCreditRisk(throwEx, 333)
    Console.ReadLine()
  End Sub

End Module
