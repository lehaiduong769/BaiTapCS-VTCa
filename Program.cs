using System;
using System.Collections;
using System.Collections.Generic;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, sophantu;
            var List = new List<int>();
            Console.WriteLine(" Nhap so phan tu co trong ds: ");
            sophantu = int.Parse(Console.ReadLine());
            for (int i = 0; i < sophantu; i++)
            {
                List.Add(new Random().Next(0, 10));
            }
        
            do
            {
                Console.WriteLine("Demo cac thao tac tren ArrayList so nguyen trong C#");
                Console.WriteLine("*==================================================");
                Console.WriteLine("1.   Khoi tao danh sach");
                Console.WriteLine("2.   Them mot phan tu");
                Console.WriteLine("3.   Xoa mot phan tu");
                Console.WriteLine("4.   Chen mot phan tu");
                Console.WriteLine("5.   Duyet danh sach");
                Console.WriteLine("6.   Tim mot phan tu");
                Console.WriteLine("7.   Sap xep danh sach tang dan");
                Console.WriteLine("8.   Sap xep danh sach giam dan");
                Console.WriteLine("0.   Thoat chuong trinh");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Original List: ");
                        foreach (int num in List)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();

                        break;

                    case 2:
                        Console.Write("Nhap vao phan tu muon them vao: ");
                        int nadd = int.Parse(Console.ReadLine());
                        List.Add(nadd);
                        Console.WriteLine($"List after adding {nadd} : ");
                        foreach (int num in List)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Nhap vao gia tri phan tu muon remove:");
                        int nremove = int.Parse(Console.ReadLine());
                        List.Remove(nremove);
                        Console.WriteLine($"List after removing {nremove}: ");
                        foreach (int num in List)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Nhap vao gia tri phan tu can chen:");
                        int value = int.Parse(Console.ReadLine());
                        Console.Write("Nhap vao vi tri phan tu can chen:");
                        int index = int.Parse(Console.ReadLine());
                        List.Insert(index, value);
                        Console.WriteLine($"List after inserting: ");
                        foreach (int num in List)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        
                        Console.WriteLine($"Danh sach sau khi duyet: {List.GetRange(0, List.Count)}");
                        break;

                    case 6:
                        Console.Write("Nhap vao gia tri phan tu can tim: ");
                        int nsearch = int.Parse(Console.ReadLine());
                        bool isExists = List.Contains(nsearch);
                        if (isExists == false)
                        {
                            Console.WriteLine(" Khong tim thay phan tu nay trong List");
                        }
                        else
                        {
                            Console.Write($"Phan tu nam o vi tri: ");
                            for (int i = 0; i < sophantu; i++)
                            {
                                if (List[i] == nsearch)
                                {
                                    Console.Write(i + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        List.Sort();
                        Console.WriteLine("Danh sach duoc xep theo thu tu tang dan: ");
                        foreach (int num in List)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 8:
                        List.Reverse();
                        Console.WriteLine("Danh sach duoc xep theo thu tu giam dan: ");
                        foreach (int num in List)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine(); break;

                    case 0:
                        break;
                    default:
                        Console.WriteLine("vui long nhap lai");
                        break;
                }

            } while (choice != 0);
            Console.ReadLine();
            }
    }
}
