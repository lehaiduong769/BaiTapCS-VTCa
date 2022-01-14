using System;

namespace BT710

{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            int n;

            Console.Write("Nhap x = ");
            x = float.Parse(Console.ReadLine());

            Console.Write("Nhap n = ");
            n = int.Parse(Console.ReadLine());

            float kq = Tinh(x, n);
            Console.WriteLine($"S({x}, {n}) = {kq}");
        }

        static float Tinh(float x, int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return x;
            return (1 + x / n) * Tinh(x, n - 1) - (x / n) * Tinh(x, n - 2);
        }
    }
}
