Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Finalizers *****")
    Console.WriteLine("Hit the return key to shut down this app")
    Console.WriteLine("and force the GC to invoke Finalize()")
    Console.WriteLine("for finalizable objects created in this AppDomain.")
    Console.ReadLine()
    Dim rw As New MyResourceWrapper()
  End Sub

End Module
