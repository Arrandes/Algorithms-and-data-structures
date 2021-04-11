using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        //Метод меняет местами два элемента
        static void Swap(ref int a, ref int b)
        {
            //Вспомогательная переменная, хранящая значение первой переменной
            int t = a;
            a = b;
            b = t;
        }

        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка пузырьком");
            Console.Write("Не отсортированный массив: ");

            Random random = new Random();
            int[] myArray = new int[random.Next(6, 7)];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(100);
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(myArray)));
            Console.ReadLine();
        }
    }
}
