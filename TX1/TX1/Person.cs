using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1
{
    internal class Person
    {
        private string hoTen;
        private string diaChi;
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public void Input()
        {
            Console.WriteLine("Nhap ho ten:"); HoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:"); DiaChi = Console.ReadLine();
        }
        public void Output()
        {
            Console.Write("{0,-20}{1,-15}",HoTen,DiaChi);
        }
    }
}
