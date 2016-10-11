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
    Me.btnUpdateInventory = New System.Windows.Forms.Button
    Me.label1 = New System.Windows.Forms.Label
    Me.inventoryGrid = New System.Windows.Forms.DataGridView
    CType(Me.inventoryGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnUpdateInventory
    '
    Me.btnUpdateInventory.Location = New System.Drawing.Point(12, 363)
    Me.btnUpdateInventory.Name = "btnUpdateInventory"
    Me.btnUpdateInventory.Size = New System.Drawing.Size(93, 23)
    Me.btnUpdateInventory.TabIndex = 5
    Me.btnUpdateInventory.Text = "Update!"
    Me.btnUpdateInventory.UseVisualStyleBackColor = True
    '
    'label1
    '
    Me.label1.AutoSize = True
    Me.label1.Location = New System.Drawing.Point(11, 19)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(366, 13)
    Me.label1.TabIndex = 4
    Me.label1.Text = "Make Changes to the Grid and Click the Update Button to Process Changes"
    '
    'inventoryGrid
    '
    Me.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.inventoryGrid.Location = New System.Drawing.Point(12, 47)
    Me.inventoryGrid.Name = "inventoryGrid"
    Me.inventoryGrid.Size = New System.Drawing.Size(414, 298)
    Me.inventoryGrid.TabIndex = 3
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(436, 405)
    Me.Controls.Add(Me.btnUpdateInventory)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.inventoryGrid)
    Me.Name = "MainForm"
    Me.Text = "Inventory GUI"
    CType(Me.inventoryGrid, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Private WithEvents btnUpdateInventory As System.Windows.Forms.Button
  Private WithEvents label1 As System.Windows.Forms.Label
  Private WithEvents inventoryGrid As System.Windows.Forms.DataGridView

End Class
