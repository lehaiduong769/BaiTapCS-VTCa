using System;

namespace Lab5_BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.Write("Nhap vao phan tu x = ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int countx = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == x) countx++;
                arr[0] = x;
                Console.WriteLine(arr[i]);
            }
            
            
        }
    }
}
