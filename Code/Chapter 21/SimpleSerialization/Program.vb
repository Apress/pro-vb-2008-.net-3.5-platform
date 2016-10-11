Option Explicit On
Option Strict On

Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Xml.Serialization
Imports System.IO

Module Program
  Sub Main()
    Console.WriteLine("***** Fun with Object Serialization *****")
    ' Make a new object to persist. 
    Dim jbc As New JamesBondCar()
    jbc.canFly = True
    jbc.canSubmerge = False
    jbc.theRadio.stationPresets = New Double() {89.3, 105.1, 97.1}
    jbc.theRadio.hasTweeters = True

    ' Save the object in a binary format to 
    ' a local file. 
    Dim binFormat As New BinaryFormatter()
    Dim fStream As Stream = New FileStream("CarData.dat", FileMode.Create, _
      FileAccess.Write, FileShare.None)
    binFormat.Serialize(fStream, jbc)
    fStream.Close()
    Console.WriteLine("-> Saved JamesBondCar in binary format.")

    ' Now deserialize the object.
    fStream = File.OpenRead("CarData.dat")
    Dim carFromDisk As JamesBondCar = _
      CType(binFormat.Deserialize(fStream), JamesBondCar)
    Console.WriteLine("Can this car fly? : {0} ", carFromDisk.canFly)
    fStream.Close()

    ' Save object to a file named CarData.soap in SOAP format.
    Dim soapFormat As New SoapFormatter()
    fStream = New FileStream("CarData.soap", _
        FileMode.Create, FileAccess.Write, FileShare.None)
    soapFormat.Serialize(fStream, jbc)
    fStream.Close()
    Console.WriteLine("-> Saved JamesBondCar in SOAP format.")

    ' Now as an XML format. 
    Dim xmlFormat As New XmlSerializer(GetType(JamesBondCar), _
      New Type() {GetType(Radio), GetType(Car)})
    fStream = New FileStream("CarData.xml", FileMode.Create, _
      FileAccess.Write, FileShare.None)
    xmlFormat.Serialize(fStream, jbc)
    fStream.Close()
    Console.WriteLine("-> Saved JamesBondCar in XML format.")

    ' Now save a batch of objects. 
    Dim myCars As New List(Of JamesBondCar)()
    myCars.Add(New JamesBondCar(True, True))
    myCars.Add(New JamesBondCar(True, False))
    myCars.Add(New JamesBondCar(False, True))
    myCars.Add(New JamesBondCar(False, False))
    fStream = New FileStream("CarCollection.xml", FileMode.Create, FileAccess.Write, FileShare.None)
    xmlFormat = New XmlSerializer(GetType(List(Of JamesBondCar)), _
      New Type() {GetType(JamesBondCar), GetType(Car), GetType(Radio)})
    xmlFormat.Serialize(fStream, myCars)
    fStream.Close()
    Console.WriteLine("-> Saved List of JamesBondCar in XML format.")
    Console.WriteLine("Done!")
    Console.ReadLine()
  End Sub
End Module
