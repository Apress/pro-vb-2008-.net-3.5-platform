<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItalicUserMessageDialog
    Inherits SimpleModalDialog.UserMessageDialog

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
        Me.checkBoxItalic = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'checkBoxItalic
        '
        Me.checkBoxItalic.AutoSize = True
        Me.checkBoxItalic.Location = New System.Drawing.Point(14, 84)
        Me.checkBoxItalic.Name = "checkBoxItalic"
        Me.checkBoxItalic.Size = New System.Drawing.Size(54, 17)
        Me.checkBoxItalic.TabIndex = 8
        Me.checkBoxItalic.Text = "Italic?"
        Me.checkBoxItalic.UseVisualStyleBackColor = True
        '
        'ItalicUserMessageDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(364, 137)
        Me.Controls.Add(Me.checkBoxItalic)
        Me.Name = "ItalicUserMessageDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.SetChildIndex(Me.checkBoxItalic, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkBoxItalic As System.Windows.Forms.CheckBox

End Class
