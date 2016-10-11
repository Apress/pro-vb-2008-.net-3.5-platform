Class MainWindow
End Class

#Region "Custom rendering on the Main Window"
'Class MainWindow
'  Inherits System.Windows.Window
'  ' Our single drawing visual. 
'  Private rectVisual As New DrawingVisual()
'  Private Const NumberOfVisualItems As Integer = 1

'  Public Sub New()
'    InitializeComponent()

'    ' Helper function to create the rectangle. 
'    CreateRectVisual()
'  End Sub

'  Private Sub CreateRectVisual()
'    Using drawCtx As DrawingContext = rectVisual.RenderOpen()
'      ' The top, left, bottom, and right position of the rectangle. 
'      Dim rect As New Rect(50, 50, 105, 55)
'      drawCtx.DrawRectangle(Brushes.AliceBlue, New Pen(Brushes.Blue, 5), rect)
'    End Using

'    ' Register our visual with the object tree,
'    ' to ensure it supports routed events, hit testing, etc.
'    AddVisualChild(rectVisual)
'    AddLogicalChild(rectVisual)
'  End Sub

'  ' Necessary overrides. The WPF graphics system
'  ' will call these to figure out how many items to 
'  ' render and what to render. 
'  Protected Overrides ReadOnly Property VisualChildrenCount() As Integer
'    Get
'      Return NumberOfVisualItems
'    End Get
'  End Property

'  Protected Overrides Function GetVisualChild(ByVal index As Integer) As Visual
'    ' Collection is zero based, so subtract 1.
'    If index <> (NumberOfVisualItems - 1) Then
'      Throw New ArgumentOutOfRangeException("index", "Don't have that visual!")
'    End If
'    Return rectVisual
'  End Function
'End Class
#End Region

