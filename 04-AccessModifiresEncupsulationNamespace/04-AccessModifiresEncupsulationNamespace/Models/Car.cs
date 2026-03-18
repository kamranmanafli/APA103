using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    public class Car
    {
        public string _model;
        private int _horsePower;


        public int HorsePower 
        {
            get
            {
                if (_horsePower < 100)
                {
                    Console.WriteLine("can't drive");
                }

                return _horsePower;
            }
            set
            {
                if(value < 100 )
                {
                    Console.WriteLine("Please enter valid power");
                }

                _horsePower = value;
                Console.WriteLine($"Set olundu:{_horsePower }");
            } 
        }
    }
}  
