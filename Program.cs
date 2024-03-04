using System;

namespace exp3
{
    public class Employee
    {
        public string name, designation;
        public int basicSalary, noofexp, insurance;
        public double hra, ta, grosspay;
        public Employee(string name, string designation, int bsalary, int noofexp, int insurance)
        {
            this.name = name;
            this.designation = designation;
            this.basicSalary = bsalary;
            this.noofexp = noofexp;
            this.insurance = insurance;

            hra = (0.1) * basicSalary;
            ta = (0.2) * basicSalary;
            grosspay = (0.15) * basicSalary;
        }
        public double salary()
        {
            return basicSalary + hra + ta - insurance - grosspay;

        }

        public void Display()
        {
            Console.WriteLine("\nEmployee Name: " + name);
            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee No of Experience: " + noofexp);
            Console.WriteLine("Employee Basic Salary: " + basicSalary);
            Console.WriteLine("Employee HRA: " + hra);
            Console.WriteLine("Employee TA: " + ta);
            Console.WriteLine("Employee GROSSPAY: " + grosspay);
            Console.WriteLine("Employee Salary: " + salary());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Jayabharathi", "Cyber Security Analyst", 80000,5, 6000);
            emp1.Display();
            Employee emp2 = new Employee("Meera", "Frontend Developer", 75000,6, 5000);
            emp2.Display();
            Console.ReadLine();
        }
    }

}