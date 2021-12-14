using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_BT2
{
    class Product
    {
        public String TenSP;
        public int SL;
        public int Dongia;
        public int STT;
        public double TinhTongTien(int SL, int Dongia)
        {
            return SL * Dongia;
        }
        public Product(int STT, string TenSP , int SL, int Dongia) 
        {
            this.STT = STT;
            this.TenSP = TenSP;
            this.SL = SL;
            this.Dongia = Dongia;
        }
        public void Print()
        {
                    
            String st = String.Format("|{0}|", centeredString($" {STT} ", -10))
          + String.Format("{0}|", centeredString($"{TenSP}", 20))
          + String.Format("{0}|", centeredString($"{SL}", 10))
          + String.Format("{0}|", centeredString($"{Dongia}", 10))
          + String.Format("{0}|", centeredString($"{TinhTongTien(SL,Dongia)}", 10));

            Console.WriteLine(st);
         
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
