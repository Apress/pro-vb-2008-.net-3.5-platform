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
    Me.label4 = New System.Windows.Forms.Label
    Me.label2 = New System.Windows.Forms.Label
    Me.radioPink = New System.Windows.Forms.RadioButton
    Me.radioYellow = New System.Windows.Forms.RadioButton
    Me.radioRed = New System.Windows.Forms.RadioButton
    Me.radioGreen = New System.Windows.Forms.RadioButton
    Me.infoLabel = New System.Windows.Forms.Label
    Me.checkedBoxRadioOptions = New System.Windows.Forms.CheckedListBox
    Me.btnOrder = New System.Windows.Forms.Button
    Me.checkFloorMats = New System.Windows.Forms.CheckBox
    Me.groupBoxColor = New System.Windows.Forms.GroupBox
    Me.label3 = New System.Windows.Forms.Label
    Me.carMakeList = New System.Windows.Forms.ListBox
    Me.label5 = New System.Windows.Forms.Label
    Me.monthCalendar = New System.Windows.Forms.MonthCalendar
    Me.label1 = New System.Windows.Forms.Label
    Me.comboSalesPerson = New System.Windows.Forms.ComboBox
    Me.calendarTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.groupBoxColor.SuspendLayout()
    Me.SuspendLayout()
    '
    'label4
    '
    Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.label4.Location = New System.Drawing.Point(9, 197)
    Me.label4.Name = "label4"
    Me.label4.Size = New System.Drawing.Size(208, 24)
    Me.label4.TabIndex = 24
    Me.label4.Text = "Order Stats:"
    '
    'label2
    '
    Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.label2.Location = New System.Drawing.Point(157, 15)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(144, 16)
    Me.label2.TabIndex = 21
    Me.label2.Text = "Radio Options:"
    '
    'radioPink
    '
    Me.radioPink.BackColor = System.Drawing.SystemColors.ControlLight
    Me.radioPink.Location = New System.Drawing.Point(176, 24)
    Me.radioPink.Name = "radioPink"
    Me.radioPink.Size = New System.Drawing.Size(56, 23)
    Me.radioPink.TabIndex = 3
    Me.radioPink.Text = "Pink"
    Me.radioPink.UseVisualStyleBackColor = False
    '
    'radioYellow
    '
    Me.radioYellow.BackColor = System.Drawing.SystemColors.ControlLight
    Me.radioYellow.Location = New System.Drawing.Point(96, 24)
    Me.radioYellow.Name = "radioYellow"
    Me.radioYellow.Size = New System.Drawing.Size(56, 23)
    Me.radioYellow.TabIndex = 1
    Me.radioYellow.Text = "Yellow"
    Me.radioYellow.UseVisualStyleBackColor = False
    '
    'radioRed
    '
    Me.radioRed.BackColor = System.Drawing.SystemColors.ControlLight
    Me.radioRed.Location = New System.Drawing.Point(264, 24)
    Me.radioRed.Name = "radioRed"
    Me.radioRed.Size = New System.Drawing.Size(64, 23)
    Me.radioRed.TabIndex = 2
    Me.radioRed.Text = "Red"
    Me.radioRed.UseVisualStyleBackColor = False
    '
    'radioGreen
    '
    Me.radioGreen.BackColor = System.Drawing.SystemColors.ControlLight
    Me.radioGreen.Location = New System.Drawing.Point(16, 24)
    Me.radioGreen.Name = "radioGreen"
    Me.radioGreen.Size = New System.Drawing.Size(64, 23)
    Me.radioGreen.TabIndex = 0
    Me.radioGreen.Text = "Green"
    Me.radioGreen.UseVisualStyleBackColor = False
    '
    'infoLabel
    '
    Me.infoLabel.BackColor = System.Drawing.Color.OldLace
    Me.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.infoLabel.Font = New System.Drawing.Font("Arial", 8.0!)
    Me.infoLabel.Location = New System.Drawing.Point(10, 229)
    Me.infoLabel.Name = "infoLabel"
    Me.infoLabel.Size = New System.Drawing.Size(224, 200)
    Me.infoLabel.TabIndex = 18
    '
    'checkedBoxRadioOptions
    '
    Me.checkedBoxRadioOptions.CheckOnClick = True
    Me.checkedBoxRadioOptions.Cursor = System.Windows.Forms.Cursors.Hand
    Me.checkedBoxRadioOptions.FormattingEnabled = True
    Me.checkedBoxRadioOptions.Items.AddRange(New Object() {"Front Speakers", "8-Track Tape Player", "CD Player", "Cassette Player", "Rear Speakers", "Ultra Base Thumper"})
    Me.checkedBoxRadioOptions.Location = New System.Drawing.Point(159, 42)
    Me.checkedBoxRadioOptions.Name = "checkedBoxRadioOptions"
    Me.checkedBoxRadioOptions.Size = New System.Drawing.Size(157, 49)
    Me.checkedBoxRadioOptions.TabIndex = 15
    '
    'btnOrder
    '
    Me.btnOrder.Location = New System.Drawing.Point(267, 407)
    Me.btnOrder.Name = "btnOrder"
    Me.btnOrder.Size = New System.Drawing.Size(120, 22)
    Me.btnOrder.TabIndex = 19
    Me.btnOrder.Text = "Confirm Order"
    '
    'checkFloorMats
    '
    Me.checkFloorMats.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.checkFloorMats.Location = New System.Drawing.Point(10, 11)
    Me.checkFloorMats.Name = "checkFloorMats"
    Me.checkFloorMats.Size = New System.Drawing.Size(112, 24)
    Me.checkFloorMats.TabIndex = 13
    Me.checkFloorMats.Text = "Extra Floor Mats"
    '
    'groupBoxColor
    '
    Me.groupBoxColor.Controls.Add(Me.radioPink)
    Me.groupBoxColor.Controls.Add(Me.radioYellow)
    Me.groupBoxColor.Controls.Add(Me.radioRed)
    Me.groupBoxColor.Controls.Add(Me.radioGreen)
    Me.groupBoxColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.groupBoxColor.Location = New System.Drawing.Point(10, 116)
    Me.groupBoxColor.Name = "groupBoxColor"
    Me.groupBoxColor.Size = New System.Drawing.Size(435, 56)
    Me.groupBoxColor.TabIndex = 17
    Me.groupBoxColor.TabStop = False
    Me.groupBoxColor.Text = "Exterior Color"
    '
    'label3
    '
    Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.label3.Location = New System.Drawing.Point(333, 18)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(112, 16)
    Me.label3.TabIndex = 22
    Me.label3.Text = "Make:"
    '
    'carMakeList
    '
    Me.carMakeList.FormattingEnabled = True
    Me.carMakeList.Items.AddRange(New Object() {"BMW", "Caravan", "Ford", "Grand Am", "Jeep", "Jetta", "Saab", "Viper", "Yugo"})
    Me.carMakeList.Location = New System.Drawing.Point(333, 42)
    Me.carMakeList.Name = "carMakeList"
    Me.carMakeList.ScrollAlwaysVisible = True
    Me.carMakeList.Size = New System.Drawing.Size(112, 56)
    Me.carMakeList.Sorted = True
    Me.carMakeList.TabIndex = 16
    '
    'label5
    '
    Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.label5.Location = New System.Drawing.Point(265, 197)
    Me.label5.Name = "label5"
    Me.label5.Size = New System.Drawing.Size(184, 16)
    Me.label5.TabIndex = 25
    Me.label5.Text = "Delivery Date:"
    '
    'monthCalendar
    '
    Me.monthCalendar.Location = New System.Drawing.Point(267, 229)
    Me.monthCalendar.Name = "monthCalendar"
    Me.monthCalendar.TabIndex = 23
    Me.calendarTip.SetToolTip(Me.monthCalendar, "When do you want your car?")
    '
    'label1
    '
    Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label1.Location = New System.Drawing.Point(10, 52)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(112, 24)
    Me.label1.TabIndex = 20
    Me.label1.Text = "Sales Person"
    '
    'comboSalesPerson
    '
    Me.comboSalesPerson.FormattingEnabled = True
    Me.comboSalesPerson.Items.AddRange(New Object() {"Baby Ry-Ry", "Dan 'the Machine'", "Cowboy Dan", "Tom 'the Style' "})
    Me.comboSalesPerson.Location = New System.Drawing.Point(10, 76)
    Me.comboSalesPerson.Name = "comboSalesPerson"
    Me.comboSalesPerson.Size = New System.Drawing.Size(128, 21)
    Me.comboSalesPerson.TabIndex = 14
    '
    'calendarTip
    '
    Me.calendarTip.IsBalloon = True
    Me.calendarTip.ShowAlways = True
    Me.calendarTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
    '
    'z
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(517, 454)
    Me.Controls.Add(Me.label5)
    Me.Controls.Add(Me.label4)
    Me.Controls.Add(Me.monthCalendar)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.comboSalesPerson)
    Me.Controls.Add(Me.carMakeList)
    Me.Controls.Add(Me.infoLabel)
    Me.Controls.Add(Me.checkedBoxRadioOptions)
    Me.Controls.Add(Me.btnOrder)
    Me.Controls.Add(Me.checkFloorMats)
    Me.Controls.Add(Me.groupBoxColor)
    Me.Name = "z"
    Me.Text = "Buy a new car!"
    Me.groupBoxColor.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Protected WithEvents label4 As System.Windows.Forms.Label
  Protected WithEvents label2 As System.Windows.Forms.Label
  Protected WithEvents radioPink As System.Windows.Forms.RadioButton
  Protected WithEvents radioYellow As System.Windows.Forms.RadioButton
  Protected WithEvents radioRed As System.Windows.Forms.RadioButton
  Protected WithEvents radioGreen As System.Windows.Forms.RadioButton
  Protected WithEvents infoLabel As System.Windows.Forms.Label
  Protected WithEvents checkedBoxRadioOptions As System.Windows.Forms.CheckedListBox
  Protected WithEvents btnOrder As System.Windows.Forms.Button
  Protected WithEvents checkFloorMats As System.Windows.Forms.CheckBox
  Protected WithEvents groupBoxColor As System.Windows.Forms.GroupBox
  Protected WithEvents label3 As System.Windows.Forms.Label
  Protected WithEvents carMakeList As System.Windows.Forms.ListBox
  Protected WithEvents label5 As System.Windows.Forms.Label
  Protected WithEvents monthCalendar As System.Windows.Forms.MonthCalendar
  Protected WithEvents label1 As System.Windows.Forms.Label
  Protected WithEvents comboSalesPerson As System.Windows.Forms.ComboBox
  Private WithEvents calendarTip As System.Windows.Forms.ToolTip

End Class
