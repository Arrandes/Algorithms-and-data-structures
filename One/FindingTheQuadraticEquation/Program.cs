using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheQuadraticEquation
{
    class Program
    {
        static void TheQuadraticEquation(int a, int b, int c)
        {
            int d, x1, x2;

            d = ((b * b) - ((4 * a) * c));

            if (d > 0)
            {
                Console.WriteLine("Дискриминант > 0, 2 корня");

                x1 = (-1 - (Convert.ToInt32(Math.Sqrt(d)))) / (2 * a);
                x2 = (-1 + (Convert.ToInt32(Math.Sqrt(d)))) / (2 * a);

                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);
            }
            else if (d < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (d == 0)
            {
                Console.WriteLine("Дискриминант = 0, 1 корень");

                x1 = (-b) / (2 * a);

                Console.WriteLine("X = " + x1);
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Введите значение a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            c = int.Parse(Console.ReadLine());

            TheQuadraticEquation(a, b, c);
        }
    }
}
