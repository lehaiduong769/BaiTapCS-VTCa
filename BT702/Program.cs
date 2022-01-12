using System;

namespace BT702
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            long S;
            Console.WriteLine("Nhap n = ");
            n = int.Parse(Console.ReadLine());

            S = Tong(n);
            Console.WriteLine($"S = {S}");
        }
        static long Tong(int n)
        {
            if (n == 0) return 0;
            else return Tong(n - 1) + n;
        }
    }
}
