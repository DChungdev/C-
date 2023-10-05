using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucChung_2021603375_proj41
{
    public class Person
    {
        public string id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public void CheckAge(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("Ban du tuoi bau cu");
            }
            else
            {
                Console.WriteLine("Ban con nho");
            }
        }
        public void Input()
        {
            Console.Write("Enter ID: "); id = Console.ReadLine();
            Console.Write("Enter Name: "); name = Console.ReadLine();
            Console.Write("Enter Age: "); age = int.Parse(Console.ReadLine());
            Console.Write("Enter Email: "); email = Console.ReadLine();
            Console.Write("Enter Address: "); address = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Email: " + email);
        }
    }
}
