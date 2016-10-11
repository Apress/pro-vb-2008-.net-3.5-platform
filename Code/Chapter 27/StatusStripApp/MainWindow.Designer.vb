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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mainStatusStrip = New System.Windows.Forms.StatusStrip
    Me.toolStripStatusLabelMenuState = New System.Windows.Forms.ToolStripStatusLabel
    Me.toolStripStatusLabelClock = New System.Windows.Forms.ToolStripStatusLabel
    Me.toolStripDropDownButtonDateTime = New System.Windows.Forms.ToolStripDropDownButton
    Me.DayOfTheWeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.CurrentTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.timerDateTimeUpdate = New System.Windows.Forms.Timer(Me.components)
    Me.MenuStrip1.SuspendLayout()
    Me.mainStatusStrip.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(440, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
    Me.FileToolStripMenuItem.Text = "&File"
    '
    'ExitToolStripMenuItem
    '
    Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
    Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
    Me.ExitToolStripMenuItem.Text = "E&xit"
    '
    'HelpToolStripMenuItem
    '
    Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
    Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
    Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
    Me.HelpToolStripMenuItem.Text = "&Help"
    '
    'AboutToolStripMenuItem
    '
    Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
    Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
    Me.AboutToolStripMenuItem.Text = "&About..."
    '
    'mainStatusStrip
    '
    Me.mainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabelMenuState, Me.toolStripStatusLabelClock, Me.toolStripDropDownButtonDateTime})
    Me.mainStatusStrip.Location = New System.Drawing.Point(0, 242)
    Me.mainStatusStrip.Name = "mainStatusStrip"
    Me.mainStatusStrip.Size = New System.Drawing.Size(440, 22)
    Me.mainStatusStrip.TabIndex = 1
    Me.mainStatusStrip.Text = "StatusStrip1"
    '
    'toolStripStatusLabelMenuState
    '
    Me.toolStripStatusLabelMenuState.Name = "toolStripStatusLabelMenuState"
    Me.toolStripStatusLabelMenuState.Size = New System.Drawing.Size(392, 17)
    Me.toolStripStatusLabelMenuState.Spring = True
    Me.toolStripStatusLabelMenuState.TextAlign = System.Drawing.ContentAlignment.TopLeft
    '
    'toolStripStatusLabelClock
    '
    Me.toolStripStatusLabelClock.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
    Me.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock"
    Me.toolStripStatusLabelClock.Size = New System.Drawing.Size(4, 17)
    '
    'toolStripDropDownButtonDateTime
    '
    Me.toolStripDropDownButtonDateTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.toolStripDropDownButtonDateTime.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DayOfTheWeekToolStripMenuItem, Me.CurrentTimeToolStripMenuItem})
    Me.toolStripDropDownButtonDateTime.Image = CType(resources.GetObject("toolStripDropDownButtonDateTime.Image"), System.Drawing.Image)
    Me.toolStripDropDownButtonDateTime.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.toolStripDropDownButtonDateTime.Name = "toolStripDropDownButtonDateTime"
    Me.toolStripDropDownButtonDateTime.Size = New System.Drawing.Size(29, 20)
    Me.toolStripDropDownButtonDateTime.Text = "ToolStripDropDownButton1"
    '
    'DayOfTheWeekToolStripMenuItem
    '
    Me.DayOfTheWeekToolStripMenuItem.Name = "DayOfTheWeekToolStripMenuItem"
    Me.DayOfTheWeekToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
    Me.DayOfTheWeekToolStripMenuItem.Text = "Day of the Week"
    '
    'CurrentTimeToolStripMenuItem
    '
    Me.CurrentTimeToolStripMenuItem.Name = "CurrentTimeToolStripMenuItem"
    Me.CurrentTimeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
    Me.CurrentTimeToolStripMenuItem.Text = "Current Time"
    '
    'timerDateTimeUpdate
    '
    Me.timerDateTimeUpdate.Enabled = True
    Me.timerDateTimeUpdate.Interval = 1000
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(440, 264)
    Me.Controls.Add(Me.mainStatusStrip)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "MainForm"
    Me.Text = "Status Strip App"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.mainStatusStrip.ResumeLayout(False)
    Me.mainStatusStrip.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mainStatusStrip As System.Windows.Forms.StatusStrip
  Friend WithEvents toolStripStatusLabelMenuState As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents toolStripStatusLabelClock As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents toolStripDropDownButtonDateTime As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents CurrentTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DayOfTheWeekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents timerDateTimeUpdate As System.Windows.Forms.Timer

End Class
