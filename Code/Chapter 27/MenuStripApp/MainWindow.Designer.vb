<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.mainFormMenuStrip = New System.Windows.Forms.MenuStrip
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.toolStripTextBoxColor = New System.Windows.Forms.ToolStripTextBox
    Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.HugeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.TinyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mainFormMenuStrip.SuspendLayout()
    Me.ContextMenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'mainFormMenuStrip
    '
    Me.mainFormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.toolStripTextBoxColor})
    Me.mainFormMenuStrip.Location = New System.Drawing.Point(0, 0)
    Me.mainFormMenuStrip.Name = "mainFormMenuStrip"
    Me.mainFormMenuStrip.Size = New System.Drawing.Size(284, 27)
    Me.mainFormMenuStrip.TabIndex = 0
    Me.mainFormMenuStrip.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
    Me.FileToolStripMenuItem.Text = "&File"
    '
    'ExitToolStripMenuItem
    '
    Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
    Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
    Me.ExitToolStripMenuItem.Text = "E&xit"
    '
    'toolStripTextBoxColor
    '
    Me.toolStripTextBoxColor.Name = "toolStripTextBoxColor"
    Me.toolStripTextBoxColor.Size = New System.Drawing.Size(100, 23)
    '
    'ContextMenuStrip1
    '
    Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HugeToolStripMenuItem, Me.NormalToolStripMenuItem, Me.TinyToolStripMenuItem})
    Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 70)
    '
    'HugeToolStripMenuItem
    '
    Me.HugeToolStripMenuItem.Name = "HugeToolStripMenuItem"
    Me.HugeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.HugeToolStripMenuItem.Text = "Huge"
    '
    'NormalToolStripMenuItem
    '
    Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
    Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.NormalToolStripMenuItem.Text = "Normal"
    '
    'TinyToolStripMenuItem
    '
    Me.TinyToolStripMenuItem.Name = "TinyToolStripMenuItem"
    Me.TinyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.TinyToolStripMenuItem.Text = "Tiny"
    '
    'MainWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 264)
    Me.ContextMenuStrip = Me.ContextMenuStrip1
    Me.Controls.Add(Me.mainFormMenuStrip)
    Me.MainMenuStrip = Me.mainFormMenuStrip
    Me.Name = "MainWindow"
    Me.Text = "My Menu App"
    Me.mainFormMenuStrip.ResumeLayout(False)
    Me.mainFormMenuStrip.PerformLayout()
    Me.ContextMenuStrip1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents mainFormMenuStrip As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents toolStripTextBoxColor As System.Windows.Forms.ToolStripTextBox
  Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents HugeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents NormalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents TinyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
