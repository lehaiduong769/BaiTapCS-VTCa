using System;
using System.Collections;

namespace BT2_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, n;
            Stack stack = new Stack();
            Console.WriteLine(" Nhap so phan tu muon khoi tao trong Stack: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stack.Push(new Random().Next(0, 10));
            }
            do
            {
                Console.WriteLine("Demo cac thao tac tren Stack so nguyen C#");
                Console.WriteLine("=========================================");
                Console.WriteLine("1.   Khoi tao Stack");
                Console.WriteLine("2.   Them mot phan tu vao Stack");
                Console.WriteLine("3.   Lay phan tu dau ra khoi Stack");
                Console.WriteLine("4.   Xem phan tu dau cua Stack");
                Console.WriteLine("5.   Duyet Stack");
                Console.WriteLine("0.   Thoat chuong trinh");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ds cac phan tu duoc khoi tao trong STack: ");
                        foreach (int num in stack)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine(); break;

                    case 2:
                        Console.WriteLine("Nhap vao gia tri phan tu muon them vao Stack: ");
                        int m = int.Parse(Console.ReadLine());
                        stack.Push(m);
                        foreach(int num in stack)
                        {
                            Console.Write(num + " "); 
                        }
                        Console.WriteLine(); break;
                    case 3:
                        Console.WriteLine("Phan tu dau duoc lay ra khoi Stack la: ");
                        Console.WriteLine(" " + stack.Pop());
                        Console.WriteLine(); break;
                    case 4:
                        Console.WriteLine($"Xem phan tu dau cua Stack la: {stack.Peek()}");
                        Console.WriteLine(); break;
                    case 5:
                        Console.Write("So phan tu con lai trong Stack la: {0}",stack.Count);
                        Console.WriteLine(); break;
                    case 0: break;
                    default:
                        Console.WriteLine(" Vui long nhap lai!");break;

                }
            }
            while (choice != 0); Console.ReadKey();

        }
    }
}
