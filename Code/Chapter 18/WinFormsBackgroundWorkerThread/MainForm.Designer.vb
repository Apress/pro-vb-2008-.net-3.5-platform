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
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.btnAdd = New System.Windows.Forms.Button
    Me.txtNumbOne = New System.Windows.Forms.TextBox
    Me.txtNumbTwo = New System.Windows.Forms.TextBox
    Me.ProcessNumbersBackgroundWorker = New System.ComponentModel.BackgroundWorker
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 13)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "First Number"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(13, 63)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(84, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Second Number"
    '
    'btnAdd
    '
    Me.btnAdd.Location = New System.Drawing.Point(197, 103)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(75, 23)
    Me.btnAdd.TabIndex = 2
    Me.btnAdd.Text = "Add"
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'txtNumbOne
    '
    Me.txtNumbOne.Location = New System.Drawing.Point(132, 13)
    Me.txtNumbOne.Name = "txtNumbOne"
    Me.txtNumbOne.Size = New System.Drawing.Size(140, 20)
    Me.txtNumbOne.TabIndex = 3
    '
    'txtNumbTwo
    '
    Me.txtNumbTwo.Location = New System.Drawing.Point(132, 56)
    Me.txtNumbTwo.Name = "txtNumbTwo"
    Me.txtNumbTwo.Size = New System.Drawing.Size(140, 20)
    Me.txtNumbTwo.TabIndex = 4
    '
    'ProcessNumbersBackgroundWorker
    '
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 138)
    Me.Controls.Add(Me.txtNumbTwo)
    Me.Controls.Add(Me.txtNumbOne)
    Me.Controls.Add(Me.btnAdd)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Add with Threads (GUI!)"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents txtNumbOne As System.Windows.Forms.TextBox
  Friend WithEvents txtNumbTwo As System.Windows.Forms.TextBox
  Friend WithEvents ProcessNumbersBackgroundWorker As System.ComponentModel.BackgroundWorker

End Class
