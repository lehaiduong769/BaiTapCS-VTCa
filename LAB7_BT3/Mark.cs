using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7_BT1
{
    class Mark
    {

        String TenMonHoc;
        float DiemLT;
        float DiemTH;
        int STT;
        public float TinhDTB(float DiemLT, float DiemTH)
        {
            return (DiemLT + DiemTH) / 2;
        }
        public float getMarkAverage()
        {
            return (DiemLT + DiemTH) / 2;
        }
        public Mark(int STT, string TenMonHoc, float DiemLT, float DiemTH)
        {
            this.STT = STT;
            this.TenMonHoc = TenMonHoc;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
        }
        public Mark()
        {

        }
        
        public void Print()
        {

            String st = String.Format("|{0}|", centeredString($" {STT} ", -10))
          + String.Format("{0}|", centeredString($"{TenMonHoc}  ", 20))
          + String.Format("{0}|", centeredString($"{DiemLT}", 16))
          + String.Format("{0}|", centeredString($"{DiemTH}", 17))
          + String.Format("{0}|", centeredString($"{TinhDTB(DiemLT,DiemTH)}", 17));

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

        static void printString(char s, int times)
            {
                s = '=';
                for (int i = 0; i < times; i++)
                {
                    Console.Write(s);
                }
            }
        
        }
        }
       
        
    


