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
        Me.ancBotLeft = New System.Windows.Forms.MenuItem
        Me.ancBotRight = New System.Windows.Forms.MenuItem
        Me.ancRight = New System.Windows.Forms.MenuItem
        Me.ancTopRight = New System.Windows.Forms.MenuItem
        Me.mnuDock = New System.Windows.Forms.MenuItem
        Me.dockTop = New System.Windows.Forms.MenuItem
        Me.dockBottom = New System.Windows.Forms.MenuItem
        Me.dockLeft = New System.Windows.Forms.MenuItem
        Me.dockRight = New System.Windows.Forms.MenuItem
        Me.dockFill = New System.Windows.Forms.MenuItem
        Me.dockNone = New System.Windows.Forms.MenuItem
        Me.btnTheButton = New System.Windows.Forms.Button
        Me.ancBottom = New System.Windows.Forms.MenuItem
        Me.ancNone = New System.Windows.Forms.MenuItem
        Me.ancTopLeft = New System.Windows.Forms.MenuItem
        Me.ancTop = New System.Windows.Forms.MenuItem
        Me.mnuAnchor = New System.Windows.Forms.MenuItem
        Me.ancLeft = New System.Windows.Forms.MenuItem
        Me.mnuMainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.SuspendLayout()
        '
        'ancBotLeft
        '
        Me.ancBotLeft.Index = 7
        Me.ancBotLeft.Text = "BottomLeft"
        '
        'ancBotRight
        '
        Me.ancBotRight.Index = 8
        Me.ancBotRight.Text = "BottomRight"
        '
        'ancRight
        '
        Me.ancRight.Index = 3
        Me.ancRight.Text = "Right"
        '
        'ancTopRight
        '
        Me.ancTopRight.Index = 6
        Me.ancTopRight.Text = "TopRight"
        '
        'mnuDock
        '
        Me.mnuDock.Index = 1
        Me.mnuDock.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.dockTop, Me.dockBottom, Me.dockLeft, Me.dockRight, Me.dockFill, Me.dockNone})
        Me.mnuDock.Text = "Dock Value"
        '
        'dockTop
        '
        Me.dockTop.Index = 0
        Me.dockTop.Text = "Top"
        '
        'dockBottom
        '
        Me.dockBottom.Index = 1
        Me.dockBottom.Text = "Bottom"
        '
        'dockLeft
        '
        Me.dockLeft.Index = 2
        Me.dockLeft.Text = "Left"
        '
        'dockRight
        '
        Me.dockRight.Index = 3
        Me.dockRight.Text = "Right"
        '
        'dockFill
        '
        Me.dockFill.Index = 4
        Me.dockFill.Text = "Fill"
        '
        'dockNone
        '
        Me.dockNone.Index = 5
        Me.dockNone.Text = "None"
        '
        'btnTheButton
        '
        Me.btnTheButton.Location = New System.Drawing.Point(169, 98)
        Me.btnTheButton.Name = "btnTheButton"
        Me.btnTheButton.Size = New System.Drawing.Size(120, 40)
        Me.btnTheButton.TabIndex = 1
        Me.btnTheButton.Text = "The Button"
        '
        'ancBottom
        '
        Me.ancBottom.Index = 2
        Me.ancBottom.Text = "Bottom"
        '
        'ancNone
        '
        Me.ancNone.Index = 4
        Me.ancNone.Text = "None"
        '
        'ancTopLeft
        '
        Me.ancTopLeft.Index = 5
        Me.ancTopLeft.Text = "TopLeft"
        '
        'ancTop
        '
        Me.ancTop.Index = 0
        Me.ancTop.Text = "Top"
        '
        'mnuAnchor
        '
        Me.mnuAnchor.Index = 0
        Me.mnuAnchor.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ancTop, Me.ancLeft, Me.ancBottom, Me.ancRight, Me.ancNone, Me.ancTopLeft, Me.ancTopRight, Me.ancBotLeft, Me.ancBotRight})
        Me.mnuAnchor.Text = "Anchor Value"
        '
        'ancLeft
        '
        Me.ancLeft.Index = 1
        Me.ancLeft.Text = "Left"
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAnchor, Me.mnuDock})
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 237)
        Me.Controls.Add(Me.btnTheButton)
        Me.Menu = Me.mnuMainMenu
        Me.Name = "MainForm"
        Me.Text = "Anchoring and Docking Controls"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ancBotLeft As System.Windows.Forms.MenuItem
    Private WithEvents ancBotRight As System.Windows.Forms.MenuItem
    Private WithEvents ancRight As System.Windows.Forms.MenuItem
    Private WithEvents ancTopRight As System.Windows.Forms.MenuItem
    Private WithEvents mnuDock As System.Windows.Forms.MenuItem
    Private WithEvents dockTop As System.Windows.Forms.MenuItem
    Private WithEvents dockBottom As System.Windows.Forms.MenuItem
    Private WithEvents dockLeft As System.Windows.Forms.MenuItem
    Private WithEvents dockRight As System.Windows.Forms.MenuItem
    Private WithEvents dockFill As System.Windows.Forms.MenuItem
    Private WithEvents dockNone As System.Windows.Forms.MenuItem
    Private WithEvents btnTheButton As System.Windows.Forms.Button
    Private WithEvents ancBottom As System.Windows.Forms.MenuItem
    Private WithEvents ancNone As System.Windows.Forms.MenuItem
    Private WithEvents ancTopLeft As System.Windows.Forms.MenuItem
    Private WithEvents ancTop As System.Windows.Forms.MenuItem
    Private WithEvents mnuAnchor As System.Windows.Forms.MenuItem
    Private WithEvents ancLeft As System.Windows.Forms.MenuItem
    Private WithEvents mnuMainMenu As System.Windows.Forms.MainMenu

End Class
