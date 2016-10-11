<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarControl
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarControl))
        Me.currentImage = New System.Windows.Forms.PictureBox
        Me.imageTimer = New System.Windows.Forms.Timer(Me.components)
        Me.carImages = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.currentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currentImage
        '
        Me.currentImage.Location = New System.Drawing.Point(25, 50)
        Me.currentImage.Name = "currentImage"
        Me.currentImage.Size = New System.Drawing.Size(100, 50)
        Me.currentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.currentImage.TabIndex = 1
        Me.currentImage.TabStop = False
        '
        'imageTimer
        '
        Me.imageTimer.Interval = 200
        '
        'carImages
        '
        Me.carImages.ImageStream = CType(resources.GetObject("carImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.carImages.TransparentColor = System.Drawing.Color.Transparent
        Me.carImages.Images.SetKeyName(0, "Lemon1.bmp")
        Me.carImages.Images.SetKeyName(1, "Lemon2.bmp")
        Me.carImages.Images.SetKeyName(2, "Lemon3.bmp")
        Me.carImages.Images.SetKeyName(3, "AboutToBlow.bmp")
        Me.carImages.Images.SetKeyName(4, "EngineBlown.bmp")
        '
        'CarControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.currentImage)
        Me.Name = "CarControl"
        CType(Me.currentImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents currentImage As System.Windows.Forms.PictureBox
    Private WithEvents imageTimer As System.Windows.Forms.Timer
    Private WithEvents carImages As System.Windows.Forms.ImageList

End Class
