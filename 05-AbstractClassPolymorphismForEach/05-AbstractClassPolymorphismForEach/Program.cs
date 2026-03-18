using _05_AbstractClassPolymorphismForEach.Moels;

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        var car1 = new Car("Mercedes", "E200", 2023, "10-AA-001", 4, 500, true, 220);
        var car2 = new Car("BMW", "320i", 2022, "10-ON-010", 4, 480, true, 235);
        var car3 = new Car("Toyota", "Camry", 2021, "10-VV-444", 4, 524, true, 210);

        var m1 = new Motorcycle("Yamaha", "R1", 2023, "10-V-444", 998, false, 299, "sport");
        var m2 = new Motorcycle("Harley-Davidson", "HD", 2021, "10-V-111", 1868, true, 180, "Cruiser");

        var t1 = new Truck("MAN", "TGX", 2020, "77-VV-111", 18, 3, 12, 120);
        var t2 = new Truck("Volvo", "FH16", 2021, "77-KM-111", 25, 4, 18, 110);

        vehicles.AddRange(new Vehicle[] { car1, car2, car3, m1, m2, t1, t2 });

        double totalSpeed = 0;
        double maxCost = 0;
        Vehicle expensiveVehicle = null;

        foreach (var v in vehicles)
        {
            if (v is Car c)
            {
                c.ShowBasicInfo();
                double cost = c.CalculateFuelCost(500);
                Console.WriteLine($"Fuel cost (500 km): {cost}");
                totalSpeed += c.MaxSpeed;

                if (cost > maxCost)
                {
                    maxCost = cost;
                    expensiveVehicle = c;
                }
            }
            else if (v is Motorcycle m)
            {
                m.ShowBasicInfo();
                double cost = m.CalculateFuelCost(300);
                Console.WriteLine($"Fuel cost (300 km): {cost}");
                totalSpeed += m.MaxSpeed;

                if (cost > maxCost)
                {
                    maxCost = cost;
                    expensiveVehicle = m;
                }

            }
            else if (v is Truck t)
            {
                t.ShowBasicInfo();
                double cost = t.CalculateFuelCost(800);
                Console.WriteLine($"Fuel cost(800 km): {cost}");
                totalSpeed += t.MaxSpeed;

                if (cost > maxCost)
                {
                    maxCost = cost;
                    expensiveVehicle = t;
                }
            }

        }

        t1.LoadCargo(5);
        Console.WriteLine("After loading 5 tons");
        Console.WriteLine(t1.CalculateFuelCost(800));

        Console.WriteLine($"Total vehicles: {vehicles.Count}");
        Console.WriteLine($"Avarage max speed: {totalSpeed / vehicles.Count}");
        Console.WriteLine($"Most expensive fuel cost: {maxCost}");
    }
}














