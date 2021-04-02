using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    class Program
    {
        /*
         * Выполнил: Скворцов Александр
         */

        static void Main(string[] args)
        {
            int weight;
            double h, height;

            Console.Write("Введите ваш рост: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш вес в килограммах: ");
            weight = int.Parse(Console.ReadLine());

            h = height / 100;
            Console.WriteLine($"Индекс массы тела: {Math.Round((weight / (h * h)), 2)}");
        }
    }
}
