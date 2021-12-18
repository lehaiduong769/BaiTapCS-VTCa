using System;
using System.Collections;

namespace LAB7_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add object vao array list - Chu y them "using System.Collections"
            ArrayList list = new ArrayList();
            list.Add(new Mark(1, "Toan", 7.5f, 8.5f));
            list.Add(new Mark(2, "Ngu Van", 8, 7));
            list.Add(new Mark(3, "Tieng Anh", 9, 10));
            list.Add(new Mark(4, "Vat ly", 9.5f, 10));
            list.Add(new Mark(5, "Sinh hoc", 6.5f, 8.5f));
            list.Add(new Mark(6, " Su hoc", 9.5f, 10));
            list.Add(new Mark(7, " Dia ly", 8, 10));
            list.Add(new Mark(8, "Hoa hoc", 5.5f, 7.5f));

            //Tìm môn có điểm TB lớn nhất
            Mark max = new Mark();
            max = (Mark)list[0];
            for (int i = 1; i < 8; i++)
            {
                if (max.getMarkAverage() < ((Mark)list[i]).getMarkAverage())
                {
                    max = (Mark)list[i];
                }
            }

            Console.WriteLine("1. Hien thi danh sach mon hoc");
            Console.WriteLine("2. Mon co diem TB cao nhat");
            Console.WriteLine("3. Thoat");

            int m;
            do
            {
                m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        printTitle();
                        for (int i = 0; i < 8; i++)
                        {
                            ((Mark)list[i]).Print();
                        }
                        printString("=", 80);
                        Console.WriteLine(); break;
                    case 2:
                        Console.Write("MON CO DIEM TB CAO NHAT \n\n");
                        max.Print(); break;
                    case 3: m = 3; break;
                    default: Console.WriteLine(" vui long nhap lai"); break;
                }
            } while (m != 3);
                Console.WriteLine("");
            
              //IN RA
            static void printString(string s, int times)
            {
                s = "=";
                for (int i = 0; i < times; i++)
                {
                    Console.Write(s);
                }
            }
            static void printTitle()
            {
                String st = String.Format("|{0}|", centeredString("STT", -10))
                 + String.Format("{0}|", centeredString("Ten mon hoc", 20))
                 + String.Format("{0}|", centeredString(" Diem Ly Thuyet ", -20))
                 + String.Format("{0}|", centeredString(" Diem Thuc Hanh  ", -20))
                 + String.Format("{0}|", centeredString(" Diem Trung Binh ", -20));
                Console.WriteLine("BANG DIEM CAC MON HOC");
                printString("=", 80);
                Console.WriteLine();
                Console.WriteLine(st);
                printString("=", 80);
                Console.WriteLine();
                static void printString(string s, int times)
                {
                    s = "=";
                    for (int i = 0; i < times; i++)
                    {
                        Console.Write(s);
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
                }

            }

        }
    }
}
