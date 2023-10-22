using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Utils
{
    //static: Bir özelliği veya metodu bulunduğu sınıfı üretmeden kullanmamızı sağlar.
    public static class Tools
    {
        public static bool TCKNCheck(string tckn)
        {
            long.TryParse(tckn, out long tckn_long);
            if (tckn_long.ToString().Length == 11)
            {
                return TCKNCheck(tckn_long);
            }
            return false;
        }

        public static bool TCKNCheck(long tckn)
        {
            if (tckn.ToString().Length == 11)
            {
                long f9 = tckn / 100;
                long l2 = tckn % 100;
                long odds = 0, evens = 0;

                for (int i = 9; i > 0; i--)
                {
                    long s = f9 % 10;
                    f9 /= 10;
                    if (i % 2 == 0)
                    {
                        evens += s;
                    }
                    else
                    {
                        odds += s;
                    }
                }
                long s10 = (odds * 7 - evens) % 10;
                long s11 = (odds + evens + s10) % 10;
                return l2 == s10 * 10 + s11;
            }
            return false;
        }

        public static bool PhoneFormatCheck(string phone_number)
        {
            bool result = Regex.IsMatch(phone_number,
                @"^\+90\s\(5[0345][0-9]\)\s[0-9]{3}\s[0-9]{4}$");
            return result;
        }

        public static bool WordCheck(string text, int char_count)
        {
            //Trim: Bir metin yapısında başta ve sonra bulunan boşlukları kaldırır.
            text = text.Trim();

            //Split('ayraç karakteri'): Bir cümleyi belirtilmiş olan ayraç karakteri (char) ile bölme işlemidir.
            string[] words = text.Split(' ');

            bool status = false;
            if (words.Length > 1)
            {
                status = true;
                foreach (string word in words)
                {
                    if (word.Length < char_count)
                    {
                        status = false;
                        break;
                    }
                }
            }
            return status;
        }
    }
}
