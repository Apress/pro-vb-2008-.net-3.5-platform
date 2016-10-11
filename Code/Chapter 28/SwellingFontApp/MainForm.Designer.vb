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
        Me.components = New System.ComponentModel.Container
        Me.timesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.arialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.listInstalledFontsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.wingDingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.configureToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.swellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.fontFaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.swellTimer = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timesToolStripMenuItem
        '
        Me.timesToolStripMenuItem.Name = "timesToolStripMenuItem"
        Me.timesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.timesToolStripMenuItem.Text = "&Times New Roman"
        '
        'arialToolStripMenuItem
        '
        Me.arialToolStripMenuItem.Name = "arialToolStripMenuItem"
        Me.arialToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.arialToolStripMenuItem.Text = "&Arial"
        '
        'listInstalledFontsToolStripMenuItem
        '
        Me.listInstalledFontsToolStripMenuItem.Name = "listInstalledFontsToolStripMenuItem"
        Me.listInstalledFontsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.listInstalledFontsToolStripMenuItem.Text = "&List Installed Fonts"
        '
        'wingDingsToolStripMenuItem
        '
        Me.wingDingsToolStripMenuItem.Name = "wingDingsToolStripMenuItem"
        Me.wingDingsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.wingDingsToolStripMenuItem.Text = "&WingDings"
        '
        'configureToolStripMenuItem1
        '
        Me.configureToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.swellToolStripMenuItem, Me.fontFaceToolStripMenuItem, Me.listInstalledFontsToolStripMenuItem})
        Me.configureToolStripMenuItem1.Name = "configureToolStripMenuItem1"
        Me.configureToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.configureToolStripMenuItem1.Text = "&Configure"
        '
        'swellToolStripMenuItem
        '
        Me.swellToolStripMenuItem.Name = "swellToolStripMenuItem"
        Me.swellToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.swellToolStripMenuItem.Text = "&Swell?"
        '
        'fontFaceToolStripMenuItem
        '
        Me.fontFaceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.arialToolStripMenuItem, Me.timesToolStripMenuItem, Me.wingDingsToolStripMenuItem})
        Me.fontFaceToolStripMenuItem.Name = "fontFaceToolStripMenuItem"
        Me.fontFaceToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.fontFaceToolStripMenuItem.Text = "&Font Face"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.configureToolStripMenuItem1})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(374, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        '
        'swellTimer
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 162)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "MainForm"
        Me.Text = "Swelling Font App"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents timesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents arialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents listInstalledFontsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents wingDingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents configureToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents swellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents fontFaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents swellTimer As System.Windows.Forms.Timer

End Class
