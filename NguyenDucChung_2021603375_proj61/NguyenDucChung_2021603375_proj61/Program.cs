namespace NguyenDucChung_2021603375_proj61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> dsSV = new List<Student>();
            int c = 0;
            do
            {
                Console.WriteLine("=======MENU=======");
                Console.WriteLine("1.Them 1 sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Tim kiem sinh vien theo id");
                Console.WriteLine("4. Tim kiem sinh vien theo address");
                Console.WriteLine("5. Xoa sinh vien theo id");
                Console.WriteLine("6. Ket thuc chuong trinh");
                c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Student s1 = new Student();
                        s1.Input();
                        if (dsSV.Count == 0)
                        {
                            dsSV.Add(s1);
                            Console.WriteLine("Them thanh cong");
                            break;
                        }
                        foreach(Student s2 in dsSV)
                        {
                            if(s1.id == s2.id)
                            {
                                Console.WriteLine("ID khong duoc trung!");
                                break;
                            }
                            else
                            {
                                dsSV.Add(s1);
                                Console.WriteLine("Them thanh cong");
                                break;
                            }
                        }                       
                        break;
                    case 2:
                        foreach(Student s2 in dsSV)
                        {
                            s2.Output();
                        }
                        break;
                    case 3:
                        int id;
                        Console.Write("Nhap id sinh vien can tim: ");
                        id = int.Parse(Console.ReadLine());
                        foreach(Student s2 in dsSV)
                        {
                            if(id == s2.id)
                            {
                                s2.Output();
                            }
                        }
                        break;
                    case 4:
                        string address;
                        Console.Write("Nhap dia chi sinh vien can tim: ");
                        address = Console.ReadLine();
                        foreach(Student s2 in dsSV)
                        {
                            if (s2.address == address)
                                s2.Output();
                        }
                        break;
                    case 5:
                        int ID,count = 0;
                        Console.Write("Nhap id sinh vien can xoa: ");
                        ID=int.Parse(Console.ReadLine());
                        foreach(Student s2 in dsSV)
                        {
                            if(s2.id == ID)
                            {
                                dsSV.Remove(s2);
                                Console.WriteLine("Xoa thanh cong");
                                count++;
                                break;
                            }
                        }
                        if(count == 0)
                        {
                            Console.WriteLine("Khong sinh vien nao co ma {0}!", ID);
                        }
                        break;
                }
            } while (c != 6);
            
        }
    }
}