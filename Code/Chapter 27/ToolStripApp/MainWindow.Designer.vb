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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
    Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.toolStripTextBoxMessage = New System.Windows.Forms.ToolStripTextBox
    Me.toolStrip1 = New System.Windows.Forms.ToolStrip
    Me.toolStripButtonGrowFont = New System.Windows.Forms.ToolStripButton
    Me.toolStripButtonShrinkFont = New System.Windows.Forms.ToolStripButton
    Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel
    Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel
    Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel
    Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel
    Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel
    Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer
    Me.toolStrip1.SuspendLayout()
    Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
    Me.toolStripContainer1.SuspendLayout()
    Me.SuspendLayout()
    '
    'toolStripSeparator1
    '
    Me.toolStripSeparator1.Name = "toolStripSeparator1"
    Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'toolStripTextBoxMessage
    '
    Me.toolStripTextBoxMessage.Name = "toolStripTextBoxMessage"
    Me.toolStripTextBoxMessage.Size = New System.Drawing.Size(100, 25)
    Me.toolStripTextBoxMessage.Text = "Enter Message"
    '
    'toolStrip1
    '
    Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButtonGrowFont, Me.toolStripButtonShrinkFont, Me.toolStripSeparator1, Me.toolStripTextBoxMessage})
    Me.toolStrip1.Location = New System.Drawing.Point(3, 0)
    Me.toolStrip1.Name = "toolStrip1"
    Me.toolStrip1.Size = New System.Drawing.Size(197, 25)
    Me.toolStrip1.TabIndex = 0
    Me.toolStrip1.Text = "toolStrip1"
    '
    'toolStripButtonGrowFont
    '
    Me.toolStripButtonGrowFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.toolStripButtonGrowFont.Image = CType(resources.GetObject("toolStripButtonGrowFont.Image"), System.Drawing.Image)
    Me.toolStripButtonGrowFont.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.toolStripButtonGrowFont.Name = "toolStripButtonGrowFont"
    Me.toolStripButtonGrowFont.Size = New System.Drawing.Size(23, 22)
    Me.toolStripButtonGrowFont.Text = "toolStripButton2"
    Me.toolStripButtonGrowFont.ToolTipText = "Grow Font"
    '
    'toolStripButtonShrinkFont
    '
    Me.toolStripButtonShrinkFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.toolStripButtonShrinkFont.Image = CType(resources.GetObject("toolStripButtonShrinkFont.Image"), System.Drawing.Image)
    Me.toolStripButtonShrinkFont.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.toolStripButtonShrinkFont.Name = "toolStripButtonShrinkFont"
    Me.toolStripButtonShrinkFont.Size = New System.Drawing.Size(23, 22)
    Me.toolStripButtonShrinkFont.Text = "toolStripButton1"
    Me.toolStripButtonShrinkFont.ToolTipText = "Shrink Font"
    '
    'BottomToolStripPanel
    '
    Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
    Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
    Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
    Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
    Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
    '
    'TopToolStripPanel
    '
    Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
    Me.TopToolStripPanel.Name = "TopToolStripPanel"
    Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
    Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
    Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
    '
    'RightToolStripPanel
    '
    Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
    Me.RightToolStripPanel.Name = "RightToolStripPanel"
    Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
    Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
    Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
    '
    'LeftToolStripPanel
    '
    Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
    Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
    Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
    Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
    Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
    '
    'ContentPanel
    '
    Me.ContentPanel.AutoScroll = True
    Me.ContentPanel.Size = New System.Drawing.Size(341, 94)
    '
    'toolStripContainer1
    '
    '
    'toolStripContainer1.ContentPanel
    '
    Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(366, 94)
    Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.toolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.toolStripContainer1.Name = "toolStripContainer1"
    Me.toolStripContainer1.Size = New System.Drawing.Size(366, 119)
    Me.toolStripContainer1.TabIndex = 2
    Me.toolStripContainer1.Text = "toolStripContainer1"
    '
    'toolStripContainer1.TopToolStripPanel
    '
    Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip1)
    '
    'MainWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(366, 119)
    Me.Controls.Add(Me.toolStripContainer1)
    Me.Name = "MainWindow"
    Me.Text = "Status Strip App"
    Me.toolStrip1.ResumeLayout(False)
    Me.toolStrip1.PerformLayout()
    Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
    Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
    Me.toolStripContainer1.ResumeLayout(False)
    Me.toolStripContainer1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Private WithEvents toolStripTextBoxMessage As System.Windows.Forms.ToolStripTextBox
  Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
  Private WithEvents toolStripButtonGrowFont As System.Windows.Forms.ToolStripButton
  Private WithEvents toolStripButtonShrinkFont As System.Windows.Forms.ToolStripButton
  Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
  Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
  Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
  Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
  Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
  Private WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer

End Class
