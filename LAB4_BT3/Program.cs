using System;

namespace LAB4_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = m; i <= n; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
