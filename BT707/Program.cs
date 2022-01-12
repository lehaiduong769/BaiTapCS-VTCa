using System;

namespace BT707
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci Series

            Console.WriteLine("Nhap vao vi tri so fibonacci can tim: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua = {0}", Fibonacci(n));
        }
        static long Fibonacci(int n)
        {
            if (n < 2) return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
