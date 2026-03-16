using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Model
{
    internal class Teacher : Person
    {
        public string Department;
        public string MainSubject;
        public decimal BaseSalary;
        public int ExperienceYears;

        public Teacher(string firstname, string lastname, int age, string email, string id, string department, string mainsubject, decimal basesalary, int experienceyears) : base(firstname, lastname, age, email, id)
        {
            this.Department = department;
            this.MainSubject = mainsubject;
            this.BaseSalary = basesalary;
            this.ExperienceYears = experienceyears;
        }

        public void ShowTeacherInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Department {Department}");
            Console.WriteLine($"Main Subject {MainSubject}");
            Console.WriteLine($"Base Salary {BaseSalary}");
            Console.WriteLine($"Experiance Years {ExperienceYears}");
        }

        public decimal CalculateSalary()
        {
            return BaseSalary + (ExperienceYears * 50);
        }

    }


}
