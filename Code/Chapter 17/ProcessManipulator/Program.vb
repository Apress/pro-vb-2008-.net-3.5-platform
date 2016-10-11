Imports System.Diagnostics

Module Program

  Sub Main()
    Console.WriteLine("***** Fun with Processes *****" & vbLf)
    ListAllRunningProcesses()

    ' Prompt user for a PID and print out the set of active threads.
    Console.WriteLine("***** Enter PID of process to investigate *****")
    Console.Write("PID: ")
    Dim pID As String = Console.ReadLine()
    Try
      Dim theProcID As Integer = Integer.Parse(pID)
      EnumThreadsForPid(theProcID)
      EnumModsForPid(theProcID)
    Catch ex As Exception
      Console.WriteLine(ex.Message)
    End Try

    ' Launch IE.
    StartAndKillProcess()
    Console.ReadLine()
  End Sub


#Region "ListAllRunningProcesses"
  Public Sub ListAllRunningProcesses()
    ' Get all the processes on the local machine.
    Dim runningProcs As Process() = Process.GetProcesses(".")

    ' Print out PID and name of each process.
    For Each p As Process In runningProcs
      Dim info As String = String.Format("-> PID: {0}" & _
        Chr(9) & "Name: {1}", p.Id, p.ProcessName)
      Console.WriteLine(info)
    Next
    Console.WriteLine("************************************")
    Console.WriteLine()
  End Sub
#End Region

#Region "EnumThreadsForPid"
  Public Sub EnumThreadsForPid(ByVal pID As Integer)
    Dim theProc As Process
    Try
      theProc = Process.GetProcessById(pID)
    Catch
      Console.WriteLine("-> Sorry...bad PID!")
      Console.WriteLine("************************************")
      Console.WriteLine()
      Return
    End Try
    Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName)

    ' List out stats for each thread in the specified process.
    Dim theThreads As ProcessThreadCollection = theProc.Threads
    For Each pt As ProcessThread In theThreads
      Dim info As String = String.Format("-> Thread ID: {0}" _
        & Chr(9) & "Start Time {1}" & _
        Chr(9) & "Priority {2}", _
        pt.Id, pt.StartTime.ToShortTimeString(), pt.PriorityLevel)
      Console.WriteLine(info)
    Next
    Console.WriteLine("************************************")
    Console.WriteLine()
  End Sub
#End Region

#Region "EnumModsForPid"
  Public Sub EnumModsForPid(ByVal pID As Integer)
    Dim theProc As Process
    Try
      theProc = Process.GetProcessById(pID)
    Catch
      Console.WriteLine("-> Sorry...bad PID!")
      Console.WriteLine("************************************")
      Console.WriteLine()
      Return
    End Try
    Console.WriteLine("Here are the loaded modules for: {0}", theProc.ProcessName)
    Try
      Dim theMods As ProcessModuleCollection = theProc.Modules
      For Each pm As ProcessModule In theMods
        Dim info As String = String.Format("-> Mod Name: {0}", pm.ModuleName)
        Console.WriteLine(info)
      Next
      Console.WriteLine("************************************")
      Console.WriteLine()
    Catch
      Console.WriteLine("No mods!")
    End Try
  End Sub
#End Region

#Region "StartAndKillProcess"
  Public Sub StartAndKillProcess()
    ' Launch Internet Explorer.
    Console.Write("--> Hit a key to launch IE")
    Console.ReadLine()
    Dim ieProc As Process = Process.Start("IExplore.exe", _
    "www.intertech.com")
    Console.Write("--> Hit a key to kill {0}...", ieProc.ProcessName)
    Console.ReadLine()

    ' Kill the iexplorer.exe process.
    Try
      ieProc.Kill()
    Catch  ' In case the user already killed it...
    End Try
  End Sub
#End Region

End Module
