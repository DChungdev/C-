using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class TimUSCLN
    {
        public int sothu1 { get; set; }
        public int sothu2 { get; set; }
        public int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
    }
}
