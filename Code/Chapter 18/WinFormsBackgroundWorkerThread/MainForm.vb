Public Class MainForm

  Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
    Try
      ' First get the user data (as numerical).
      Dim numbOne As Integer = Integer.Parse(txtNumbOne.Text)
      Dim numbTwo As Integer = Integer.Parse(txtNumbTwo.Text)
      Dim args As New AddParams(numbOne, numbTwo)

      ' Now spin up the new thread and pass args variable.
      ProcessNumbersBackgroundWorker.RunWorkerAsync(args)
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub

  Private Sub ProcessNumbersBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ProcessNumbersBackgroundWorker.DoWork
    ' Get the incoming AddParam object.
    Dim args As AddParams = DirectCast(e.Argument, AddParams)

    ' Artifical lag.
    System.Threading.Thread.Sleep(5000)

    ' Return the value.
    e.Result = args.a + args.b
  End Sub

  Private Sub ProcessNumbersBackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProcessNumbersBackgroundWorker.RunWorkerCompleted
    MessageBox.Show(e.Result.ToString(), "Your result is")
  End Sub
End Class

#Region "Add params helper class"
Class AddParams
  Public a, b As Integer

  Public Sub New(ByVal numb1 As Integer, ByVal numb2 As Integer)
    a = numb1
    b = numb2
  End Sub
End Class
#End Region
