using System;

namespace LAB5_BT4
{
    class Program
    {
        static void Main(string[] args)
        {

			int n = 10;
			int[] arr = new int[n];

			for (int i = 0; i < n; i++)
			{
				Console.Write(" a[{0}] = ", i);
				arr[i] = int.Parse(Console.ReadLine());
			}

			int max = arr[0], min = arr[0], countmin = 0, countmax = 0;
			
			foreach(int element in arr)
			{
				if (element > max)

				{
					max = element;
					countmax = 1;
				}
				else if (max == element) countmax++;

				if (element < min)
				{
					min = element;
					countmin = 1;
				}
				else if (min == element) countmin++;
			}

			Console.WriteLine("{0} la so lon nhat & lap lai {1} lan \n {2} la so nho nhat & lap lai {3} lan ",max, countmax, min, countmin);
			

         
		}
    }
}
