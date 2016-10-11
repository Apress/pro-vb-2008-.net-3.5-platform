' Implementing IDisposable.
Class MyResourceWrapper
  Implements IDisposable

  ' The object user should call this method
  ' when they finished with the object.
  Public Sub Dispose() Implements IDisposable.Dispose
    ' Clean up unmanaged resources here.
    ' Dispose other contained disposable objects.

    ' Just for tracing purposes.
    Console.WriteLine("In Dispose method")
  End Sub
End Class
