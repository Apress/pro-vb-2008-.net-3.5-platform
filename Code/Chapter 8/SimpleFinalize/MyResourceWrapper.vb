Class MyResourceWrapper
  ' Override System.Object.Finalize()
  Protected Overrides Sub Finalize()
    Try
      ' Clean up any unmanaged resources here!

      ' Beep when destroyed (testing purposes only!)
      Console.Beep()
    Finally
      MyBase.Finalize()
    End Try
  End Sub
End Class
