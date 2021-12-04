using System;

namespace LAB6_BT1
{
    class LAB6_BT1
    {
        static void Main(string[] args)
        {

            Console.Write("\nNhap he so a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nNhap he so b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap hang so c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            giaiPT(a, b, c);
            Console.ReadKey();

        }

        static void giaiPT(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }
                else
                {
                    Console.WriteLine("Phương trình có một nghiệm: "
                            + "x = " + (-c / b));
                }
                return;
            }

            double delta = b * b - 4 * a * c;
            double x1;
            double x2;

            if (delta > 0)
            {
                x1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Phương trình có 2 nghiệm là: "
                        + "x1 = " + x1 + " và x2 = " + x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("Phương trình có nghiệm kép: "
                        + "x1 = x2 = " + x1);
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm!");
            }
        } 

    }
}

