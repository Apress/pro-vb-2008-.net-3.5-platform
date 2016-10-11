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
        Me.label1 = New System.Windows.Forms.Label
        Me.numericUpDownCarSpeed = New System.Windows.Forms.NumericUpDown
        Me.lblEventData = New System.Windows.Forms.Label
        Me.lblCurrentSpeed = New System.Windows.Forms.Label
        Me.myCarControl = New CarControlLibrary.CarControl
        CType(Me.numericUpDownCarSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(179, 90)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Speed +/- 10 "
        '
        'numericUpDownCarSpeed
        '
        Me.numericUpDownCarSpeed.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericUpDownCarSpeed.Location = New System.Drawing.Point(180, 116)
        Me.numericUpDownCarSpeed.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.numericUpDownCarSpeed.Name = "numericUpDownCarSpeed"
        Me.numericUpDownCarSpeed.Size = New System.Drawing.Size(120, 20)
        Me.numericUpDownCarSpeed.TabIndex = 8
        '
        'lblEventData
        '
        Me.lblEventData.AutoSize = True
        Me.lblEventData.Location = New System.Drawing.Point(179, 53)
        Me.lblEventData.Name = "lblEventData"
        Me.lblEventData.Size = New System.Drawing.Size(64, 13)
        Me.lblEventData.TabIndex = 7
        Me.lblEventData.Text = "Event Data:"
        '
        'lblCurrentSpeed
        '
        Me.lblCurrentSpeed.AutoSize = True
        Me.lblCurrentSpeed.Location = New System.Drawing.Point(179, 25)
        Me.lblCurrentSpeed.Name = "lblCurrentSpeed"
        Me.lblCurrentSpeed.Size = New System.Drawing.Size(78, 13)
        Me.lblCurrentSpeed.TabIndex = 6
        Me.lblCurrentSpeed.Text = "Current Speed:"
        '
        'myCarControl
        '
        Me.myCarControl.Animate = False
        Me.myCarControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.myCarControl.Location = New System.Drawing.Point(12, 12)
        Me.myCarControl.Name = "myCarControl"
        Me.myCarControl.PetName = "Lemon"
        Me.myCarControl.Size = New System.Drawing.Size(150, 150)
        Me.myCarControl.Speed = 50
        Me.myCarControl.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 182)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.numericUpDownCarSpeed)
        Me.Controls.Add(Me.lblEventData)
        Me.Controls.Add(Me.lblCurrentSpeed)
        Me.Controls.Add(Me.myCarControl)
        Me.Name = "MainForm"
        Me.Text = "CarControl Tester"
        CType(Me.numericUpDownCarSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDownCarSpeed As System.Windows.Forms.NumericUpDown
    Private WithEvents lblEventData As System.Windows.Forms.Label
    Private WithEvents lblCurrentSpeed As System.Windows.Forms.Label
    Private WithEvents myCarControl As CarControlLibrary.CarControl

End Class
