namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student("1");
            Student st3 = new Student("2","Chung",8);
            st1.Output();
            st2.Output();
            st3.Output();
        }
    }
}