using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Console.ReadLine();
            Console.WriteLine($"- Char'numbers in your string: {s.Length}");
            int vowel = 0;
            int consonant = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' ||
                    s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' ||
                    s[i] == 'O' || s[i] == 'U')
                {
                    vowel++;
                }
                else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    consonant++;
                }
            }
            Console.WriteLine($"- Vowel'times in your string: {vowel} \n- Consonant'times in your string: {consonant}");

            //Xóa khoảng trắng khỏi chuỗi
            
            s = s.Replace(" ", string.Empty);
            Console.WriteLine($"- Word'numbers in your string: {s.Length}");

        }
    }
}
