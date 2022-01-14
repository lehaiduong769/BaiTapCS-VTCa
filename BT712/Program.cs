using System;

namespace BT712
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());

            long kq1 = TinhXn(n);
            long kq2 = TinhYn(n);

            Console.WriteLine($"X({n}) = {kq1}, Y({n}) = {kq2}");
        }
        static long TinhXn(int n)
        {
            if (n == 0) return 1;
            else return TinhXn(n - 1) + TinhYn(n - 1);
        }
        static long TinhYn(int n)
        {
            if (n == 0) return 0;
            else return 3 * TinhXn(n - 1) + 2 * TinhYn(n - 1);
        }
    }
}
