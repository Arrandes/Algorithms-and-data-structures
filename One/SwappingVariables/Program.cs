using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Введите значение в переменную a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение в переменную b: ");
            b = int.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("Значение переменной a: " + a);
            Console.WriteLine("Значение переменной b: " + b);
        }
    }
}
