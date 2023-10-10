using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucChung_2021603375_proj61
{
    public class Person
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Person() { }
        public Person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void Input()
        {
            Console.Write("ID: "); id = int.Parse(Console.ReadLine());
            Console.Write("Name: "); name = Console.ReadLine();
            Console.Write("Address: "); address = Console.ReadLine();
        }
        public void Output()
        {
            Console.Write(String.Format("{0,3}{1,20}{2,10}",id,name,address));
        }
    }
}
