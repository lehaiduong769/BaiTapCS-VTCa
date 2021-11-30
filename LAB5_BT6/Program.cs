using System;

namespace LAB5_BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[20];
            Random r = new Random();
            Console.Write(" Nhap vao so nguyen x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Day 20 so ngau nhien la: ");

            for (int i = 0; i < 20; i++)
          
            {
               arr[i] = r.Next(100);
               Console.WriteLine(arr[i]);
                
            }
            Console.Write(" Cac so trong mang chia het cho x la: ");
            foreach(int element in arr)
            {
                if (element % x == 0)
                {
                    Console.WriteLine(element);
                }
            }
            

        }
    }
}
