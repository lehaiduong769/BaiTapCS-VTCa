using System;

namespace LAB5_BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach(int element in arr)
            {
                int count = 0;
                for( int i = 2; i < element; i++)
                {
                    if (element % i == 0) count++;
                }
                if (count == 0)
                {
                    Console.WriteLine( element + " ");
                }
                else
                {
                    Console.WriteLine(" Nhap lai day 5 SNT");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(" arr[{0}] = ", i);
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                }
                
            }

        }
       
    }
}

