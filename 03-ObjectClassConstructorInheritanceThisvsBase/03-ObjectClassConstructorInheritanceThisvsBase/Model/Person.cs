using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Model
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public string email;
        public string Id;


        public Person(string firstname, string lastname, int age, string email, string id)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
            this.email = email;
            this.Id = id;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Ad: {firstName}");
            Console.WriteLine($"Soyad: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Email: {email}");
        }

    }
}
