using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemTranslation
{
    class Program
    {
        /*static void NumberSystemTranslation(int dec)
        {
            string s = "";

            if (dec > 0)
            {
                if (dec % 2 == 1)
                {
                    s += "1";
                }
                else
                {
                    s += "0";
                }
            }
        }*/
        static string NumberSystemTranslation(int dec)
        {
            string s = "";

            while (dec > 0)
            {
                s = dec % 2 + s;
                dec /= 2;
            }

            if (s == "")
            {
                s = "0";
            }

            return s;
        }

        static void Main(string[] args)
        {
            int dec;

            Console.Write("Пожалуйста, введите число в десятичной системе счисления: ");
            dec = int.Parse(Console.ReadLine());

            //NumberSystemTranslation(dec);

            Console.WriteLine("Введённое число в двоичной системе счисления: " + NumberSystemTranslation(dec));
            Console.ReadLine();
        }
    }
}
