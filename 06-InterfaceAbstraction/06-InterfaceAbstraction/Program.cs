using _06_InterfaceAbstraction.Interfaces;
using _06_InterfaceAbstraction.Models;
using System;
class Program
{
    static void Main()
    {
        ICalculation calculator = new Calculation();

        Console.WriteLine("Birinci ededi daxil edin: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Emeliyyat daxil edin (+,-,*,/): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Ikinci ededi daxil edin: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = calculator.Calculate(a, b, op);

        Console.WriteLine($"Netice: {result}");
    }
}













