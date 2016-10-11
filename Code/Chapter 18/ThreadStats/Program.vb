Option Explicit On
Option Strict On

Imports System.Threading

Module Program
  Sub Main()
    Console.WriteLine("***** Primary Thread stats *****")
    Console.WriteLine()

    ' Obtain and name the current thread.
    Dim primaryThread As Thread = Thread.CurrentThread
    primaryThread.Name = "ThePrimaryThread"

    ' Show details of hosting AppDomain/Context.
    Console.WriteLine("Name of current AppDomain: {0}", _
        Thread.GetDomain().FriendlyName)
    Console.WriteLine("ID of current Context: {0}", _
        Thread.CurrentContext.ContextID)

    ' Print out some stats about this thread.
    Console.WriteLine("Thread Name: {0}", _
        primaryThread.Name)
    Console.WriteLine("Has thread started?: {0}", _
        primaryThread.IsAlive)
    Console.WriteLine("Priority Level: {0}", _
        primaryThread.Priority)
    Console.WriteLine("Thread State: {0}", _
        primaryThread.ThreadState)
    Console.ReadLine()
  End Sub
End Module
