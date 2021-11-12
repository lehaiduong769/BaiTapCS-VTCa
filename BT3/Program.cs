using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C = 0;
            Console.Write("Nhap So thu nhat: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap So thu hai: ");
            B = Convert.ToInt32(Console.ReadLine());
            C = A + B;
            Console.WriteLine("Tong cua " + A + " Va " + B + " La " + C);
            Console.ReadLine();
        }
    }
}
