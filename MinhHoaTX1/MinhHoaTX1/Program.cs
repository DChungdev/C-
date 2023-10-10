namespace MinhHoaTX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> dsNV = new List<NhanVien>();
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
                        NhanVien nv1 = new NhanVien();
                        nv1.Input();
                        if(dsNV.Count == 0)
                        {
                            dsNV.Add(nv1);
                            Console.WriteLine("Them thanh cong");
                            break;
                        }
                        int c = 0;
                        foreach(NhanVien nv in dsNV)
                        {
                            if(nv1.MaNV == nv.MaNV)
                            {
                                Console.WriteLine("Khong duoc trung ma!");
                                c++;
                                break;
                            }
                        }
                        if (c == 0)
                        {
                            dsNV.Add(nv1);
                            Console.WriteLine("Them thanh cong");
                        }
                        break;
                    case 2:
                        foreach (NhanVien nv in dsNV)
                        {
                            nv.Output();
                        }
                        break;
                    case 3:
                        dsNV.Sort();
                        Console.WriteLine("Da sap xep xong");
                        break;
                }
            } while (i != 4);     
        }
    }
}