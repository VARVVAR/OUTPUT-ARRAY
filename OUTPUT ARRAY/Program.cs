using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTPUT_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Заполнить массив с клавиатуры.
            2.вывести масив в обратнос порядке.
            3.найти сумму четных чисел в массиве.
            4.найти наименьшее число в массиве
            */

            Console.Write("Ведите количество елементов в масиве: \t");
            int Count = int.Parse(Console.ReadLine());
            int[] myArray = new int[Count];

            // Ввод елементов в массиве

            for (int i = 0;i < Count; i++)
            {
                Console.Write($"Заполните: {i} массив елементом: \t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            // Цикл для того что-бы пользователь понимал куда он вводит числа (в какой индекс)

            Console.WriteLine($"\nВывод массива:\t");
            // Вывод массива 

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("\nВывод массива в обратном порядке: \t");

            // цикл для вывода масива в обратном порядке

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }


            Console.WriteLine("\nЧетные числа в массиве:");

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    Console.WriteLine(myArray[i]);
                }   
            }

            // Для поиска и вывода четных чисел

            int minNumber = myArray[0];

            Console.WriteLine("\nНаименьшее число в массиве:");
            for (int i = 0; i < myArray.Length; i++) 
            {
                if (myArray[i] < minNumber)
                {
                   minNumber = myArray[i];
                }
                
            }
            Console.WriteLine(minNumber);

            // Цикл для поиска наименьшего числа в масиве.

            Console.ReadLine();

        }
    }
}
