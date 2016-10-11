Option Explicit On
Option Strict On

#Region "The Rectangle"
Public Structure Rectangle
    ' Public for ease of use; 
    ' however, feel free to encapsulate with properties.  
    Public Width As Integer, Height As Integer
    Public Sub Draw()
        Console.WriteLine("Drawing a rect.")
    End Sub
    Public Overloads Overrides Function ToString() As String
        Return String.Format("[Width = {0}; Height = {1}]", Width, Height)
    End Function

    Public Shared Widening Operator CType(ByVal s As Square) As Rectangle
        Dim r As Rectangle
        r.Height = s.Length

        ' Assume the length of the new Rectangle with 
        ' (Length x 2)
        r.Width = s.Length * 2
        Return r
    End Operator
End Structure
#End Region

#Region "The Square"
Public Structure Square
    Public Length As Integer
    Public Sub Draw()
        Console.WriteLine("Drawing a square.")
    End Sub
    Public Overloads Overrides Function ToString() As String
        Return String.Format("[Length = {0}]", Length)
    End Function

    ' Rectangles can be explicitly converted
    ' into Squares.
    Public Shared Narrowing Operator CType(ByVal r As Rectangle) As Square
        Dim s As Square
        s.Length = r.Width
        Return s
    End Operator

    ' Can call as:
    ' Dim sq2 As Square = CType(90, Square)
    ' or as:
    ' Dim sq2 As Square = 90 
    Public Shared Widening Operator CType(ByVal sideLength As Integer) As Square
        Dim newSq As Square
        newSq.Length = sideLength
        Return newSq
    End Operator

    ' Must call as:
    ' Dim side As Integer = CType(mySquare, Square)
    Public Shared Narrowing Operator CType(ByVal s As Square) As Integer
        Return s.Length
    End Operator
End Structure
#End Region
