using System;
using _03_ObjectClassConstructorInheritanceThisvsBase.Model;

public class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Mike", "Bridhgerton", 20, "Mike@gmail.com", "cl001", "ST1001", "IT", 88.5, 2);
        Student s2 = new Student("Aydin", "Nasirov", 18, "Aydin@gmail.com", "cl002", "ST1002", "Economics", 92.1, 3);
        Student s3 = new Student("Bob", "Casper", 35, "Bob_pro-gamer@gmail.com", "cl003", "ST1003", "Software Engineering", 92.1, 3);

        Teacher t1 = new Teacher("Seid", "Nuraliyev", 24, "saidnuraliyev@mail.com", "T001", "Computer Science", "Programming", 800, 15);
        Teacher t2 = new Teacher("Damla", "Recebova", 21, "damlarajabova@mail.com", "T002", "Information Technology", "Database", 800, 8);

        Admin admin = new Admin("Bill", "Frank", 51, "billfrank1975@gmail.com", "A001", "Dekan", "IT", 5);


        Console.WriteLine("STUDENTS");

        s1.ShowStudentInfo();
        Console.WriteLine("Scholarship: " + s1.CalculateScholarship() + " AZN");

        s2.ShowStudentInfo();
        Console.WriteLine("Scholarship: " + s2.CalculateScholarship() + " AZN");

        s2.ShowStudentInfo();
        Console.WriteLine("Scholarship: " + s2.CalculateScholarship() + " AZN");

        Console.WriteLine("TEACHERS");

        t1.ShowTeacherInfo();
        Console.WriteLine("Salary :" + t1.CalculateSalary() + " AZN");

        t2.ShowTeacherInfo();
        Console.WriteLine("Salary :" + t2.CalculateSalary() + " AZN");

        Console.WriteLine("ADMIN");
        admin.GetFullName();

        admin.GrantAcces(s1);


        int totalScholarship = s1.CalculateScholarship() + s2.CalculateScholarship() + s3.CalculateScholarship();

        decimal totalSalary = t1.CalculateSalary() + t2.CalculateSalary();

        Console.WriteLine("Total Scholarship: " + totalScholarship + " AZN");
        Console.WriteLine("Total Salary: " + totalSalary + " AZN");






    }




}



























