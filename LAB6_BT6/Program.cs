using System;

namespace LAB6_BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr = new int[n];
            Console.WriteLine(" Nhap vao day 10 so nguyen: \n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());

            }
            foreach(int element in arr)
            {
                bool result = KTsohoanthien(element);
                if (result == true)
                {
                    Console.WriteLine(element);
                }
                else;
            }
        }
        static bool KTsohoanthien(int n)
        {
            int S = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    S += i;

            if (S == n)
                return true;
            return false;
        }
    }

}
