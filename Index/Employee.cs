using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    public class Employee
    {
        public static double TAX = 0.03;
        public string Fname;
        public string Lname;
        public int Wage;
        public int LoggedHours;

        private double Calculate() => Wage * LoggedHours;
        private double CalculateTax() => Calculate()* TAX;
        private double CalculateNet() => Calculate()- CalculateTax();


        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Fname :{Fname}");
            Console.WriteLine($"Lname :{Lname}");
            Console.WriteLine($"Logged Hours :{LoggedHours}");
            Console.WriteLine($"Wage :{Wage}");
            Console.WriteLine($"Salary :{Calculate()}");
            Console.WriteLine($"deductable Tax : {TAX * 100}% , Tax Amount :{CalculateTax()}$");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Net Salary :{CalculateNet()}$");

        }


    }
}
