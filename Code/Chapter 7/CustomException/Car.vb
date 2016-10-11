Public Class Car
    ' Constant for maximum speed.
    Public Const maxSpeed As Integer = 100

    ' Internal state data.
    Private currSpeed As Integer
    Private petName As String

    ' Is the car still operational?
    Private carIsDead As Boolean

    ' A car has a radio.
    Private theMusicBox As Radio = New Radio()

#Region "Constructors."
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal currSp As Integer)
        currSpeed = currSp
        petName = name
    End Sub
#End Region

    Public Sub CrankTunes(ByVal state As Boolean)
        theMusicBox.TurnOn(state)
    End Sub

#Region "Accelerate method"
    ' See if Car has overheated.
    Public Sub Accelerate(ByVal delta As Integer)
        If delta < 0 Then
            Throw New ArgumentOutOfRangeException()
        End If
        If carIsDead Then
            Console.WriteLine("{0} is out of order...", petName)
        Else
            currSpeed += delta
            If currSpeed >= maxSpeed Then
                carIsDead = True
                currSpeed = 0

                ' We need to call the HelpLink property, thus we need to
                ' create a local variable before throwing the Exception object.
                Dim ex As New CarIsDeadException(String.Format("{0} has overheated!", petName))
                ex.HelpLink = "http://www.CarsRUs.com"
                ' Stuff in custom data regarding the error.
                ex.Data.Add("TimeStamp", _
                  String.Format("The car exploded at {0}", DateTime.Now))
                ex.Data.Add("Cause", "You have a lead foot.")
                Throw ex
            Else
                Console.WriteLine("=> CurrSpeed = {0}", currSpeed)
            End If
        End If
    End Sub
#End Region

End Class
