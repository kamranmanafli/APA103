using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Moels
{
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck(string brand, string model, int year, string plateNumber, double capacity, int axle, double load, int maxSpeed) : base(brand, model, year, plateNumber)
        {
            this.CargoCapacity = capacity;
            this.AxleCount = axle;
            this.CurrentLoad = load;
            this.MaxSpeed = maxSpeed;
        }

        public void ShowTruckInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Capacity: {CargoCapacity}, Load: {CurrentLoad}, Axles: {AxleCount}, MaxSpeed: {MaxSpeed}");
        }

        public void LoadCargo(double weight)
        {
            if( CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad += weight;
            }
            else
            {
                Console.WriteLine("Yuk limiti asilir!");
            }
        }

        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }
    }
}
