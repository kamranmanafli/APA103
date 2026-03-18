using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Moels
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year{ get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }

        public Vehicle(string brand, string model, int year,string platenumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = platenumber;
            this.FuelLevel = 100;
        }

        public string GetVehicleInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}, Plate: {PlateNumber}, Fuel: {FuelLevel}";
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine(GetVehicleInfo());
        }
        public abstract double CalculateFuelCost(double distance);
    }
}
