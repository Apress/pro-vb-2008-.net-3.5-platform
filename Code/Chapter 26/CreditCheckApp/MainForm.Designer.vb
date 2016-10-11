<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
    Me.txtCustomerID = New System.Windows.Forms.TextBox
    Me.label1 = New System.Windows.Forms.Label
    Me.btnCheckCustomerCredit = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'txtCustomerID
    '
    Me.txtCustomerID.Location = New System.Drawing.Point(120, 23)
    Me.txtCustomerID.Name = "txtCustomerID"
    Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
    Me.txtCustomerID.TabIndex = 5
    '
    'label1
    '
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(20, 23)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(84, 13)
    Me.label1.TabIndex = 4
    Me.label1.Text = "Check my Credit"
    '
    'btnCheckCustomerCredit
    '
    Me.btnCheckCustomerCredit.Location = New System.Drawing.Point(23, 64)
    Me.btnCheckCustomerCredit.Name = "btnCheckCustomerCredit"
    Me.btnCheckCustomerCredit.Size = New System.Drawing.Size(197, 23)
    Me.btnCheckCustomerCredit.TabIndex = 3
    Me.btnCheckCustomerCredit.Text = "Check Credit"
    Me.btnCheckCustomerCredit.UseVisualStyleBackColor = True
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(248, 106)
    Me.Controls.Add(Me.txtCustomerID)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.btnCheckCustomerCredit)
    Me.Name = "MainForm"
    Me.Text = "Credit Checker"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents txtCustomerID As System.Windows.Forms.TextBox
  Private WithEvents label1 As System.Windows.Forms.Label
  Private WithEvents btnCheckCustomerCredit As System.Windows.Forms.Button

End Class
