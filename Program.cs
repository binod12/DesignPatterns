using DesignPatterns.Creational.Build;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
  
  class Program
  {
    
    public static void Main(string[] args)
    {
      VehicleCreator vehicleCreator = new VehicleCreator(new CarBuilder());

      var vehicle = vehicleCreator.CreateVehicle();
      Console.WriteLine(vehicle.Engine);
      Console.WriteLine(vehicle.Transmission);
    }
  }
}
