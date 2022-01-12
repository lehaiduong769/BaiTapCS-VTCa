using System;

namespace BT704
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao so phan co trong mang: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(0, 10);
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
                
            }
                         
            Console.WriteLine("Tong cac so chan co trong mang la: {0}", TongChan(a,n));
        }

        static int TongChan(int [] a, int n)
        {

            if (n == 0)
                return 0;
            if (a[n - 1] % 2 == 0)
               return TongChan(a, n - 1) + a[n - 1];
            return TongChan(a, n - 1);
            //if(n == 0)
            //    return 0;
            //if(a[n - 1] % 2 == 0)   // xét phần tử cuối trước
            //    return tongChan(a, n - 1) + a[n - 1];
            //return tongChan(a, n - 1);
        }
      
    }
}
