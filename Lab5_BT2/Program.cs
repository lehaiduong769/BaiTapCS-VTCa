using System;

namespace Lab5_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] aint  = new int[10];
            double[] adouble = new double[5];
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" aint[{0}] = ", i);
                aint[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" adouble[{0}] = ", i);
                adouble[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < aint.Length; i+=2)
            {
                aint[i] = 0;
            }

            for (int i = 0; i < adouble.Length; i++)
            {
                aint[2 * i + 1] = (int)adouble[i];
                
            }

            for (int i = 0; i < aint.Length; i++)
            {
                Console.WriteLine(aint[i]);
            }
           
        }

        }
}
