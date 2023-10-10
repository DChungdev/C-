using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucChung_2021603375_proj61
{
    public class Student: Person
    {
        public byte maths { get; set; }
        public byte physics { get; set; }
        public Student() { }
        public Student(int id, string name, string address, byte math,  byte physics): base(id, name, address)
        {
            this.maths = math;
            this.physics = physics;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Maths: "); maths = byte.Parse(Console.ReadLine());
            Console.Write("Physics: "); physics = byte.Parse(Console.ReadLine());
        }
        public void Output()
        {
            base.Output();
            Console.Write(String.Format("{0,5}{1,5}\n", maths, physics));
        }
        public int Total()
        {
            return (maths + physics);
        }
    }
}
