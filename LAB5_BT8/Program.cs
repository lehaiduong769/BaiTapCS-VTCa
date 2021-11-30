using System;

namespace LAB5_BT8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[10];
            Console.WriteLine("Nhap vao 10 ky tu chu cai thuong tu a - z: ");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                char ch = arr[i];
                {
                    if (char.IsLower(ch))
                    {
                        Console.Write(Char.ToUpper(ch));
                    }
                    else 
                    {
                        
                        Console.WriteLine(" Nhap lai ");
                        arr[i] = char.Parse(Console.ReadLine());
                    }
                }
            }
           

        }
    }
}
