Option Explicit On
Option Strict On

Public Class MainForm
  Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    CreateLabelControl()
    CenterToScreen()
  End Sub

  Private Sub CreateLabelControl()
    ' Create and configure a Label.
    Dim lblInstructions As New Label()
    lblInstructions.Name = "lblInstructions"
    lblInstructions.Text = "Please enter values in all the text boxes"
    lblInstructions.Font = New Font("Times New Roman", 10, FontStyle.Bold)
    lblInstructions.AutoSize = True
    lblInstructions.Location = New System.Drawing.Point(16, 13)
    lblInstructions.Size = New System.Drawing.Size(240, 16)
    ' Add to Form's controls collection.
    Me.Controls.Add(lblInstructions)
  End Sub

  Private Sub btnDisplayData_Click(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles btnDisplayData.Click
    ' Get data from all the text boxes.
    Dim textBoxData As String = ""
    textBoxData &= String.Format("MultiLine: {0}" & Chr(10), txtMultiline.Text)
    textBoxData &= String.Format("Password: {0}" & Chr(10), txtPassword.Text)
    textBoxData &= String.Format("Uppercase: {0}" & Chr(10), txtUpperCase.Text)
    textBoxData &= String.Format("Masked: {0}" & Chr(10), txtMaskedTextBox.Text)
    ' Display all the data. 
    MessageBox.Show(textBoxData, "Here is the data in your TextBoxes")
  End Sub

  Private Sub txtMaskedTextBox_MaskInputRejected(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtMaskedTextBox.MaskInputRejected
    Me.Text = String.Format("Error: {0}", e.RejectionHint)
  End Sub
End Class
