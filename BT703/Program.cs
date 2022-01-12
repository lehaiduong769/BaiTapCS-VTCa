using System;

namespace BT703
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            long T;
            Console.WriteLine("Nhap n = ");
            n = int.Parse(Console.ReadLine());

            T = GiaiThua(n);
            Console.WriteLine($"T = {T}");
        }
        static long GiaiThua(int n)
        {
            if (n == 0) return 1;
            return GiaiThua(n - 1) * n;
        }
    }
}
