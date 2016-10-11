<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Me.originToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.toolStripMenuItem0by0 = New System.Windows.Forms.ToolStripMenuItem
    Me.toolStripMenuItem5by5 = New System.Windows.Forms.ToolStripMenuItem
    Me.toolStripMenuItem100by100 = New System.Windows.Forms.ToolStripMenuItem
    Me.pointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.documentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.pixelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.unitOfMeasurementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.inchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.milliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.displayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.menuStrip1 = New System.Windows.Forms.MenuStrip
    Me.menuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'originToolStripMenuItem
    '
    Me.originToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem0by0, Me.toolStripMenuItem5by5, Me.toolStripMenuItem100by100})
    Me.originToolStripMenuItem.Name = "originToolStripMenuItem"
    Me.originToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
    Me.originToolStripMenuItem.Text = "Origin"
    '
    'toolStripMenuItem0by0
    '
    Me.toolStripMenuItem0by0.Name = "toolStripMenuItem0by0"
    Me.toolStripMenuItem0by0.Size = New System.Drawing.Size(124, 22)
    Me.toolStripMenuItem0by0.Text = "(0, 0)"
    '
    'toolStripMenuItem5by5
    '
    Me.toolStripMenuItem5by5.Name = "toolStripMenuItem5by5"
    Me.toolStripMenuItem5by5.Size = New System.Drawing.Size(124, 22)
    Me.toolStripMenuItem5by5.Text = "(5, 5)"
    '
    'toolStripMenuItem100by100
    '
    Me.toolStripMenuItem100by100.Name = "toolStripMenuItem100by100"
    Me.toolStripMenuItem100by100.Size = New System.Drawing.Size(124, 22)
    Me.toolStripMenuItem100by100.Text = "(100, 100)"
    '
    'pointToolStripMenuItem
    '
    Me.pointToolStripMenuItem.Name = "pointToolStripMenuItem"
    Me.pointToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
    Me.pointToolStripMenuItem.Text = "Point"
    '
    'documentToolStripMenuItem
    '
    Me.documentToolStripMenuItem.Name = "documentToolStripMenuItem"
    Me.documentToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
    Me.documentToolStripMenuItem.Text = "Document"
    '
    'pixelToolStripMenuItem
    '
    Me.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem"
    Me.pixelToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
    Me.pixelToolStripMenuItem.Text = "Pixel"
    '
    'unitOfMeasurementToolStripMenuItem
    '
    Me.unitOfMeasurementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pixelToolStripMenuItem, Me.inchToolStripMenuItem, Me.milliToolStripMenuItem, Me.displayToolStripMenuItem, Me.documentToolStripMenuItem, Me.pointToolStripMenuItem})
    Me.unitOfMeasurementToolStripMenuItem.Name = "unitOfMeasurementToolStripMenuItem"
    Me.unitOfMeasurementToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
    Me.unitOfMeasurementToolStripMenuItem.Text = "Unit Of Measurement"
    '
    'inchToolStripMenuItem
    '
    Me.inchToolStripMenuItem.Name = "inchToolStripMenuItem"
    Me.inchToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
    Me.inchToolStripMenuItem.Text = "Inch"
    '
    'milliToolStripMenuItem
    '
    Me.milliToolStripMenuItem.Name = "milliToolStripMenuItem"
    Me.milliToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
    Me.milliToolStripMenuItem.Text = "Millimeter"
    '
    'displayToolStripMenuItem
    '
    Me.displayToolStripMenuItem.Name = "displayToolStripMenuItem"
    Me.displayToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
    Me.displayToolStripMenuItem.Text = "Display"
    '
    'menuStrip1
    '
    Me.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.unitOfMeasurementToolStripMenuItem, Me.originToolStripMenuItem})
    Me.menuStrip1.Location = New System.Drawing.Point(0, 145)
    Me.menuStrip1.Name = "menuStrip1"
    Me.menuStrip1.Size = New System.Drawing.Size(402, 24)
    Me.menuStrip1.TabIndex = 1
    Me.menuStrip1.Text = "menuStrip1"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(402, 169)
    Me.Controls.Add(Me.menuStrip1)
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "GDI+ Coordinates"
    Me.menuStrip1.ResumeLayout(False)
    Me.menuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Private WithEvents originToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem0by0 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem5by5 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem100by100 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pointToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents documentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pixelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents unitOfMeasurementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents inchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents milliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents displayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip

End Class
