using System;

namespace LAB6_BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao day 10 so nguyen: \n");
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Day cac so nguyen to la: \n");
            foreach(int element in arr)
            {
                if (CheckNumber(element) == true)
                {
                    Console.WriteLine(element);
                }
             
            }

        }
        static bool CheckNumber(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }


    }
}
