using System;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi ky tu");
            string str = Console.ReadLine();
            string strResult = "";
            
            str = str.Trim();
            while (str.IndexOf("  ") != -1)
            {
                str = str.Replace("  ", " ");
            }
            string[] substr = str.Split(' ');
           
            for (int i = 0; i < substr.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] == ' '))
                {
                    string firstchar = substr[i].Substring(0, 1);
                    string otherchar = substr[i].Substring(1);
                    substr[i] = firstchar.ToUpper() + otherchar.ToLower();
                    strResult += substr[i] + " ";
                   
                }
            }
            Console.WriteLine($"Chuoi sau khi duoc chuan hoa: {strResult} ");
            Console.ReadKey();
        }
    }
}
