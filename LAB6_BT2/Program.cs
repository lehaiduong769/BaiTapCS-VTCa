using System;

namespace LAB6_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            
            Console.WriteLine(power(x,m));
        }
        static int power (int a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int result = 1;
                for (int i = 0; i < n; i++)
                {
                    result *= a;
                }
                
                return result;
            }

        }
    }
}
