using System;

namespace LAB4_BT1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nhap vao so bat ky: ");
            int n = Convert.ToInt32 (Console.ReadLine());

            if (n == 1 || n <= 0)
            {
                Console.WriteLine("Nhap lai so khac ");
            }
            else
            {
                Console.WriteLine("Cac so chan tu 1 toi " + n + " la ");
                for ( int i =2; i <= n; i += 2)
                {
                    Console.Write(i + " ");
                }
            }
                                                                          
         }
    }
}
