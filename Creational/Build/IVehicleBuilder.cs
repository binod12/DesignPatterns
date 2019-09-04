using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Build
{
  public class VehicleCreator
  {
    private readonly IVehicleBuilder _vehicleBuilder;
    public VehicleCreator(IVehicleBuilder vehicleBuilder)
    {
      _vehicleBuilder = vehicleBuilder;
    }
    public Vehicle CreateVehicle()
    {
      var vehicle = _vehicleBuilder.GetVehicle();
      _vehicleBuilder.SetEngine();
      _vehicleBuilder.SetTransmission();
      return vehicle;
    }
  }
  
  public class CarBuilder : IVehicleBuilder
  {
    private Vehicle _vehicle = new Vehicle();
    public Vehicle GetVehicle()
    {
      return _vehicle;
    }

    public void SetEngine()
    {
      _vehicle.Engine = "CAR Engine Set";
    }

    public void SetTransmission()
    {
      _vehicle.Transmission = "CAR Transmission Set";
    }
  }

  public class SUVBuilder : IVehicleBuilder
  {
    private Vehicle _vehicle = new Vehicle();

    public Vehicle GetVehicle()
    {
      return _vehicle;
    }

    public void SetEngine()
    {
      _vehicle.Engine = "SUV Engine Set";
    }

    public void SetTransmission()
    {
      _vehicle.Transmission = "SUV Transmission Set";
    }
  }
  public class Vehicle
  {
    public string Engine { get; set; }
    public string Transmission { get; set; }
  }

  public interface IVehicleBuilder
  {
    void SetEngine();
    void SetTransmission();

    Vehicle GetVehicle();
  }
}
