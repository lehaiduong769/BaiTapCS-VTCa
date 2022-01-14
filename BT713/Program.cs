using System;

namespace BT713
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            long s = tinhXn(n);
            Console.WriteLine($"S = {s}");
        }
            static long tinhXn(int n)
        {
            if (n == 0)
                return 1;
            long s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i * i * tinhXn(n - i);
            }
            return s;
        }
    }
}
