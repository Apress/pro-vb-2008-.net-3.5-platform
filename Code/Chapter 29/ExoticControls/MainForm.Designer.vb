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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.txtInput = New System.Windows.Forms.TextBox
    Me.lblErrorInstructions = New System.Windows.Forms.Label
    Me.pageErrorProvider = New System.Windows.Forms.TabPage
    Me.btnValidate = New System.Windows.Forms.Button
    Me.btnGetSelections = New System.Windows.Forms.Button
    Me.lblNumericUpDown = New System.Windows.Forms.Label
    Me.lblDomainUpDown = New System.Windows.Forms.Label
    Me.numericUpDown = New System.Windows.Forms.NumericUpDown
    Me.domainUpDown = New System.Windows.Forms.DomainUpDown
    Me.pageTreeView = New System.Windows.Forms.TabPage
    Me.lblNodeInfo = New System.Windows.Forms.Label
    Me.treeViewCars = New System.Windows.Forms.TreeView
    Me.myWebBrowser = New System.Windows.Forms.WebBrowser
    Me.txtUrl = New System.Windows.Forms.TextBox
    Me.lblURL = New System.Windows.Forms.Label
    Me.btnGO = New System.Windows.Forms.Button
    Me.pageWebBrowser = New System.Windows.Forms.TabPage
    Me.tabControlExoticControls = New System.Windows.Forms.TabControl
    Me.pageTrackBars = New System.Windows.Forms.TabPage
    Me.pagePanels = New System.Windows.Forms.TabPage
    Me.panelTextBoxes = New System.Windows.Forms.Panel
    Me.lblInstructions = New System.Windows.Forms.Label
    Me.txtUpperText = New System.Windows.Forms.TextBox
    Me.txtNormalText = New System.Windows.Forms.TextBox
    Me.btnHidePanel = New System.Windows.Forms.Button
    Me.btnShowPanel = New System.Windows.Forms.Button
    Me.pageUpDown = New System.Windows.Forms.TabPage
    Me.lblCurrSel = New System.Windows.Forms.Label
    Me.lblCurrColor = New System.Windows.Forms.Label
    Me.blueTrackBar = New System.Windows.Forms.TrackBar
    Me.lblBlue = New System.Windows.Forms.Label
    Me.lblGreen = New System.Windows.Forms.Label
    Me.greenTrackBar = New System.Windows.Forms.TrackBar
    Me.redTrackBar = New System.Windows.Forms.TrackBar
    Me.lblRed = New System.Windows.Forms.Label
    Me.colorBox = New System.Windows.Forms.PictureBox
    Me.imageListTreeView = New System.Windows.Forms.ImageList(Me.components)
    Me.tooManyCharactersErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.pageErrorProvider.SuspendLayout()
    CType(Me.numericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pageTreeView.SuspendLayout()
    Me.pageWebBrowser.SuspendLayout()
    Me.tabControlExoticControls.SuspendLayout()
    Me.pageTrackBars.SuspendLayout()
    Me.pagePanels.SuspendLayout()
    Me.panelTextBoxes.SuspendLayout()
    Me.pageUpDown.SuspendLayout()
    CType(Me.blueTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.greenTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.redTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.colorBox, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.tooManyCharactersErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtInput
    '
    Me.txtInput.Location = New System.Drawing.Point(196, 72)
    Me.txtInput.Name = "txtInput"
    Me.txtInput.Size = New System.Drawing.Size(181, 20)
    Me.txtInput.TabIndex = 3
    '
    'lblErrorInstructions
    '
    Me.lblErrorInstructions.Font = New System.Drawing.Font("Arial Black", 12.0!)
    Me.lblErrorInstructions.Location = New System.Drawing.Point(45, 8)
    Me.lblErrorInstructions.Name = "lblErrorInstructions"
    Me.lblErrorInstructions.Size = New System.Drawing.Size(376, 56)
    Me.lblErrorInstructions.TabIndex = 2
    Me.lblErrorInstructions.Text = "The following text box only allows 5 characters.  Try to enter more..."
    '
    'pageErrorProvider
    '
    Me.pageErrorProvider.Controls.Add(Me.txtInput)
    Me.pageErrorProvider.Controls.Add(Me.lblErrorInstructions)
    Me.pageErrorProvider.Controls.Add(Me.btnValidate)
    Me.pageErrorProvider.Location = New System.Drawing.Point(4, 22)
    Me.pageErrorProvider.Name = "pageErrorProvider"
    Me.pageErrorProvider.Padding = New System.Windows.Forms.Padding(3)
    Me.pageErrorProvider.Size = New System.Drawing.Size(636, 341)
    Me.pageErrorProvider.TabIndex = 3
    Me.pageErrorProvider.Text = "Error Provider"
    '
    'btnValidate
    '
    Me.btnValidate.Location = New System.Drawing.Point(53, 72)
    Me.btnValidate.Name = "btnValidate"
    Me.btnValidate.Size = New System.Drawing.Size(112, 32)
    Me.btnValidate.TabIndex = 1
    Me.btnValidate.Text = "OK"
    '
    'btnGetSelections
    '
    Me.btnGetSelections.Location = New System.Drawing.Point(53, 136)
    Me.btnGetSelections.Name = "btnGetSelections"
    Me.btnGetSelections.Size = New System.Drawing.Size(136, 24)
    Me.btnGetSelections.TabIndex = 4
    Me.btnGetSelections.Text = "Get Current Selections"
    '
    'lblNumericUpDown
    '
    Me.lblNumericUpDown.Font = New System.Drawing.Font("Verdana", 12.0!)
    Me.lblNumericUpDown.Location = New System.Drawing.Point(45, 80)
    Me.lblNumericUpDown.Name = "lblNumericUpDown"
    Me.lblNumericUpDown.Size = New System.Drawing.Size(221, 32)
    Me.lblNumericUpDown.TabIndex = 3
    Me.lblNumericUpDown.Text = "Numeric UpDown Control"
    '
    'lblDomainUpDown
    '
    Me.lblDomainUpDown.Font = New System.Drawing.Font("Verdana", 12.0!)
    Me.lblDomainUpDown.Location = New System.Drawing.Point(45, 24)
    Me.lblDomainUpDown.Name = "lblDomainUpDown"
    Me.lblDomainUpDown.Size = New System.Drawing.Size(221, 32)
    Me.lblDomainUpDown.TabIndex = 2
    Me.lblDomainUpDown.Text = "Domain UpDown Control"
    '
    'numericUpDown
    '
    Me.numericUpDown.Location = New System.Drawing.Point(272, 80)
    Me.numericUpDown.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
    Me.numericUpDown.Name = "numericUpDown"
    Me.numericUpDown.Size = New System.Drawing.Size(168, 20)
    Me.numericUpDown.TabIndex = 1
    Me.numericUpDown.ThousandsSeparator = True
    Me.numericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
    '
    'domainUpDown
    '
    Me.domainUpDown.Items.Add("Another Selection")
    Me.domainUpDown.Items.Add("Final Selection")
    Me.domainUpDown.Items.Add("Selection One")
    Me.domainUpDown.Items.Add("Third Selection")
    Me.domainUpDown.Location = New System.Drawing.Point(272, 24)
    Me.domainUpDown.Name = "domainUpDown"
    Me.domainUpDown.Size = New System.Drawing.Size(168, 20)
    Me.domainUpDown.Sorted = True
    Me.domainUpDown.TabIndex = 0
    Me.domainUpDown.Text = "Some Item"
    Me.domainUpDown.Wrap = True
    '
    'pageTreeView
    '
    Me.pageTreeView.Controls.Add(Me.lblNodeInfo)
    Me.pageTreeView.Controls.Add(Me.treeViewCars)
    Me.pageTreeView.Location = New System.Drawing.Point(4, 22)
    Me.pageTreeView.Name = "pageTreeView"
    Me.pageTreeView.Padding = New System.Windows.Forms.Padding(3)
    Me.pageTreeView.Size = New System.Drawing.Size(636, 341)
    Me.pageTreeView.TabIndex = 4
    Me.pageTreeView.Text = "Tree View"
    '
    'lblNodeInfo
    '
    Me.lblNodeInfo.AutoSize = True
    Me.lblNodeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblNodeInfo.Location = New System.Drawing.Point(267, 6)
    Me.lblNodeInfo.Name = "lblNodeInfo"
    Me.lblNodeInfo.Size = New System.Drawing.Size(78, 15)
    Me.lblNodeInfo.TabIndex = 1
    Me.lblNodeInfo.Text = "Tree View Info"
    '
    'treeViewCars
    '
    Me.treeViewCars.ImageIndex = 0
    Me.treeViewCars.ImageList = Me.imageListTreeView
    Me.treeViewCars.Location = New System.Drawing.Point(43, 6)
    Me.treeViewCars.Name = "treeViewCars"
    Me.treeViewCars.SelectedImageIndex = 0
    Me.treeViewCars.Size = New System.Drawing.Size(206, 251)
    Me.treeViewCars.TabIndex = 0
    '
    'myWebBrowser
    '
    Me.myWebBrowser.Location = New System.Drawing.Point(45, 37)
    Me.myWebBrowser.Name = "myWebBrowser"
    Me.myWebBrowser.Size = New System.Drawing.Size(585, 298)
    Me.myWebBrowser.TabIndex = 4
    '
    'txtUrl
    '
    Me.txtUrl.Location = New System.Drawing.Point(148, 7)
    Me.txtUrl.Name = "txtUrl"
    Me.txtUrl.Size = New System.Drawing.Size(248, 20)
    Me.txtUrl.TabIndex = 1
    Me.txtUrl.Text = "http://www.intertechtraining.com"
    '
    'lblURL
    '
    Me.lblURL.AutoSize = True
    Me.lblURL.Location = New System.Drawing.Point(44, 7)
    Me.lblURL.Name = "lblURL"
    Me.lblURL.Size = New System.Drawing.Size(101, 13)
    Me.lblURL.TabIndex = 0
    Me.lblURL.Text = "Please Enter a URL"
    '
    'btnGO
    '
    Me.btnGO.Location = New System.Drawing.Point(403, 7)
    Me.btnGO.Name = "btnGO"
    Me.btnGO.Size = New System.Drawing.Size(46, 23)
    Me.btnGO.TabIndex = 3
    Me.btnGO.Text = "Go!"
    '
    'pageWebBrowser
    '
    Me.pageWebBrowser.Controls.Add(Me.btnGO)
    Me.pageWebBrowser.Controls.Add(Me.myWebBrowser)
    Me.pageWebBrowser.Controls.Add(Me.txtUrl)
    Me.pageWebBrowser.Controls.Add(Me.lblURL)
    Me.pageWebBrowser.Location = New System.Drawing.Point(4, 22)
    Me.pageWebBrowser.Name = "pageWebBrowser"
    Me.pageWebBrowser.Padding = New System.Windows.Forms.Padding(3)
    Me.pageWebBrowser.Size = New System.Drawing.Size(636, 341)
    Me.pageWebBrowser.TabIndex = 5
    Me.pageWebBrowser.Text = "Web Browser"
    '
    'tabControlExoticControls
    '
    Me.tabControlExoticControls.Controls.Add(Me.pageTrackBars)
    Me.tabControlExoticControls.Controls.Add(Me.pagePanels)
    Me.tabControlExoticControls.Controls.Add(Me.pageUpDown)
    Me.tabControlExoticControls.Controls.Add(Me.pageErrorProvider)
    Me.tabControlExoticControls.Controls.Add(Me.pageTreeView)
    Me.tabControlExoticControls.Controls.Add(Me.pageWebBrowser)
    Me.tabControlExoticControls.Location = New System.Drawing.Point(11, 16)
    Me.tabControlExoticControls.Name = "tabControlExoticControls"
    Me.tabControlExoticControls.SelectedIndex = 0
    Me.tabControlExoticControls.Size = New System.Drawing.Size(644, 367)
    Me.tabControlExoticControls.TabIndex = 1
    '
    'pageTrackBars
    '
    Me.pageTrackBars.Controls.Add(Me.lblGreen)
    Me.pageTrackBars.Controls.Add(Me.lblRed)
    Me.pageTrackBars.Controls.Add(Me.blueTrackBar)
    Me.pageTrackBars.Controls.Add(Me.lblBlue)
    Me.pageTrackBars.Controls.Add(Me.greenTrackBar)
    Me.pageTrackBars.Controls.Add(Me.redTrackBar)
    Me.pageTrackBars.Controls.Add(Me.lblCurrColor)
    Me.pageTrackBars.Controls.Add(Me.colorBox)
    Me.pageTrackBars.Location = New System.Drawing.Point(4, 22)
    Me.pageTrackBars.Name = "pageTrackBars"
    Me.pageTrackBars.Padding = New System.Windows.Forms.Padding(3)
    Me.pageTrackBars.Size = New System.Drawing.Size(636, 341)
    Me.pageTrackBars.TabIndex = 0
    Me.pageTrackBars.Text = "Track Bars"
    '
    'pagePanels
    '
    Me.pagePanels.Controls.Add(Me.panelTextBoxes)
    Me.pagePanels.Controls.Add(Me.btnHidePanel)
    Me.pagePanels.Controls.Add(Me.btnShowPanel)
    Me.pagePanels.Location = New System.Drawing.Point(4, 22)
    Me.pagePanels.Name = "pagePanels"
    Me.pagePanels.Padding = New System.Windows.Forms.Padding(3)
    Me.pagePanels.Size = New System.Drawing.Size(636, 341)
    Me.pagePanels.TabIndex = 1
    Me.pagePanels.Text = "Panels"
    '
    'panelTextBoxes
    '
    Me.panelTextBoxes.Controls.Add(Me.lblInstructions)
    Me.panelTextBoxes.Controls.Add(Me.txtUpperText)
    Me.panelTextBoxes.Controls.Add(Me.txtNormalText)
    Me.panelTextBoxes.Location = New System.Drawing.Point(148, 7)
    Me.panelTextBoxes.Name = "panelTextBoxes"
    Me.panelTextBoxes.Size = New System.Drawing.Size(294, 187)
    Me.panelTextBoxes.TabIndex = 2
    '
    'lblInstructions
    '
    Me.lblInstructions.AutoSize = True
    Me.lblInstructions.Location = New System.Drawing.Point(41, 9)
    Me.lblInstructions.Name = "lblInstructions"
    Me.lblInstructions.Size = New System.Drawing.Size(126, 13)
    Me.lblInstructions.TabIndex = 2
    Me.lblInstructions.Text = "Enter Some Text below..."
    '
    'txtUpperText
    '
    Me.txtUpperText.Location = New System.Drawing.Point(41, 59)
    Me.txtUpperText.Name = "txtUpperText"
    Me.txtUpperText.Size = New System.Drawing.Size(100, 20)
    Me.txtUpperText.TabIndex = 1
    '
    'txtNormalText
    '
    Me.txtNormalText.Location = New System.Drawing.Point(40, 33)
    Me.txtNormalText.Name = "txtNormalText"
    Me.txtNormalText.Size = New System.Drawing.Size(101, 20)
    Me.txtNormalText.TabIndex = 0
    '
    'btnHidePanel
    '
    Me.btnHidePanel.Location = New System.Drawing.Point(44, 37)
    Me.btnHidePanel.Name = "btnHidePanel"
    Me.btnHidePanel.Size = New System.Drawing.Size(75, 23)
    Me.btnHidePanel.TabIndex = 1
    Me.btnHidePanel.Text = "Hide Panel"
    '
    'btnShowPanel
    '
    Me.btnShowPanel.Location = New System.Drawing.Point(44, 7)
    Me.btnShowPanel.Name = "btnShowPanel"
    Me.btnShowPanel.Size = New System.Drawing.Size(75, 23)
    Me.btnShowPanel.TabIndex = 0
    Me.btnShowPanel.Text = "Show Panel"
    '
    'pageUpDown
    '
    Me.pageUpDown.Controls.Add(Me.lblCurrSel)
    Me.pageUpDown.Controls.Add(Me.btnGetSelections)
    Me.pageUpDown.Controls.Add(Me.lblNumericUpDown)
    Me.pageUpDown.Controls.Add(Me.lblDomainUpDown)
    Me.pageUpDown.Controls.Add(Me.numericUpDown)
    Me.pageUpDown.Controls.Add(Me.domainUpDown)
    Me.pageUpDown.Location = New System.Drawing.Point(4, 22)
    Me.pageUpDown.Name = "pageUpDown"
    Me.pageUpDown.Padding = New System.Windows.Forms.Padding(3)
    Me.pageUpDown.Size = New System.Drawing.Size(636, 341)
    Me.pageUpDown.TabIndex = 2
    Me.pageUpDown.Text = "Up Down Controls"
    '
    'lblCurrSel
    '
    Me.lblCurrSel.BackColor = System.Drawing.Color.Linen
    Me.lblCurrSel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblCurrSel.Location = New System.Drawing.Point(53, 180)
    Me.lblCurrSel.Name = "lblCurrSel"
    Me.lblCurrSel.Size = New System.Drawing.Size(256, 48)
    Me.lblCurrSel.TabIndex = 5
    '
    'lblCurrColor
    '
    Me.lblCurrColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblCurrColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
    Me.lblCurrColor.Location = New System.Drawing.Point(26, 220)
    Me.lblCurrColor.Name = "lblCurrColor"
    Me.lblCurrColor.Size = New System.Drawing.Size(392, 40)
    Me.lblCurrColor.TabIndex = 17
    '
    'blueTrackBar
    '
    Me.blueTrackBar.Location = New System.Drawing.Point(100, 162)
    Me.blueTrackBar.Maximum = 255
    Me.blueTrackBar.Name = "blueTrackBar"
    Me.blueTrackBar.Size = New System.Drawing.Size(310, 45)
    Me.blueTrackBar.TabIndex = 18
    Me.blueTrackBar.TickFrequency = 5
    Me.blueTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
    '
    'lblBlue
    '
    Me.lblBlue.Font = New System.Drawing.Font("Arial", 15.0!)
    Me.lblBlue.Location = New System.Drawing.Point(22, 162)
    Me.lblBlue.Name = "lblBlue"
    Me.lblBlue.Size = New System.Drawing.Size(72, 32)
    Me.lblBlue.TabIndex = 23
    Me.lblBlue.Text = "Blue:"
    '
    'lblGreen
    '
    Me.lblGreen.Font = New System.Drawing.Font("Arial", 15.0!)
    Me.lblGreen.Location = New System.Drawing.Point(22, 122)
    Me.lblGreen.Name = "lblGreen"
    Me.lblGreen.Size = New System.Drawing.Size(72, 32)
    Me.lblGreen.TabIndex = 25
    Me.lblGreen.Text = "Green:"
    '
    'greenTrackBar
    '
    Me.greenTrackBar.Location = New System.Drawing.Point(100, 122)
    Me.greenTrackBar.Maximum = 255
    Me.greenTrackBar.Name = "greenTrackBar"
    Me.greenTrackBar.Size = New System.Drawing.Size(310, 45)
    Me.greenTrackBar.TabIndex = 20
    Me.greenTrackBar.TickFrequency = 5
    Me.greenTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
    '
    'redTrackBar
    '
    Me.redTrackBar.Location = New System.Drawing.Point(100, 82)
    Me.redTrackBar.Maximum = 255
    Me.redTrackBar.Name = "redTrackBar"
    Me.redTrackBar.Size = New System.Drawing.Size(310, 45)
    Me.redTrackBar.TabIndex = 19
    Me.redTrackBar.TickFrequency = 5
    Me.redTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
    '
    'lblRed
    '
    Me.lblRed.Font = New System.Drawing.Font("Arial", 15.0!)
    Me.lblRed.Location = New System.Drawing.Point(22, 77)
    Me.lblRed.Name = "lblRed"
    Me.lblRed.Size = New System.Drawing.Size(72, 32)
    Me.lblRed.TabIndex = 24
    Me.lblRed.Text = "Red:"
    '
    'colorBox
    '
    Me.colorBox.BackColor = System.Drawing.Color.Blue
    Me.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.colorBox.Location = New System.Drawing.Point(26, 18)
    Me.colorBox.Name = "colorBox"
    Me.colorBox.Size = New System.Drawing.Size(384, 56)
    Me.colorBox.TabIndex = 16
    Me.colorBox.TabStop = False
    '
    'imageListTreeView
    '
    Me.imageListTreeView.ImageStream = CType(resources.GetObject("imageListTreeView.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageListTreeView.TransparentColor = System.Drawing.Color.Transparent
    Me.imageListTreeView.Images.SetKeyName(0, "CarNode.bmp")
    Me.imageListTreeView.Images.SetKeyName(1, "SpeedNode.bmp")
    Me.imageListTreeView.Images.SetKeyName(2, "RadioNode.bmp")
    '
    'tooManyCharactersErrorProvider
    '
    Me.tooManyCharactersErrorProvider.BlinkRate = 500
    Me.tooManyCharactersErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
    Me.tooManyCharactersErrorProvider.ContainerControl = Me
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(678, 407)
    Me.Controls.Add(Me.tabControlExoticControls)
    Me.Name = "MainForm"
    Me.Text = "Fun with Exotic Controls"
    Me.pageErrorProvider.ResumeLayout(False)
    Me.pageErrorProvider.PerformLayout()
    CType(Me.numericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pageTreeView.ResumeLayout(False)
    Me.pageTreeView.PerformLayout()
    Me.pageWebBrowser.ResumeLayout(False)
    Me.pageWebBrowser.PerformLayout()
    Me.tabControlExoticControls.ResumeLayout(False)
    Me.pageTrackBars.ResumeLayout(False)
    Me.pageTrackBars.PerformLayout()
    Me.pagePanels.ResumeLayout(False)
    Me.panelTextBoxes.ResumeLayout(False)
    Me.panelTextBoxes.PerformLayout()
    Me.pageUpDown.ResumeLayout(False)
    CType(Me.blueTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.greenTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.redTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.colorBox, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.tooManyCharactersErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
    Private WithEvents txtInput As System.Windows.Forms.TextBox
    Private WithEvents lblErrorInstructions As System.Windows.Forms.Label
    Private WithEvents pageErrorProvider As System.Windows.Forms.TabPage
    Private WithEvents btnValidate As System.Windows.Forms.Button
    Private WithEvents btnGetSelections As System.Windows.Forms.Button
    Private WithEvents lblNumericUpDown As System.Windows.Forms.Label
    Private WithEvents lblDomainUpDown As System.Windows.Forms.Label
    Private WithEvents numericUpDown As System.Windows.Forms.NumericUpDown
    Private WithEvents domainUpDown As System.Windows.Forms.DomainUpDown
    Private WithEvents pageTreeView As System.Windows.Forms.TabPage
    Private WithEvents lblNodeInfo As System.Windows.Forms.Label
    Private WithEvents treeViewCars As System.Windows.Forms.TreeView
  Private WithEvents myWebBrowser As System.Windows.Forms.WebBrowser
    Private WithEvents txtUrl As System.Windows.Forms.TextBox
  Private WithEvents tabControlExoticControls As System.Windows.Forms.TabControl
    Private WithEvents pageTrackBars As System.Windows.Forms.TabPage
  Private WithEvents pagePanels As System.Windows.Forms.TabPage
    Private WithEvents panelTextBoxes As System.Windows.Forms.Panel
    Private WithEvents lblInstructions As System.Windows.Forms.Label
    Private WithEvents txtUpperText As System.Windows.Forms.TextBox
    Private WithEvents txtNormalText As System.Windows.Forms.TextBox
    Private WithEvents btnHidePanel As System.Windows.Forms.Button
    Private WithEvents btnShowPanel As System.Windows.Forms.Button
    Private WithEvents pageUpDown As System.Windows.Forms.TabPage
    Private WithEvents lblCurrSel As System.Windows.Forms.Label
    Private WithEvents pageWebBrowser As System.Windows.Forms.TabPage
    Private WithEvents btnGO As System.Windows.Forms.Button
  Private WithEvents lblURL As System.Windows.Forms.Label
  Private WithEvents lblGreen As System.Windows.Forms.Label
  Private WithEvents lblRed As System.Windows.Forms.Label
  Private WithEvents colorBox As System.Windows.Forms.PictureBox
  Private WithEvents blueTrackBar As System.Windows.Forms.TrackBar
  Private WithEvents lblCurrColor As System.Windows.Forms.Label
  Private WithEvents lblBlue As System.Windows.Forms.Label
  Private WithEvents redTrackBar As System.Windows.Forms.TrackBar
  Private WithEvents greenTrackBar As System.Windows.Forms.TrackBar
  Private WithEvents imageListTreeView As System.Windows.Forms.ImageList
  Private WithEvents tooManyCharactersErrorProvider As System.Windows.Forms.ErrorProvider

End Class
