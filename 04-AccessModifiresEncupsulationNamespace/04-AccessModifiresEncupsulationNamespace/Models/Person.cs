using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    public class Person
    {
        private string name = "Test";
        public string surname;

        public Person()
        {
            
        }

        public void GetInfo()
        {
            //Console.WriteLine($"{this.name}");
        }
    }
}
