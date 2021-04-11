using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailSort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static int[] CocktailSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            int last_swap = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        last_swap = i;
                    }
                }

                right = last_swap;

                if (left >= right)
                {
                    break;
                }

                for (int j = right; j > left; j--)
                {
                    if (array[j-1] > array[j])
                    {
                        Swap(ref array[j], ref array[j - 1]);
                        last_swap = j;
                    }
                }

                left = last_swap;
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Шейкерная сортировка");
            Console.Write("Не отсортированный массив: ");

            Random random = new Random();
            int[] myArray = new int[random.Next(4, 5)];

            //Каждому элементу генерируем случайное число
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(100);
            }
            //Выводим каждый элемент на экран
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", CocktailSort(myArray)));
            Console.ReadLine();
        }
    }
}
