using _06_InterfaceAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction.Models
{
    public class Calculation : ICalculation
    {
        public double Calculate(double a, double b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;

                case '-':
                    return a - b;

                case '*':
                    return a * b;

                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("0 - a bolmek olmaz");
                        return 0;
                    }
                    return a / b;

                default:
                    Console.WriteLine("Yanlis emeliyyat!");
                    return 0;
            }
        }
    }
}
