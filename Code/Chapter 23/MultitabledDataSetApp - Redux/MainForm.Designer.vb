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
    Me.groupBox1 = New System.Windows.Forms.GroupBox
    Me.btnGetOrderInfo = New System.Windows.Forms.Button
    Me.label4 = New System.Windows.Forms.Label
    Me.txtCustID = New System.Windows.Forms.TextBox
    Me.label3 = New System.Windows.Forms.Label
    Me.btnUpdateDatabase = New System.Windows.Forms.Button
    Me.dataGridViewOrders = New System.Windows.Forms.DataGridView
    Me.label2 = New System.Windows.Forms.Label
    Me.dataGridViewCustomers = New System.Windows.Forms.DataGridView
    Me.label1 = New System.Windows.Forms.Label
    Me.dataGridViewInventory = New System.Windows.Forms.DataGridView
    Me.groupBox1.SuspendLayout()
    CType(Me.dataGridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dataGridViewCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dataGridViewInventory, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'groupBox1
    '
    Me.groupBox1.Controls.Add(Me.btnGetOrderInfo)
    Me.groupBox1.Controls.Add(Me.label4)
    Me.groupBox1.Controls.Add(Me.txtCustID)
    Me.groupBox1.Location = New System.Drawing.Point(26, 348)
    Me.groupBox1.Name = "groupBox1"
    Me.groupBox1.Size = New System.Drawing.Size(200, 100)
    Me.groupBox1.TabIndex = 18
    Me.groupBox1.TabStop = False
    Me.groupBox1.Text = "Lookup Customer Order"
    '
    'btnGetOrderInfo
    '
    Me.btnGetOrderInfo.Location = New System.Drawing.Point(84, 71)
    Me.btnGetOrderInfo.Name = "btnGetOrderInfo"
    Me.btnGetOrderInfo.Size = New System.Drawing.Size(110, 23)
    Me.btnGetOrderInfo.TabIndex = 7
    Me.btnGetOrderInfo.Text = "Get Order Details"
    '
    'label4
    '
    Me.label4.AutoSize = True
    Me.label4.Location = New System.Drawing.Point(10, 29)
    Me.label4.Name = "label4"
    Me.label4.Size = New System.Drawing.Size(68, 13)
    Me.label4.TabIndex = 9
    Me.label4.Text = "Customer ID:"
    '
    'txtCustID
    '
    Me.txtCustID.Location = New System.Drawing.Point(84, 29)
    Me.txtCustID.Name = "txtCustID"
    Me.txtCustID.Size = New System.Drawing.Size(110, 20)
    Me.txtCustID.TabIndex = 8
    '
    'label3
    '
    Me.label3.AutoSize = True
    Me.label3.Location = New System.Drawing.Point(23, 224)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(75, 13)
    Me.label3.TabIndex = 16
    Me.label3.Text = "Current Orders"
    '
    'btnUpdateDatabase
    '
    Me.btnUpdateDatabase.Location = New System.Drawing.Point(418, 348)
    Me.btnUpdateDatabase.Name = "btnUpdateDatabase"
    Me.btnUpdateDatabase.Size = New System.Drawing.Size(114, 23)
    Me.btnUpdateDatabase.TabIndex = 17
    Me.btnUpdateDatabase.Text = "Update Database"
    '
    'dataGridViewOrders
    '
    Me.dataGridViewOrders.Location = New System.Drawing.Point(24, 240)
    Me.dataGridViewOrders.Name = "dataGridViewOrders"
    Me.dataGridViewOrders.Size = New System.Drawing.Size(509, 90)
    Me.dataGridViewOrders.TabIndex = 15
    Me.dataGridViewOrders.Text = "dataGridView3"
    '
    'label2
    '
    Me.label2.AutoSize = True
    Me.label2.Location = New System.Drawing.Point(23, 106)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(93, 13)
    Me.label2.TabIndex = 14
    Me.label2.Text = "Current Customers"
    '
    'dataGridViewCustomers
    '
    Me.dataGridViewCustomers.Location = New System.Drawing.Point(24, 122)
    Me.dataGridViewCustomers.Name = "dataGridViewCustomers"
    Me.dataGridViewCustomers.Size = New System.Drawing.Size(509, 90)
    Me.dataGridViewCustomers.TabIndex = 13
    Me.dataGridViewCustomers.Text = "dataGridView2"
    '
    'label1
    '
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(22, -2)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(88, 13)
    Me.label1.TabIndex = 12
    Me.label1.Text = "Current Inventory"
    '
    'dataGridViewInventory
    '
    Me.dataGridViewInventory.Location = New System.Drawing.Point(23, 14)
    Me.dataGridViewInventory.Name = "dataGridViewInventory"
    Me.dataGridViewInventory.Size = New System.Drawing.Size(509, 82)
    Me.dataGridViewInventory.TabIndex = 11
    Me.dataGridViewInventory.Text = "dataGridView1"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(545, 462)
    Me.Controls.Add(Me.groupBox1)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.btnUpdateDatabase)
    Me.Controls.Add(Me.dataGridViewOrders)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.dataGridViewCustomers)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.dataGridViewInventory)
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "AutoLot Database Manipulator"
    Me.groupBox1.ResumeLayout(False)
    Me.groupBox1.PerformLayout()
    CType(Me.dataGridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dataGridViewCustomers, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dataGridViewInventory, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
  Private WithEvents btnGetOrderInfo As System.Windows.Forms.Button
  Private WithEvents label4 As System.Windows.Forms.Label
  Private WithEvents txtCustID As System.Windows.Forms.TextBox
  Private WithEvents label3 As System.Windows.Forms.Label
  Private WithEvents btnUpdateDatabase As System.Windows.Forms.Button
  Private WithEvents dataGridViewOrders As System.Windows.Forms.DataGridView
  Private WithEvents label2 As System.Windows.Forms.Label
  Private WithEvents dataGridViewCustomers As System.Windows.Forms.DataGridView
  Private WithEvents label1 As System.Windows.Forms.Label
  Private WithEvents dataGridViewInventory As System.Windows.Forms.DataGridView

End Class
