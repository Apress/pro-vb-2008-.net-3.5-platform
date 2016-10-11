Option Explicit On
Option Strict On

Public Class MainForm

  ' Create a new generic List to hold the Car objects.
  Private listCars As List(Of Car) = New List(Of Car)()

  Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    CenterToScreen()
    ' Set initial position of each slider.
    redTrackBar.Value = 100
    greenTrackBar.Value = 255
    blueTrackBar.Value = 0
    UpdateColor()

    ' Fill List(Of T) and build TreeView.
    Dim offset As Double = 0.5
    For x As Integer = 0 To 99
      listCars.Add(New Car(String.Format("Car {0} ", x), 10 + x))
      offset += 0.5
      listCars(x).r = New Radio(89 + offset)
    Next
    BuildCarTreeView()
  End Sub

#Region "Track Bar stuff"
  Private Sub redTrackBar_Scroll(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles redTrackBar.Scroll
    UpdateColor()
  End Sub

  Private Sub greenTrackBar_Scroll(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles greenTrackBar.Scroll
    UpdateColor()
  End Sub

  Private Sub blueTrackBar_Scroll(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles blueTrackBar.Scroll
    UpdateColor()
  End Sub

  Private Sub UpdateColor()
    ' Get the new color based on track bars.
    Dim c As Color = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value)
    ' Change the color in the PictureBox.
    colorBox.BackColor = c
    ' Set color label.
    lblCurrColor.Text = String.Format("Current color is: (R:{0}, G:{1}, B:{2})", _
     redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value)
  End Sub
#End Region

#Region "Panel Stuff"
  Private Sub btnShowPanel_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnShowPanel.Click
    panelTextBoxes.Visible = True
  End Sub

  Private Sub btnHidePanel_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnHidePanel.Click
    panelTextBoxes.Visible = False
  End Sub

  Private Sub txtNormalText_TextChanged(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles txtNormalText.TextChanged
    txtUpperText.Text = txtNormalText.Text.ToUpper()
  End Sub
#End Region

#Region "Up / Down Stuff"
  Private Sub btnGetSelections_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnGetSelections.Click
    ' Get info from updowns...
    lblCurrSel.Text = _
         String.Format("String: {0}" & Chr(13) & "Number: {1}", _
         domainUpDown.Text, numericUpDown.Value)
  End Sub
#End Region

#Region "Error Provider Stuff"
  Private Sub txtInput_Validating(ByVal sender As System.Object, _
    ByVal e As System.ComponentModel.CancelEventArgs) Handles txtInput.Validating
    ' Check if the text length is greater than 5.
    If txtInput.Text.Length > 5 Then
      tooManyCharactersErrorProvider.SetError(txtInput, "Can't be greater than 5!")
    Else
      tooManyCharactersErrorProvider.SetError(txtInput, "")
      ' Things are OK, don't show anything.
    End If
  End Sub
#End Region

#Region "Build the treeview!"
  Sub BuildCarTreeView()
    ' Don’t repaint the TreeView until all the nodes have been created.
    treeViewCars.BeginUpdate()
    ' Clear the TreeView each time the method is called.
    treeViewCars.Nodes.Clear()
    ' Add a root TreeNode for each Car object in the List(Of T).
    For Each c As Car In listCars
      ' Add the current Car as a top-most node.
      treeViewCars.Nodes.Add(New TreeNode(c.petName, 0, 0))
      ' Now, get the Car you just added to build 
      ' two sub-nodes based on the speed and 
      ' internal Radio object.
      treeViewCars.Nodes(listCars.IndexOf(c)).Nodes.Add(New  _
        TreeNode(String.Format("Speed: {0}", c.currSp.ToString()), 1, 1))
      treeViewCars.Nodes(listCars.IndexOf(c)).Nodes.Add(New  _
        TreeNode(String.Format("Favorite Station: {0} FM", c.r.favoriteStation), 2, 2))
    Next
    ' Now paint the TreeView.
    treeViewCars.EndUpdate()
  End Sub

  Private Sub treeViewCars_AfterSelect(ByVal sender As System.Object, _
  ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeViewCars.AfterSelect
    Dim nodeInfo As String = ""
    ' Build info about selected node.
    nodeInfo = String.Format("You selected: {0}" & Chr(10) & "", e.Node.Text)
    If e.Node.Parent IsNot Nothing Then
      nodeInfo += String.Format("Parent Node: {0}" & Chr(10) & "", e.Node.Parent.Text)
    End If
    If e.Node.NextNode IsNot Nothing Then
      nodeInfo += String.Format("Next Node: {0}", e.Node.NextNode.Text)
    End If
    ' Show info and highlight node.
    lblNodeInfo.Text = nodeInfo
    e.Node.BackColor = Color.AliceBlue
  End Sub
#End Region

#Region "Web stuff"
  Private Sub btnGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGO.Click
    ' Set URL based on value within page's TextBox control.
    myWebBrowser.Url = New System.Uri(txtUrl.Text)
  End Sub
#End Region

End Class
