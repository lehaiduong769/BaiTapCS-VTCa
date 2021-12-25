using System;
using System.Collections;

namespace BT2_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, n;
            Queue queue = new Queue();
            Console.WriteLine(" Nhap so phan tu muon khoi tao trong Queue: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(new Random().Next(0, 10));
            }
            do
            {
                Console.WriteLine("Demo cac thao tac trong Queue so nguyen C#");
                Console.WriteLine("=========================================");
                Console.WriteLine("1.   Khoi tao Queue");
                Console.WriteLine("2.   Them mot phan tu vao Queue ");
                Console.WriteLine("3.   Lay phan tu dau ra khoi Queue");
                Console.WriteLine("4.   Xem phan tu dau cua Queue");
                Console.WriteLine("5.   Duyet Queue");
                Console.WriteLine("0.   Thoat chuong trinh");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ds cac phan tu duoc khoi tao trong Queue: ");
                        foreach (int num in queue)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine(); break;

                    case 2:
                        Console.WriteLine("Nhap vao gia tri phan tu muon them vao Queue: ");
                        int m = int.Parse(Console.ReadLine());
                        queue.Enqueue(m);
                        foreach (int num in queue)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine(); break;
                    case 3:
                        Console.WriteLine("Phan tu dau duoc lay ra khoi Queue la: ");
                        Console.WriteLine(" " + queue.Dequeue());
                        Console.WriteLine(); break;
                    case 4:
                        Console.WriteLine($"Xem phan tu dau cua Queue la: {queue.Peek()}");
                        Console.WriteLine(); break;
                    case 5:
                        Console.Write("So phan tu con lai trong Queue la: {0}",queue.Count);
                        Console.WriteLine(); break;
                    case 0: break;
                    default:
                        Console.WriteLine(" Vui long nhap lai!"); break;

                }
            }
            while (choice != 0); Console.ReadKey();

        }
    }
}
