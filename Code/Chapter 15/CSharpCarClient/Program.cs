using System;
using System.Collections.Generic;
using System.Text;
using CarLibrary;

namespace CSharpCarClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with C# *****");

      // Make a sports car.
      SportsCar viper = new SportsCar("Viper", 240, 40);
      viper.TurboBoost();

      // Make a mini van.
      MiniVan mv = new MiniVan();
      mv.TurboBoost();

      // Make a performance car.
      PerformanceCar dreamCar = new PerformanceCar();
      // Inherited property.
      dreamCar.PetName = "Hank";
      dreamCar.TurboBoost();
      Console.ReadLine();
    }
  }
}
