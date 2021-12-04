using System;

namespace LAB6_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so diem: \n");
            double n = double.Parse(Console.ReadLine());
            QuiDoiDiem(n);
            Console.ReadKey();
        }
        static void QuiDoiDiem(double n)
        {
            if (n >= 8.5 && n <= 10)
            {
                Console.Write("A");
            }
            else if (n >= 7)
            {
                Console.Write("B");
            }
            else if (n >= 5.5)
            {
                Console.Write("C");
            }
            else if (n >= 4)
            {
                Console.Write("D");
            }
            else if (n >= 0)
            {
                Console.Write("F");
            }
            else
            {
                Console.Write("E");
            }
        }
    }
}
