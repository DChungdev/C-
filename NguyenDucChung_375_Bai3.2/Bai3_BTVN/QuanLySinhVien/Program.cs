using System.Text;

namespace QuanLySinhVien
{
    internal class Program
    {
        struct SINH_VIEN
        {
            public int id;
            public string ten;
            public string gioiTinh;
            public int tuoi;
            public double diemToan;
            public double diemLy;
            public double diemHoa;
            public double diemTB;
            public string hocLuc
            {
                get
                {
                    if (diemTB >= 8)
                    {
                        return "Gioi";
                    }
                    else if (diemTB < 8 && diemTB > 6.5)
                    {
                        return "Kha";
                    }
                    else if (diemTB < 6.5 && diemTB >= 5)
                    {
                        return "Trung binh";
                    }
                    else { return "Yeu"; }
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                List<SINH_VIEN> dsSV = new List<SINH_VIEN>();
                using (StreamReader r = new StreamReader("student.txt"))
                {
                    while (r.Peek() != -1)
                    {
                        int i = dsSV.Count + 1;
                        string sv = r.ReadLine();
                        string[] line = sv.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        SINH_VIEN SV = new SINH_VIEN();
                        SV.id = int.Parse(line[0]);
                        SV.ten = line[1];
                        SV.gioiTinh = line[2];
                        SV.tuoi = int.Parse(line[3]);
                        SV.diemToan = double.Parse(line[4]);
                        SV.diemLy = double.Parse(line[5]);
                        SV.diemHoa = double.Parse(line[6]);
                        SV.diemTB = double.Parse(line[7]);
                        dsSV.Add(SV);
                    }
                    r.Close();
                }
                Menu(dsSV);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Menu(List<SINH_VIEN> dsSV)
        {
            char c;
            do
            {
                Console.WriteLine("\tMENU");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Thêm sinh viên.");
                Console.WriteLine("2. Cập nhật thông tin sinh viên bởi ID");
                Console.WriteLine("3. Xóa sinh viên bởi ID");
                Console.WriteLine("4. Tìm kiếm sinh viên theo tên.");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung binh");
                Console.WriteLine("6. Sắp xếp sinh viên theo tên");
                Console.WriteLine("7. Hiển thị danh sách sinh viên");
                Console.WriteLine("8. Ghi danh sách sinh viên vào file \"student.txt\"");
                c = char.Parse(Console.ReadLine());
                switch (c)
                {
                    case '1':
                        int i = dsSV.Count + 1;
                        SINH_VIEN sv = new SINH_VIEN();
                        sv.id = i;
                        ThemSV(dsSV, sv);                       
                        break;
                    case '2':
                        
                        UpdateSVByID(dsSV);
                        HienThiDSSV(dsSV);                       
                        break;
                    case '3':                      
                        DeleteSVByID(dsSV);                  
                        break;
                    case '4':
                        SearchSVByName(dsSV);                       
                        break;
                    case '5':
                        SapXepTheoDiemTB(dsSV);
                        break;
                    case '6':
                        SortByName(dsSV);
                        break;
                    case '7':
                        HienThiDSSV(dsSV);
                        break;
                    case '8':
                        using (StreamWriter sw = new StreamWriter("student.txt"))
                        {
                            // Duyệt qua danh sách sinh viên và ghi từng sinh viên vào file
                            foreach (SINH_VIEN s in dsSV)
                            {
                                sw.WriteLine(s.id + " " + s.ten + " " + s.gioiTinh + " " +
                                    s.tuoi + " " + s.diemToan + " " + s.diemLy + " " +
                                    s.diemHoa + " " + s.diemTB + " " + s.hocLuc);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Ban chon khong dung!");
                        break;
                }
            } while (c != '0');
        }

        private static void SortByName(List<SINH_VIEN> dsSV)
        {
            for (int i = 0; i < dsSV.Count - 1; i++)
            {
                for (int j = dsSV.Count - 1; j > 0; j--)
                {
                    if (String.Compare(dsSV[j].ten,dsSV[j - 1].ten) < 0)
                    {
                        SINH_VIEN tg = dsSV[j];
                        dsSV[j] = dsSV[j - 1];
                        dsSV[j - 1] = tg;
                    }
                }
            }
        }
        private static void SapXepTheoDiemTB(List<SINH_VIEN> dsSV)
        {
            for(int i = 0; i < dsSV.Count-1; i++)
            {
                for(int j = dsSV.Count - 1; j > 0; j--)
                {
                    if (dsSV[j].diemTB < dsSV[j-1].diemTB)
                    {
                        SINH_VIEN tg = dsSV[j];
                        dsSV[j] = dsSV[j - 1];
                        dsSV[j - 1] = tg;
                    }
                }
            }
        }
        private static void SearchSVByName(List<SINH_VIEN> dsSV)
        {
            string name;
            Console.WriteLine("Nhap vao ten sv can tim: ");
            name = Console.ReadLine();
            Console.WriteLine("SV co ten can tim:");
            foreach (SINH_VIEN s in dsSV)
            {
                if(s.ten == name)
                {
                    HienThiSV(s);
                }
            }
        }  
        private static void ThemSV(List<SINH_VIEN> dsSV, SINH_VIEN sv)
        {
            Console.WriteLine("Nhap thong tin sv: ");
            Console.Write("\tTen: "); sv.ten = Console.ReadLine();
            Console.Write("\tGioi tinh: "); sv.gioiTinh = Console.ReadLine();
            Console.Write("\tTuoi: "); sv.tuoi = int.Parse(Console.ReadLine());
            Console.Write("\tDiem toan: "); sv.diemToan = double.Parse(Console.ReadLine());
            Console.Write("\tDiem ly: "); sv.diemLy = double.Parse(Console.ReadLine());
            Console.Write("\tDiem hoa: "); sv.diemHoa = double.Parse(Console.ReadLine());
            Console.Write("\tDiem tb: "); sv.diemTB = double.Parse(Console.ReadLine());
            dsSV.Add(sv);
        }
        private static void DeleteSVByID(List<SINH_VIEN> dsSV)
        {
            int id;
            Console.Write("Nhap id sv can xoa: ");
            id = int.Parse(Console.ReadLine());
            if (!Check(dsSV, id)) return;
            foreach (SINH_VIEN v in dsSV)
            {
                if(v.id == id)
                {
                    dsSV.Remove(v); break;
                }
            }
        }

        private static void UpdateSVByID(List<SINH_VIEN> dsSV)
        {
            int id;
            Console.Write("Nhap id sv can cap nhat: ");
            id = int.Parse(Console.ReadLine());
            if(!Check(dsSV,id)) return;
            for (int i = 0; i < dsSV.Count; i++)
            {
                if (dsSV[i].id == id)
                {
                    SINH_VIEN sv = new SINH_VIEN();
                    sv.id = id;
                    Console.WriteLine("Nhap thong tin sv: ");
                    Console.Write("\tTen:"); sv.ten = Console.ReadLine();
                    Console.Write("\tGioi tinh:"); sv.gioiTinh = Console.ReadLine();
                    Console.Write("\tTuoi:"); sv.tuoi = int.Parse(Console.ReadLine());
                    Console.Write("\tDiem toan:"); sv.diemToan = double.Parse(Console.ReadLine());
                    Console.Write("\tDiem ly:"); sv.diemLy = double.Parse(Console.ReadLine());
                    Console.Write("\tDiem hoa:"); sv.diemHoa = double.Parse(Console.ReadLine());
                    Console.Write("\tDiem tb:"); sv.diemTB = double.Parse(Console.ReadLine());
                    dsSV[i] = sv;
                    break;
                }
            }
        }
        private static bool Check(List<SINH_VIEN> dsSV, int id)
        {
            foreach (SINH_VIEN sv in dsSV) { if (sv.id == id) { return true; } }
            return false;
        }
        private static void HienThiSV(SINH_VIEN s)
        {
            Console.WriteLine(s.id + "\t" + s.ten + "\t" + s.gioiTinh + "\t" +
                                    s.tuoi + "\t" + s.diemToan + "\t" + s.diemLy + "\t" +
                                    s.diemHoa + "\t" + s.diemTB + "\t" + s.hocLuc);
        }
        private static void HienThiDSSV(List<SINH_VIEN> dsSV)
        {
            foreach (SINH_VIEN s in dsSV)
            {
                HienThiSV(s);
            }
        }
    }
}