<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
    Me.menuStrip1 = New System.Windows.Forms.MenuStrip
    Me.fileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.windowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.arrangeWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.cascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.verticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.horizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.menuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'menuStrip1
    '
    Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem1, Me.windowToolStripMenuItem, Me.arrangeWindowsToolStripMenuItem})
    Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.menuStrip1.MdiWindowListItem = Me.windowToolStripMenuItem
    Me.menuStrip1.Name = "menuStrip1"
    Me.menuStrip1.Size = New System.Drawing.Size(292, 24)
    Me.menuStrip1.TabIndex = 3
    Me.menuStrip1.Text = "menuStrip1"
    '
    'fileToolStripMenuItem1
    '
    Me.fileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.exitToolStripMenuItem})
    Me.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1"
    Me.fileToolStripMenuItem1.Size = New System.Drawing.Size(35, 20)
    Me.fileToolStripMenuItem1.Text = "&File"
    '
    'newToolStripMenuItem
    '
    Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
    Me.newToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.newToolStripMenuItem.Text = "&New"
    '
    'exitToolStripMenuItem
    '
    Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
    Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.exitToolStripMenuItem.Text = "E&xit"
    '
    'windowToolStripMenuItem
    '
    Me.windowToolStripMenuItem.Name = "windowToolStripMenuItem"
    Me.windowToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
    Me.windowToolStripMenuItem.Text = "&Window"
    '
    'arrangeWindowsToolStripMenuItem
    '
    Me.arrangeWindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cascadeToolStripMenuItem, Me.verticalToolStripMenuItem, Me.horizontalToolStripMenuItem})
    Me.arrangeWindowsToolStripMenuItem.Name = "arrangeWindowsToolStripMenuItem"
    Me.arrangeWindowsToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
    Me.arrangeWindowsToolStripMenuItem.Text = "&Arrange Windows"
    '
    'cascadeToolStripMenuItem
    '
    Me.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem"
    Me.cascadeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.cascadeToolStripMenuItem.Text = "&Cascade"
    '
    'verticalToolStripMenuItem
    '
    Me.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem"
    Me.verticalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.verticalToolStripMenuItem.Text = "&Vertical"
    '
    'horizontalToolStripMenuItem
    '
    Me.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem"
    Me.horizontalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.horizontalToolStripMenuItem.Text = "&Horizontal"
    '
    'MainWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(292, 266)
    Me.Controls.Add(Me.menuStrip1)
    Me.IsMdiContainer = True
    Me.Name = "MainWindow"
    Me.Text = "Simple MDI App"
    Me.menuStrip1.ResumeLayout(False)
    Me.menuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
  Private WithEvents fileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents windowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents arrangeWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents cascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents verticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents horizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
