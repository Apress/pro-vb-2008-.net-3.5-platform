Option Explicit On
Option Strict On

Public Class MainForm

    Private happyBox As PictureBox = New PictureBox()
    Private oldX As Integer, oldY As Integer
    Private isDragging As Boolean
    Private dropRect As Rectangle = New Rectangle(100, 100, 140, 170)

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Configure the PictureBox and add to 
        ' the Form's Controls collection.
        happyBox.SizeMode = PictureBoxSizeMode.StretchImage
        happyBox.Location = New System.Drawing.Point(64, 32)
        happyBox.Size = New System.Drawing.Size(50, 50)
        happyBox.Cursor = Cursors.Hand
        happyBox.Image = New Bitmap("happyDude.bmp")

        ' Add handlers for the following events.
        AddHandler happyBox.MouseDown, AddressOf happyBox_MouseDown
        AddHandler happyBox.MouseUp, AddressOf happyBox_MouseUp
        AddHandler happyBox.MouseMove, AddressOf happyBox_MouseMove
        Controls.Add(happyBox)
    End Sub

#Region "Event handlers"
    Private Sub happyBox_MouseDown(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs)
        isDragging = True
        ' Save the (x, y) of the mouse down click, 
        ' because we need it as an offset when dragging the image.
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub happyBox_MouseMove(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs)
        If isDragging Then
            ' Need to figure new Y value based on where the mouse
            ' down click happened.
            happyBox.Top = happyBox.Top + (e.Y - oldY)
            ' Same deal for X (use oldX as a base line).
            happyBox.Left = happyBox.Left + (e.X - oldX)
        End If
    End Sub

    Private Sub happyBox_MouseUp(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.MouseEventArgs)
        isDragging = False
        ' Is the mouse within the area of the drop rect?
        If dropRect.Contains(happyBox.Bounds) Then
            MessageBox.Show("You win!", "What an amazing test of skill...")
        End If
    End Sub

    Private Sub MainForm_Paint(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ' Draw the drop box.
        Dim g As Graphics = e.Graphics
        g.FillRectangle(Brushes.BlueViolet, dropRect)
        ' Display instructions.
        g.DrawString("Drag the happy guy in here...", _
        New Font("Times New Roman", 25), Brushes.WhiteSmoke, dropRect)
    End Sub
#End Region

End Class
