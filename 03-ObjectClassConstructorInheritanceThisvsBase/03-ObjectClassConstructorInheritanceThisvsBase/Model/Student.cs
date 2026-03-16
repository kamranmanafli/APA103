using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Model
{
    internal class Student : Person
    {
        public string StudentNumber;
        public string Faculty;
        public double OrtaBal;
        public int Kurs;

        public Student(string firstname, string lastname, int age, string email, string id,
                string studentnumber, string faculity, double gpa, int course)
            : base(firstname, lastname, age, email, id)
        {
            this.StudentNumber = studentnumber;
            this.Faculty = faculity;
            this.OrtaBal = gpa;
            this.Kurs = course;

        }

        public void ShowStudentInfo()
        {
            ShowBasicInfo();
            Console.WriteLine($"Student Number: {StudentNumber}");
            Console.WriteLine($"Faculty: {Faculty}");
            Console.WriteLine($"GPA: {OrtaBal}");
            Console.WriteLine($"Course: {Kurs}");

        }

        public int CalculateScholarship()
        {
            if (OrtaBal >= 90)
            {
                return 500;
            }
            else if (OrtaBal >= 80)
            {
                return 350;
            }
            else if (OrtaBal >= 70)
            {
                return 200;

            } else
            {
                return 0;
            }
        }

    }
}
