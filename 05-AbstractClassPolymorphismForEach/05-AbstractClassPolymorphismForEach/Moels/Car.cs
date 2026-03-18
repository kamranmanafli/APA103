using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Moels
{
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string brand, string model, int year, string platenumber, int doors, int trunk, bool isAuto, int maxSpeed) : base (brand, model, year, platenumber)
        {
            this.DoorsCount = doors;
            this.TrunkCapacity = trunk;
            this.IsAutomatic = isAuto;
            this.MaxSpeed = maxSpeed;
        }

        public void ShowCarInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Doors: {DoorsCount}, Trunk: {TrunkCapacity}, Auto: {IsAutomatic}, Max Speed: {MaxSpeed} ");
        }

        public override double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 8 * 1.50;
        }
    }
}
