using System;

namespace LAB6_BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Menu();
            Program.Choice(n);
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|         MENU           |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| 1.  Menu 1             |");
            Console.WriteLine("| 2.  Menu 2             |");
            Console.WriteLine("| 3.  Menu 3             |");
            Console.WriteLine("| 4.  Menu 4             |");
            Console.WriteLine("| 5.  Exit               |");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("        Please choose: ");
        }
        static void Choice (int n)
        {
            do
            {
                n = int.Parse(Console.ReadLine());
                
                switch (n)
                {
                case 1: Console.WriteLine("doing menu 1 ..."); break;
                case 2: Console.WriteLine("doing menu 2 ..."); break;
                case 3: Console.WriteLine("doing menu 3 ..."); break;
                case 4: Console.WriteLine("doing menu 4 ..."); break;
                case 5: Console.WriteLine("doing menu 5 ..."); n = 5; break;
                default: Console.WriteLine("Entered incorrectly: re-enter: " + n); break;
                }
            }
            while (n != 5) ;
        }

    }
}
