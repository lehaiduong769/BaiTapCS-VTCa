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
        public float TinhDTB() 
        {
            return (DiemLT + DiemTH) / 2;
        }
        public void NhapMonHoc() //hàm nhập thông tin của môn học
        {
            Console.Write("Ten mon hoc: " + TenMonHoc);
            TenMonHoc = Console.ReadLine();
            Console.Write("Diem ly thuyet: " + DiemLT);
            DiemLT = float.Parse(Console.ReadLine());
            Console.Write("Diem Thuc Hanh: " + DiemTH);
            DiemTH = float.Parse(Console.ReadLine());
        }
        public void XuatMonHoc()//hàm xuất thông tin của môn học
        {
            Console.WriteLine("THONG TIN VE MON HOC");
            Console.WriteLine("==========================");
            Console.WriteLine("Diem ly thuyet: " + DiemLT);
            Console.WriteLine("Diem thuc hanh: " + DiemTH);
            Console.WriteLine("Diem trung binh: " + (DiemLT + DiemTH)/2);

        }
        public Mark(string TenMonHoc, float DiemLT, float DiemTH)
        {
            this.TenMonHoc = TenMonHoc;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
        }
        public Mark()
        {
            
        }
    }
}

