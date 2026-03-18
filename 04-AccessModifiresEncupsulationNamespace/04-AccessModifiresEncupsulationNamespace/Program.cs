using System.Reflection;
using _04_AccessModifiresEncupsulationNamespace.Models;
internal class Program
{

    static void Main(string[] args)
    {
        //Person person = new Person();


        //typeof(Person).GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "APA103");



        //var newName = typeof(Person).GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);


        //Console.WriteLine(newName);

        Car car = new Car();

        car.HorsePower = 50;
        Console.WriteLine(car.HorsePower);
    }
}
