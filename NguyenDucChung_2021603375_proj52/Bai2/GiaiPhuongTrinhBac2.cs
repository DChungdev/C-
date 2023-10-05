using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class GiaiPhuongTrinhBac2
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Giai()
        {
            if (a == 0)
            {
                Console.WriteLine("a phai khac 0!");
                return;
            }
            double delta = b * b - 4 * a * c;
            if (delta < 0) Console.WriteLine("PT vo nghiem");
            else if (delta == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("PT co nghiem kep x1 = x2 = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / 2*a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("PT cos 2 nghiem phan biet: ");
                Console.WriteLine("\tx1 = " + x1);
                Console.WriteLine("\tx2 = " + x2);
            }
        }
    }
}
