namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            //Dat break poin an F11 de chay dong break
            nv.Nhap(1, "Chung", DateTime.Now, 1.5);
            Console.WriteLine(" ");
            Console.WriteLine(nv);
        }
    }
}