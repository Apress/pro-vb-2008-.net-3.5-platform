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
    Me.label2 = New System.Windows.Forms.Label
    Me.btnDisplayMakes = New System.Windows.Forms.Button
    Me.dataGridColtsView = New System.Windows.Forms.DataGridView
    Me.txtMakeToView = New System.Windows.Forms.TextBox
    Me.groupBox2 = New System.Windows.Forms.GroupBox
    Me.groupBox1 = New System.Windows.Forms.GroupBox
    Me.txtRowToRemove = New System.Windows.Forms.TextBox
    Me.btnRemoveRow = New System.Windows.Forms.Button
    Me.label1 = New System.Windows.Forms.Label
    Me.carInventoryGridView = New System.Windows.Forms.DataGridView
    Me.btnChangeBeemersToYugos = New System.Windows.Forms.Button
    CType(Me.dataGridColtsView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.groupBox2.SuspendLayout()
    Me.groupBox1.SuspendLayout()
    CType(Me.carInventoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'label2
    '
    Me.label2.AutoSize = True
    Me.label2.Location = New System.Drawing.Point(26, 299)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(95, 13)
    Me.label2.TabIndex = 13
    Me.label2.Text = "Here are the Colts:"
    '
    'btnDisplayMakes
    '
    Me.btnDisplayMakes.Location = New System.Drawing.Point(6, 48)
    Me.btnDisplayMakes.Name = "btnDisplayMakes"
    Me.btnDisplayMakes.Size = New System.Drawing.Size(135, 23)
    Me.btnDisplayMakes.TabIndex = 0
    Me.btnDisplayMakes.Text = "Display Makes"
    Me.btnDisplayMakes.UseVisualStyleBackColor = True
    '
    'dataGridColtsView
    '
    Me.dataGridColtsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dataGridColtsView.Location = New System.Drawing.Point(26, 325)
    Me.dataGridColtsView.Name = "dataGridColtsView"
    Me.dataGridColtsView.Size = New System.Drawing.Size(402, 95)
    Me.dataGridColtsView.TabIndex = 12
    '
    'txtMakeToView
    '
    Me.txtMakeToView.Location = New System.Drawing.Point(6, 22)
    Me.txtMakeToView.Name = "txtMakeToView"
    Me.txtMakeToView.Size = New System.Drawing.Size(135, 20)
    Me.txtMakeToView.TabIndex = 1
    '
    'groupBox2
    '
    Me.groupBox2.Controls.Add(Me.txtMakeToView)
    Me.groupBox2.Controls.Add(Me.btnDisplayMakes)
    Me.groupBox2.Location = New System.Drawing.Point(251, 206)
    Me.groupBox2.Name = "groupBox2"
    Me.groupBox2.Size = New System.Drawing.Size(177, 85)
    Me.groupBox2.TabIndex = 10
    Me.groupBox2.TabStop = False
    Me.groupBox2.Text = "Enter make To view"
    '
    'groupBox1
    '
    Me.groupBox1.Controls.Add(Me.txtRowToRemove)
    Me.groupBox1.Controls.Add(Me.btnRemoveRow)
    Me.groupBox1.Location = New System.Drawing.Point(26, 206)
    Me.groupBox1.Name = "groupBox1"
    Me.groupBox1.Size = New System.Drawing.Size(177, 85)
    Me.groupBox1.TabIndex = 9
    Me.groupBox1.TabStop = False
    Me.groupBox1.Text = "Enter row number to delete"
    '
    'txtRowToRemove
    '
    Me.txtRowToRemove.Location = New System.Drawing.Point(6, 22)
    Me.txtRowToRemove.Name = "txtRowToRemove"
    Me.txtRowToRemove.Size = New System.Drawing.Size(135, 20)
    Me.txtRowToRemove.TabIndex = 1
    '
    'btnRemoveRow
    '
    Me.btnRemoveRow.Location = New System.Drawing.Point(6, 48)
    Me.btnRemoveRow.Name = "btnRemoveRow"
    Me.btnRemoveRow.Size = New System.Drawing.Size(135, 23)
    Me.btnRemoveRow.TabIndex = 0
    Me.btnRemoveRow.Text = "Remove"
    Me.btnRemoveRow.UseVisualStyleBackColor = True
    '
    'label1
    '
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(26, 14)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(141, 13)
    Me.label1.TabIndex = 8
    Me.label1.Text = "The Current List of Inventory"
    '
    'carInventoryGridView
    '
    Me.carInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.carInventoryGridView.Location = New System.Drawing.Point(26, 50)
    Me.carInventoryGridView.Name = "carInventoryGridView"
    Me.carInventoryGridView.Size = New System.Drawing.Size(402, 135)
    Me.carInventoryGridView.TabIndex = 7
    '
    'btnChangeBeemersToYugos
    '
    Me.btnChangeBeemersToYugos.Location = New System.Drawing.Point(251, 14)
    Me.btnChangeBeemersToYugos.Name = "btnChangeBeemersToYugos"
    Me.btnChangeBeemersToYugos.Size = New System.Drawing.Size(177, 23)
    Me.btnChangeBeemersToYugos.TabIndex = 14
    Me.btnChangeBeemersToYugos.Text = "Change all BMWs to Yugos"
    Me.btnChangeBeemersToYugos.UseVisualStyleBackColor = True
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(458, 443)
    Me.Controls.Add(Me.btnChangeBeemersToYugos)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.dataGridColtsView)
    Me.Controls.Add(Me.groupBox2)
    Me.Controls.Add(Me.groupBox1)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.carInventoryGridView)
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "DataTable Viewer"
    CType(Me.dataGridColtsView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.groupBox2.ResumeLayout(False)
    Me.groupBox2.PerformLayout()
    Me.groupBox1.ResumeLayout(False)
    Me.groupBox1.PerformLayout()
    CType(Me.carInventoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents label2 As System.Windows.Forms.Label
  Private WithEvents btnDisplayMakes As System.Windows.Forms.Button
  Private WithEvents dataGridColtsView As System.Windows.Forms.DataGridView
  Private WithEvents txtMakeToView As System.Windows.Forms.TextBox
  Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
  Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
  Private WithEvents txtRowToRemove As System.Windows.Forms.TextBox
  Private WithEvents btnRemoveRow As System.Windows.Forms.Button
  Private WithEvents label1 As System.Windows.Forms.Label
  Private WithEvents carInventoryGridView As System.Windows.Forms.DataGridView
  Friend WithEvents btnChangeBeemersToYugos As System.Windows.Forms.Button

End Class
