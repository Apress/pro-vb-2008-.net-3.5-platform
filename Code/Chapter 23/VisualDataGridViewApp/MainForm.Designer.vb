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
    Me.components = New System.ComponentModel.Container
    Me.Label1 = New System.Windows.Forms.Label
    Me.DataGridView1 = New System.Windows.Forms.DataGridView
    Me.InventoryDataSet = New VisualDataGridViewApp.InventoryDataSet
    Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.InventoryTableAdapter = New VisualDataGridViewApp.InventoryDataSetTableAdapters.InventoryTableAdapter
    Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnUpdateInventory = New System.Windows.Forms.Button
    Me.groupBox1 = New System.Windows.Forms.GroupBox
    Me.btnAddRow = New System.Windows.Forms.Button
    Me.txtMake = New System.Windows.Forms.TextBox
    Me.txtPetName = New System.Windows.Forms.TextBox
    Me.txtColor = New System.Windows.Forms.TextBox
    Me.txtCarID = New System.Windows.Forms.TextBox
    Me.label5 = New System.Windows.Forms.Label
    Me.label4 = New System.Windows.Forms.Label
    Me.label3 = New System.Windows.Forms.Label
    Me.label2 = New System.Windows.Forms.Label
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.groupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(218, 20)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "The AutoLot Inventory Viewer"
    '
    'DataGridView1
    '
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarIDDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.PetNameDataGridViewTextBoxColumn})
    Me.DataGridView1.DataSource = Me.InventoryBindingSource
    Me.DataGridView1.Location = New System.Drawing.Point(16, 48)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.Size = New System.Drawing.Size(476, 220)
    Me.DataGridView1.TabIndex = 1
    '
    'InventoryDataSet
    '
    Me.InventoryDataSet.DataSetName = "InventoryDataSet"
    Me.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'InventoryBindingSource
    '
    Me.InventoryBindingSource.DataMember = "Inventory"
    Me.InventoryBindingSource.DataSource = Me.InventoryDataSet
    '
    'InventoryTableAdapter
    '
    Me.InventoryTableAdapter.ClearBeforeFill = True
    '
    'CarIDDataGridViewTextBoxColumn
    '
    Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "CarID"
    Me.CarIDDataGridViewTextBoxColumn.HeaderText = "CarID"
    Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
    '
    'MakeDataGridViewTextBoxColumn
    '
    Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "Make"
    Me.MakeDataGridViewTextBoxColumn.HeaderText = "Make"
    Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
    '
    'ColorDataGridViewTextBoxColumn
    '
    Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
    Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
    Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
    '
    'PetNameDataGridViewTextBoxColumn
    '
    Me.PetNameDataGridViewTextBoxColumn.DataPropertyName = "PetName"
    Me.PetNameDataGridViewTextBoxColumn.HeaderText = "PetName"
    Me.PetNameDataGridViewTextBoxColumn.Name = "PetNameDataGridViewTextBoxColumn"
    '
    'btnUpdateInventory
    '
    Me.btnUpdateInventory.Location = New System.Drawing.Point(417, 283)
    Me.btnUpdateInventory.Name = "btnUpdateInventory"
    Me.btnUpdateInventory.Size = New System.Drawing.Size(75, 23)
    Me.btnUpdateInventory.TabIndex = 2
    Me.btnUpdateInventory.Text = "Update!"
    Me.btnUpdateInventory.UseVisualStyleBackColor = True
    '
    'groupBox1
    '
    Me.groupBox1.Controls.Add(Me.btnAddRow)
    Me.groupBox1.Controls.Add(Me.txtMake)
    Me.groupBox1.Controls.Add(Me.txtPetName)
    Me.groupBox1.Controls.Add(Me.txtColor)
    Me.groupBox1.Controls.Add(Me.txtCarID)
    Me.groupBox1.Controls.Add(Me.label5)
    Me.groupBox1.Controls.Add(Me.label4)
    Me.groupBox1.Controls.Add(Me.label3)
    Me.groupBox1.Controls.Add(Me.label2)
    Me.groupBox1.Location = New System.Drawing.Point(16, 283)
    Me.groupBox1.Name = "groupBox1"
    Me.groupBox1.Size = New System.Drawing.Size(321, 161)
    Me.groupBox1.TabIndex = 4
    Me.groupBox1.TabStop = False
    Me.groupBox1.Text = "Manually Adding New Row"
    '
    'btnAddRow
    '
    Me.btnAddRow.Location = New System.Drawing.Point(222, 122)
    Me.btnAddRow.Name = "btnAddRow"
    Me.btnAddRow.Size = New System.Drawing.Size(88, 23)
    Me.btnAddRow.TabIndex = 4
    Me.btnAddRow.Text = "Add Row"
    Me.btnAddRow.UseVisualStyleBackColor = True
    '
    'txtMake
    '
    Me.txtMake.Location = New System.Drawing.Point(82, 58)
    Me.txtMake.Name = "txtMake"
    Me.txtMake.Size = New System.Drawing.Size(118, 20)
    Me.txtMake.TabIndex = 1
    '
    'txtPetName
    '
    Me.txtPetName.Location = New System.Drawing.Point(82, 124)
    Me.txtPetName.Name = "txtPetName"
    Me.txtPetName.Size = New System.Drawing.Size(118, 20)
    Me.txtPetName.TabIndex = 3
    '
    'txtColor
    '
    Me.txtColor.Location = New System.Drawing.Point(82, 91)
    Me.txtColor.Name = "txtColor"
    Me.txtColor.Size = New System.Drawing.Size(118, 20)
    Me.txtColor.TabIndex = 2
    '
    'txtCarID
    '
    Me.txtCarID.Location = New System.Drawing.Point(82, 25)
    Me.txtCarID.Name = "txtCarID"
    Me.txtCarID.Size = New System.Drawing.Size(118, 20)
    Me.txtCarID.TabIndex = 0
    '
    'label5
    '
    Me.label5.AutoSize = True
    Me.label5.Location = New System.Drawing.Point(12, 94)
    Me.label5.Name = "label5"
    Me.label5.Size = New System.Drawing.Size(31, 13)
    Me.label5.TabIndex = 3
    Me.label5.Text = "Color"
    '
    'label4
    '
    Me.label4.AutoSize = True
    Me.label4.Location = New System.Drawing.Point(12, 127)
    Me.label4.Name = "label4"
    Me.label4.Size = New System.Drawing.Size(51, 13)
    Me.label4.TabIndex = 2
    Me.label4.Text = "PetName"
    '
    'label3
    '
    Me.label3.AutoSize = True
    Me.label3.Location = New System.Drawing.Point(12, 61)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(34, 13)
    Me.label3.TabIndex = 1
    Me.label3.Text = "Make"
    '
    'label2
    '
    Me.label2.AutoSize = True
    Me.label2.Location = New System.Drawing.Point(12, 28)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(37, 13)
    Me.label2.TabIndex = 0
    Me.label2.Text = "Car ID"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(504, 464)
    Me.Controls.Add(Me.groupBox1)
    Me.Controls.Add(Me.btnUpdateInventory)
    Me.Controls.Add(Me.DataGridView1)
    Me.Controls.Add(Me.Label1)
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Inventory Viewer Redux"
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.InventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.groupBox1.ResumeLayout(False)
    Me.groupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents InventoryDataSet As VisualDataGridViewApp.InventoryDataSet
  Friend WithEvents InventoryBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents InventoryTableAdapter As VisualDataGridViewApp.InventoryDataSetTableAdapters.InventoryTableAdapter
  Friend WithEvents CarIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MakeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PetNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnUpdateInventory As System.Windows.Forms.Button
  Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
  Private WithEvents btnAddRow As System.Windows.Forms.Button
  Private WithEvents txtMake As System.Windows.Forms.TextBox
  Private WithEvents txtPetName As System.Windows.Forms.TextBox
  Private WithEvents txtColor As System.Windows.Forms.TextBox
  Private WithEvents txtCarID As System.Windows.Forms.TextBox
  Private WithEvents label5 As System.Windows.Forms.Label
  Private WithEvents label4 As System.Windows.Forms.Label
  Private WithEvents label3 As System.Windows.Forms.Label
  Private WithEvents label2 As System.Windows.Forms.Label

End Class
