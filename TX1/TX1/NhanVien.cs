using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX1
{
    internal class NhanVien:Person, IComparable<NhanVien>
    {
        private int maNV;
        private string chucVu;
        private double luongCB;
        public int MaNV { get => maNV; set => maNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public double LuongCB { get => luongCB; set => luongCB = value; }
        public int TinhHSCV()
        {
            if(String.Compare(ChucVu,"Giam doc",true) == 0)
            {
                return 10;
            }
            else if (String.Compare(ChucVu, "Pho giam doc", true) == 0 || String.Compare(ChucVu, "Truong phong", true) == 0)
            {
                return 6;
            }
            else if (String.Compare(ChucVu, "Pho phong", true) == 0)
            {
                return 4;
            }
            else
            {
                return 2;
            }
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ma nv:"); maNV = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chuc vu:"); chucVu = Console.ReadLine();
            Console.WriteLine("Nhap luong co ban:"); luongCB = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            base.Output();
            Console.Write("{0,6}{1,12}{2,10:0.00}\n",MaNV,ChucVu,LuongCB);
        }

        public int CompareTo(NhanVien? other)
        {
            NhanVien nv = (NhanVien)other;
            if(TinhHSCV() == nv.TinhHSCV())
            {
                return (int)(LuongCB - nv.LuongCB);
            }
            return TinhHSCV() - nv.TinhHSCV();
        }
    }
}
