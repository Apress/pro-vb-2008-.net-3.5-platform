using System;
using System.Collections.Generic;
using System.Text;
using CarLibrary;

namespace CSharpCarClient
{
  public class PerformanceCar : SportsCar
  {
    // This C# type is deriving from the VB 2005 SportsCar.
    public override void TurboBoost()
    {
      Console.WriteLine("Zero to 60 in a cool 4.8 seconds...");
    }
  }
}
