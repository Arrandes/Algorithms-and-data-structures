using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingVariablesV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите значение в переменную a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение в переменную b: ");
            b = int.Parse(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("Значение переменной a: " + a);
            Console.WriteLine("Значение переменной b: " + b);
        }
    }
}
