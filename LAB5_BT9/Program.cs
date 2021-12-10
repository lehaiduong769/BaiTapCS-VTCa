using System;

namespace LAB5_BT9
{
    class Program
    {
		static void Main(string[] args)
		{
			string[] HocVien = { "HV 1", "HV 2", "HV 3", "HV 4", "HV 5" };
			decimal[] CF = new decimal[5];
			for (int i = 0; i < 5; i++)
			{
				Console.Write("CF[{0}] = ", i);
				CF[i] = decimal.Parse(Console.ReadLine());
			}
			decimal[] C = new decimal[5];
			for (int i = 0; i < 5; i++)
			{
				Console.Write("C[{0}] = ", i);
				C[i] = decimal.Parse(Console.ReadLine());
			}
			decimal[] HDJ = new decimal[5];
			for (int i = 0; i < 5; i++)
			{
				Console.Write("HDJ[{0}] = ", i);
				HDJ[i] = decimal.Parse(Console.ReadLine());
			}
			decimal[] DJ = new decimal[5];
			for (int i = 0; i < 5; i++)
			{
				Console.Write("DJ[{0}] = ", i);
				DJ[i] = decimal.Parse(Console.ReadLine());
			}
			decimal[] Java = new decimal[5];
			for (int i = 0; i < 5; i++)
			{
				Console.Write("Java[{0}] = ", i);
				Java[i] = decimal.Parse(Console.ReadLine());
			}
			decimal[] TB = new decimal[5];
			for (int i = 0; i < 5; i++)
			{
				TB[i] = (CF[i] + C[i] + HDJ[i] + DJ[i] + Java[i]) / 5;
			}
			Console.WriteLine("Tinh diem trung binh ");
			String data = String.Format("{0,-10} {1,-10} {2,-10} {3, -10} {4, -10} {5, -10} {6, -10} \n",
			"Hocvien", "CF", "C", "HDJ", "DJ", "Java", "TB");
			for (int index = 0; index < 5; index++)
				data += String.Format("{0, -10} {1,-10} {2,-10} {3, -10} {4, -10} {5, -10} {6, -10} \n",
				HocVien[index], CF[index], C[index], HDJ[index], DJ[index], Java[index], TB[index]);
			Console.WriteLine($"\n{data}");
		}
	

			/*int n = 6;
			int m = 6;
			Random rd = new Random();


			String st = String.Format("{0 , -10}|", "HOCVIEN");
			String cf = String.Format("{0}|", centeredString("CF", 10));
			String c = String.Format("{0}|", centeredString("C", 10));
			String hdj = String.Format("{0}|", centeredString("HDJ", 10));
			String dw = String.Format("{0}|", centeredString("DW", 10));
			String rdbms = String.Format("{0}|", centeredString("RDBMS", 10));
			String java = String.Format("{0}|", centeredString("JAVA", 10));
			String tb = String.Format("{0}|\n", centeredString("TB", 10));

			Console.Write(st + cf + c + hdj + dw + rdbms + java + tb);


			int[,] arr = new int[n, m];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					arr[i, j] = rd.Next(1, 10);
				}

			}

			for (int i = 0; i < n; i++)
			{
				String sthv = String.Format("{0, -10}|", "HV " + i);
				String sthvsum = sthv;
				for (int j = 0; j < m; j++)
				{
					sthv += String.Format("{0}|", centeredString(arr[i, j].ToString(), 10));
				}
				Console.WriteLine(sthv);

			}


		}
		static string centeredString(string s, int width)
		{
			if (s.Length >= width)
			{
				return s;
			}

			int leftPadding = (width - s.Length) / 2;
			int rightPadding = width - s.Length - leftPadding;

			return new string(' ', leftPadding) + s + new string(' ', rightPadding);
		}*/



	
    }
}
