using System;

namespace Index
{
    public class Report
    {

        public delegate bool ForSales(Emp e);
        public void Process(Emp[] employees,string title,ForSales process)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (Emp emp in employees)
            {
                if(process(emp))
                {
                    Console.WriteLine($"{emp.Id} || {emp.Name} || {emp.Gender} || {emp.TotalSales}");
                }
            }
                Console.Write("\n");
        }
    }
}
