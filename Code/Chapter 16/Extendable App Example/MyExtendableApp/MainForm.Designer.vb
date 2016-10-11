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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SnapInModuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.label1 = New System.Windows.Forms.Label
        Me.lstLoadedSnapIns = New System.Windows.Forms.ListBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(383, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SnapInModuleToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SnapInModuleToolStripMenuItem
        '
        Me.SnapInModuleToolStripMenuItem.Name = "SnapInModuleToolStripMenuItem"
        Me.SnapInModuleToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SnapInModuleToolStripMenuItem.Text = "Snap In Module"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 83)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(146, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Here are the loaded Snap Ins"
        '
        'lstLoadedSnapIns
        '
        Me.lstLoadedSnapIns.FormattingEnabled = True
        Me.lstLoadedSnapIns.Location = New System.Drawing.Point(12, 104)
        Me.lstLoadedSnapIns.Name = "lstLoadedSnapIns"
        Me.lstLoadedSnapIns.Size = New System.Drawing.Size(335, 56)
        Me.lstLoadedSnapIns.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 182)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lstLoadedSnapIns)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "My Extendable App!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SnapInModuleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lstLoadedSnapIns As System.Windows.Forms.ListBox

End Class
