using System;

namespace BT705
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao so phan tu co trong mang : ");
            n = int.Parse(Console.ReadLine());
            float[] a = new float[n];
            Input(a, n);
            Console.Write("So luong so nguyen duong trong mang la: " + NumOfPossive(a, n));
        }
        static void Input(float [] a, int n)
        {
        
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = {1}", i, a[i]);
                a[i] = float.Parse(Console.ReadLine());
            }
        }
        static int NumOfPossive(float[] a, int n)
        {
            if (n == 0) return 0;
            if (a[n - 1] > 0) return 1 + NumOfPossive(a, n - 1);
            return NumOfPossive(a, n - 1);
        }
    
    }
}
