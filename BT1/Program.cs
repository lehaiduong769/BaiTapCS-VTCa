using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Input a string: ");
			string st = Console.ReadLine();
			Console.WriteLine("Input a char: ");
			char c = char.Parse(Console.ReadLine());
			int answer = 0;
			for (int i = 0; i < st.Length; i++)
			{
				if (st[i] == c)
				{
					answer++;
				}
			}
			Console.WriteLine($"The appereance's time of char in your string is: {answer}");
		}
    }
}
