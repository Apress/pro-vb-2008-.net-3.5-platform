Option Strict On

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Lambdas *****")
    TraditionalDelegateSyntax()
    LambdaExpressionSyntax()
    Console.ReadLine()
  End Sub

#Region "Traditional delegate syntax"
  Sub TraditionalDelegateSyntax()
    Dim list As New List(Of Integer)()
    list.AddRange(New Integer() {20, 1, 4, 8, 9, 44})

    ' Create a Predicate(Of T) object for use by the List(Of T).FindAll() method.
    Dim callback As New Predicate(Of Integer)(AddressOf IsEvenNumber)

    ' Call FindAll() passing the delegate object.
    Dim evenNumbers As List(Of Integer) = list.FindAll(callback)

    ' Print out the result set.    
    Console.WriteLine("Here are the even numbers:")
    For Each evenNumber As Integer In evenNumbers
      Console.WriteLine(evenNumber)
    Next
  End Sub

  ' Target for the Predicate(Of T) delegate. 
  Function IsEvenNumber(ByVal i As Integer) As Boolean
    ' Is it an even number?
    Return (i Mod 2) = 0
  End Function
#End Region

#Region "Lambda expression syntax"
  Sub LambdaExpressionSyntax()
    Dim list As New List(Of Integer)()
    list.AddRange(New Integer() {20, 1, 4, 8, 9, 44})

    ' Call FindAll() using a VB lambda. 
    Dim evenNumbers As List(Of Integer) = list.FindAll(Function(i As Integer) (i Mod 2) = 0)

    ' Print out the result set.    
    Console.WriteLine("Here are the even numbers:")
    For Each evenNumber As Integer In evenNumbers
      Console.WriteLine(evenNumber)
    Next
  End Sub
#End Region

End Module
