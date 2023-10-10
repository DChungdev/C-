using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhHoaTX1
{
    public class NhanVien: Person, IComparable
    {
        private int maNV;
        public int MaNV { get => maNV; set => maNV = value; }
        private string chucVu { get; set; }
        private double luongCB { get; set; }
        public void Input()
        {
            base.Input();
            Console.Write("Nhap ma NV:"); MaNV = int.Parse(Console.ReadLine());
            Console.Write("Nhap chucVu:"); chucVu = Console.ReadLine();
            Console.Write("Nhap luong co ban:"); luongCB = double.Parse(Console.ReadLine());
        }
        public int TinhHSCV()
        {
            if(chucVu.Equals("Giam doc"))
            {
                return 10;
            }
            else if (chucVu.Equals("Pho giam doc") || chucVu.Equals("Truong phong"))
            {
                return 6;
            }
            else if (chucVu.Equals("Pho phong"))
            {
                return 4;
            }
            else { return 2;}
        }
        public void Output()
        {
            base.Output();
            Console.WriteLine(String.Format("{0,5}{1,15}{2,8}\n",maNV,chucVu,luongCB));
        }

        public int CompareTo(object? obj)
        {
            NhanVien nv = (NhanVien)obj;
            if (TinhHSCV() == nv.TinhHSCV())
            {
                return ((int)(this.luongCB - nv.luongCB));
            }
            return TinhHSCV() - nv.TinhHSCV();
        }
    }
}
