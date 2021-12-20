using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Console.ReadLine();
            int i = 0;
            int j = s.Length - 1;
            string before = "";
            string after = "";
            for (; i < s.Length/2; i++)
            {
                before += s[i].ToString().ToLower();
            }
            //length even
            if (s.Length % 2 == 0)
            {
                for (; j >= s.Length / 2; j--)
                {
                    after += s[j].ToString().ToLower();
                }
            }
            //length odd
            else
            {
                for (; j > s.Length / 2; j--)
                {
                    after += s[j].ToString().ToLower();
                }
            }
           
            if (after == before )
            {
                Console.WriteLine($"{s} is Palindrome");
            }
            else Console.WriteLine($"{s} is not Palindrome");
        }
    }
}
