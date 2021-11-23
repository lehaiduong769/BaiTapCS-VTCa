using System;

namespace LAB4_BT1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so bat ky: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("Nhap lai so khac: ");
            }
            
            else
            {
                Console.Write($"Cac so nguyen to tu 1 den {n} la :");

                int kt, j;
                int i = 2;
                while (i <= n)
                {
                    kt = 1;
                    j = 2;
                    while (j <= i / 2)
                    {
                        if (i % j == 0)
                        {
                            kt = 0;
                            break;
                        }
                        j++;
                    }
                    if (kt == 1)
                    {
                        Console.Write(i + " ");
                    }
                    i++;
                }

                }

            }
    }
}
