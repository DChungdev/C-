namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int n;
            Console.Write("Nhap so cap: ");          
            n = int.Parse(Console.ReadLine());
            TimUSCLN[] ds = new TimUSCLN[n];
            for (int i = 0; i < n; i++)
            {
                ds[i] = new TimUSCLN();
                Console.WriteLine("Cap thu "+(i+1));
                Console.Write("\tSo thu 1: "); ds[i].sothu1 = int.Parse(Console.ReadLine());
                Console.Write("\tSo thu 2: "); ds[i].sothu2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Danh sach doi tuong cung UCLN:");
            foreach (TimUSCLN i in ds)
            {
                Console.WriteLine("So thu 1: "+i.sothu1+ "; So thu 2: "+i.sothu2+ "; USCLN: "+i.USCLN(i.sothu1,i.sothu2));
            }
        }
    }
}