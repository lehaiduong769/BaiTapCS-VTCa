using System;

namespace LAB7_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Mayin = new Product(1,"May in", 5, 150);
            Product Manhinh = new Product(2,"Man hinh LCD", 10, 350);
            Product Chuot = new Product(3,"Chuot Mitsumi", 25, 10);
            Product Banphim = new Product(4,"Ban phim", 10, 12);
            Product USB = new Product(5,"USB 2G", 100, 13);
            double sum = Mayin.TinhTongTien(5, 150) + Manhinh.TinhTongTien(10, 350) + Chuot.TinhTongTien(25, 10) + Banphim.TinhTongTien(10, 12) + USB.TinhTongTien(100, 13);
            String tongtien = String.Format("|{0, 54}   |", sum);
            String st = String.Format("|{0}|", centeredString("STT", -10))
              + String.Format("{0}|", centeredString("Ten san pham", 20))
              + String.Format("{0}|", centeredString(" So luong ", -20))
              + String.Format("{0}|", centeredString(" Don gia  ", -20))
              + String.Format("{0}|", centeredString(" Tongtien ", -20));
            Console.WriteLine("DANH MUC SAN PHAM");
            printString("-", 60);
            Console.WriteLine();
            Console.WriteLine(st);
            printString("-", 60);
            Console.WriteLine();
            Mayin.Print();
            Manhinh.Print();
            Chuot.Print();
            Banphim.Print();
            USB.Print();
            printString("-", 60);
            Console.WriteLine();
            Console.WriteLine(tongtien);
            printString("-", 60);
            static void printString(string s, int times)
                {
                    s = "-";
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
