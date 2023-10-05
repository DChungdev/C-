using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        const int PRICE = 50;
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int workingdays { get; set; }
        public double salary
        {
            get
            {
                return workingdays * PRICE;
            }
        }
        public void Input()
        {
            Console.WriteLine("Enter employee's information:");
            Console.Write("Id: "); id = Console.ReadLine();
            Console.Write("Name: "); name = Console.ReadLine();
            Console.Write("Age: "); age = int.Parse(Console.ReadLine());
            Console.Write("Working day: "); workingdays = int.Parse(Console.ReadLine());           
        }
        public void Output()
        {
            Console.WriteLine("Employee's information:");
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Working day: "+workingdays);
            Console.WriteLine("Salary: " + salary);
        }
    }
}
