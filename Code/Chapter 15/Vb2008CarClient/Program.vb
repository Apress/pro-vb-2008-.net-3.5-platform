Option Explicit On
Option Strict On

' Import the CarLibrary namespace
' defined in the CarLibrary.dll assembly.
Imports CarLibrary

Module Program
  Sub Main()
    Console.WriteLine("***** Visual Basic 2008 Client *****")
    Dim myMiniVan As New MiniVan()
    myMiniVan.TurboBoost()

    Dim mySportsCar As New SportsCar()
    mySportsCar.TurboBoost()
  End Sub
End Module
