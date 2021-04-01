using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int one, two, three, four, max;

            Console.Write("Введите первое число: ");
            one = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            two = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            three = int.Parse(Console.ReadLine());
            Console.Write("Введите четвёртое число: ");
            four = int.Parse(Console.ReadLine());

            if (one > two)
            {
                max = one;
            }
            else
            {
                max = two;
            }

            if (three > max)
            {
                max = three;
            }

            if (four > max)
            {
                max = four;
            }

            Console.WriteLine("Большее число: " + max);
        }
    }
}
