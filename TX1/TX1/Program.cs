namespace TX1
{
    internal class Program
    {
        static List<NhanVien> dsNV = new List<NhanVien>();
        static string s = String.Format("{0,-20}{1,-15}{2,6}{3,12}{4,10}\n","Ho ten","Dia chi","Ma NV","Chuc vu","Luong CB");
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                do
                {
                    Console.WriteLine("===MENU===");
                    Console.WriteLine("1. Them");
                    Console.WriteLine("2. Hien thi danh sach");
                    Console.WriteLine("3. Sap xep");
                    Console.WriteLine("4. Thoat");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            AddNV();
                            break;
                        case 2:
                            HienThiDS();
                            break;
                        case 3:
                            SapXep();
                            break;
                    }
                } while (i != 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SapXep()
        {
            dsNV.Sort();
        }

        private static void HienThiDS()
        {
            Console.WriteLine(s);
            foreach (NhanVien v in dsNV)
                v.Output();
        }

        private static void AddNV()
        {
            NhanVien nv = new NhanVien();
            nv.Input();
            foreach (NhanVien v in dsNV)
            {
                if (nv.MaNV == v.MaNV)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Khong them duoc do trung ma!");
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    return;
                }
            }         
            dsNV.Add(nv);
            Console.WriteLine("Them thanh cong");
        }
    }
}