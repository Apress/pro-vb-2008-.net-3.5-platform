Imports AirVehicles

Module Module1
    Sub Main()
        Dim h As New AirVehicles.Helicopter()
        h.TakeOff()

        ' This will load the *.netmodule on demand.
        Dim u As New UFO()
        u.AbductHuman()
        Console.ReadLine()
    End Sub
End Module
