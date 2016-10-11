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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.btnImage = New System.Windows.Forms.Button
    Me.btnStandard = New System.Windows.Forms.Button
    Me.btnPopup = New System.Windows.Forms.Button
    Me.btnFlat = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnImage
    '
    Me.btnImage.BackgroundImage = CType(resources.GetObject("btnImage.BackgroundImage"), System.Drawing.Image)
    Me.btnImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
    Me.btnImage.ForeColor = System.Drawing.Color.Black
    Me.btnImage.Image = CType(resources.GetObject("btnImage.Image"), System.Drawing.Image)
    Me.btnImage.Location = New System.Drawing.Point(18, 207)
    Me.btnImage.Name = "btnImage"
    Me.btnImage.Size = New System.Drawing.Size(312, 72)
    Me.btnImage.TabIndex = 7
    Me.btnImage.Text = "Image Button"
    Me.btnImage.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'btnStandard
    '
    Me.btnStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
    Me.btnStandard.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnStandard.Location = New System.Drawing.Point(18, 95)
    Me.btnStandard.Name = "btnStandard"
    Me.btnStandard.Size = New System.Drawing.Size(312, 88)
    Me.btnStandard.TabIndex = 6
    Me.btnStandard.Text = "I am a standard button"
    '
    'btnPopup
    '
    Me.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
    Me.btnPopup.ForeColor = System.Drawing.SystemColors.ControlText
    Me.btnPopup.Location = New System.Drawing.Point(178, 39)
    Me.btnPopup.Name = "btnPopup"
    Me.btnPopup.Size = New System.Drawing.Size(152, 32)
    Me.btnPopup.TabIndex = 5
    Me.btnPopup.Text = "I am a Popup!"
    '
    'btnFlat
    '
    Me.btnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnFlat.ForeColor = System.Drawing.Color.Blue
    Me.btnFlat.Location = New System.Drawing.Point(18, 39)
    Me.btnFlat.Name = "btnFlat"
    Me.btnFlat.Size = New System.Drawing.Size(152, 32)
    Me.btnFlat.TabIndex = 4
    Me.btnFlat.Text = "I am flat..."
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(349, 319)
    Me.Controls.Add(Me.btnImage)
    Me.Controls.Add(Me.btnStandard)
    Me.Controls.Add(Me.btnPopup)
    Me.Controls.Add(Me.btnFlat)
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Fun with Buttons"
    Me.ResumeLayout(False)

  End Sub
    Private WithEvents btnImage As System.Windows.Forms.Button
    Private WithEvents btnStandard As System.Windows.Forms.Button
    Private WithEvents btnPopup As System.Windows.Forms.Button
    Private WithEvents btnFlat As System.Windows.Forms.Button

End Class
