Public Class MyResourceWrapper
  Implements IDisposable

  ' Used to determine if Dispose()
  ' has already been called.
  Private disposed As Boolean = False

  Public Sub Dispose() Implements IDisposable.Dispose
    ' Call our helper method.
    ' Specifying True signifies that
    ' the object user triggered the clean up.
    CleanUp(True)
    GC.SuppressFinalize(Me)
  End Sub

  Private Sub CleanUp(ByVal disposing As Boolean)
    ' Be sure we have not already been disposed!
    If Not Me.disposed Then
      If disposing Then
        ' Dispose managed resources.
      End If
      ' Clean up unmanaged resources here.
    End If
    disposed = True
  End Sub

  Protected Overrides Sub Finalize()
    ' Call our helper method.
    ' Specifying False signifies that
    ' the GC triggered the clean up.
    CleanUp(False)
  End Sub
End Class
