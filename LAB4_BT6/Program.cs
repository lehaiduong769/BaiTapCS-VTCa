using System;

namespace LAB4_BT6
{
    class Program
    {

        static void Main(string[] args)
        {
            int n1 = 1, n2 = 1, n3, i, n;
            Console.Write("Nhap vao so n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");  
            for (i = 2; i < n; i++)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
