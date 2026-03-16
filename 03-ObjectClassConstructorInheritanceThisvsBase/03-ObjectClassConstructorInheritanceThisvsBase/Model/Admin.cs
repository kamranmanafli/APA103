using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Model
{
    internal class Admin : Person
    {
        public string Position;
        public string Department;
        public int AccessLevel;

        public Admin(string firstname, string lastname, int age, string email, string id, string position, string department, int accessLevel) : base(firstname, lastname, age, email, id)
        {
            this.Position = position;
            this.Department = department;
            this.AccessLevel = accessLevel;
        }

        public void ShowAdminInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Position{Position}");
            Console.WriteLine($"Department{Department}");
            Console.WriteLine($"Access Level{AccessLevel}");
        }

        public void GrantAcces(Student student)
        {
            Console.WriteLine($"{GetFullName()} adli admin {student.GetFullName()} telebesine sisteme giris icazesi verdi.");
        }

    }
}
