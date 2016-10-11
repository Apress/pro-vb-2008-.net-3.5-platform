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
    Me.txtMaskedTextBox = New System.Windows.Forms.MaskedTextBox
    Me.lblMaskedTextBox = New System.Windows.Forms.Label
    Me.btnDisplayData = New System.Windows.Forms.Button
    Me.txtUpperCase = New System.Windows.Forms.TextBox
    Me.lblUpperCaseOnly = New System.Windows.Forms.Label
    Me.txtMultiline = New System.Windows.Forms.TextBox
    Me.lblMultiline = New System.Windows.Forms.Label
    Me.txtPassword = New System.Windows.Forms.TextBox
    Me.lblPassword = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'txtMaskedTextBox
    '
    Me.txtMaskedTextBox.BeepOnError = True
    Me.txtMaskedTextBox.CausesValidation = False
    Me.txtMaskedTextBox.Location = New System.Drawing.Point(132, 223)
    Me.txtMaskedTextBox.Mask = "(999) 000-0000"
    Me.txtMaskedTextBox.Name = "txtMaskedTextBox"
    Me.txtMaskedTextBox.Size = New System.Drawing.Size(220, 20)
    Me.txtMaskedTextBox.TabIndex = 17
    '
    'lblMaskedTextBox
    '
    Me.lblMaskedTextBox.AutoSize = True
    Me.lblMaskedTextBox.Location = New System.Drawing.Point(22, 223)
    Me.lblMaskedTextBox.Name = "lblMaskedTextBox"
    Me.lblMaskedTextBox.Size = New System.Drawing.Size(87, 13)
    Me.lblMaskedTextBox.TabIndex = 16
    Me.lblMaskedTextBox.Text = "Mas&ked TextBox"
    '
    'btnDisplayData
    '
    Me.btnDisplayData.Location = New System.Drawing.Point(264, 260)
    Me.btnDisplayData.Name = "btnDisplayData"
    Me.btnDisplayData.Size = New System.Drawing.Size(88, 23)
    Me.btnDisplayData.TabIndex = 15
    Me.btnDisplayData.Text = "Display Data"
    '
    'txtUpperCase
    '
    Me.txtUpperCase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtUpperCase.Location = New System.Drawing.Point(132, 181)
    Me.txtUpperCase.Name = "txtUpperCase"
    Me.txtUpperCase.Size = New System.Drawing.Size(220, 20)
    Me.txtUpperCase.TabIndex = 14
    '
    'lblUpperCaseOnly
    '
    Me.lblUpperCaseOnly.AutoSize = True
    Me.lblUpperCaseOnly.Location = New System.Drawing.Point(22, 181)
    Me.lblUpperCaseOnly.Name = "lblUpperCaseOnly"
    Me.lblUpperCaseOnly.Size = New System.Drawing.Size(86, 13)
    Me.lblUpperCaseOnly.TabIndex = 13
    Me.lblUpperCaseOnly.Text = "&Uppercase Only:"
    '
    'txtMultiline
    '
    Me.txtMultiline.Location = New System.Drawing.Point(132, 104)
    Me.txtMultiline.Multiline = True
    Me.txtMultiline.Name = "txtMultiline"
    Me.txtMultiline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtMultiline.Size = New System.Drawing.Size(220, 52)
    Me.txtMultiline.TabIndex = 12
    '
    'lblMultiline
    '
    Me.lblMultiline.AutoSize = True
    Me.lblMultiline.Location = New System.Drawing.Point(21, 104)
    Me.lblMultiline.Name = "lblMultiline"
    Me.lblMultiline.Size = New System.Drawing.Size(90, 13)
    Me.lblMultiline.TabIndex = 11
    Me.lblMultiline.Text = "&Multiline TextBox:"
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(132, 67)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtPassword.Size = New System.Drawing.Size(220, 20)
    Me.txtPassword.TabIndex = 10
    '
    'lblPassword
    '
    Me.lblPassword.AutoSize = True
    Me.lblPassword.Location = New System.Drawing.Point(20, 67)
    Me.lblPassword.Name = "lblPassword"
    Me.lblPassword.Size = New System.Drawing.Size(98, 13)
    Me.lblPassword.TabIndex = 9
    Me.lblPassword.Text = "&Password TextBox:"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(364, 295)
    Me.Controls.Add(Me.txtMaskedTextBox)
    Me.Controls.Add(Me.lblMaskedTextBox)
    Me.Controls.Add(Me.btnDisplayData)
    Me.Controls.Add(Me.txtUpperCase)
    Me.Controls.Add(Me.lblUpperCaseOnly)
    Me.Controls.Add(Me.txtMultiline)
    Me.Controls.Add(Me.lblMultiline)
    Me.Controls.Add(Me.txtPassword)
    Me.Controls.Add(Me.lblPassword)
    Me.Name = "MainForm"
    Me.Text = "Fun with Labels and TextBoxes"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Private WithEvents txtMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Private WithEvents lblMaskedTextBox As System.Windows.Forms.Label
    Private WithEvents btnDisplayData As System.Windows.Forms.Button
    Private WithEvents txtUpperCase As System.Windows.Forms.TextBox
    Private WithEvents lblUpperCaseOnly As System.Windows.Forms.Label
    Private WithEvents txtMultiline As System.Windows.Forms.TextBox
    Private WithEvents lblMultiline As System.Windows.Forms.Label
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents lblPassword As System.Windows.Forms.Label

End Class
