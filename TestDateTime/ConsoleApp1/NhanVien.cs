using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NhanVien
    {
        #region bien
        private int maNV;
        private string hoTen;
        //probfull tab tab
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private double heSoLuong;

        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }
        public int MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        #endregion
        #region Phuong thuc
           public void Nhap(int maNV, string hoTen, DateTime ngaySinh, double heSoLuong)
           {
                MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
           } 
        public double TinhLuong()
        {
            return HeSoLuong * 18000000;
        }
        public override string ToString()
        {
            return String.Format("{0,-15}{1,-20}{2,10:d}{3,15:0.0}{4,15:N0}",MaNV,HoTen,NgaySinh,HeSoLuong,TinhLuong());

        }
        #endregion
    }
}
