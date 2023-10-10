using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoaTX1
{
    public class Person
    {
        private string hoTen { get; set; }
        private string diaChi { get; set; }
        public void Input()
        {
            Console.Write("Nhap ho ten:"); hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi:"); diaChi = Console.ReadLine();
        }
        public void Output()
        {
            Console.Write(String.Format("{0,15}{1,15}",hoTen,diaChi));
        }
    }
}
