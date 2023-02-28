using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задание 1

            //// Заданный массив количества осадков
            //int[] mas = { 489, 402, 508, 424, 487, 551, 457, 510, 467, 469, 505, 441, 487, 474, 438, 478, 450, 463, 452, 516, 521, 443 };

            //// Вычисляем среднее количество осадков
            //double average = 0;
            //foreach (int val in mas)
            //{
            //    average += val;
            //}
            //average /= mas.Length;

            //// Вычисляем отклонение от среднего для каждого года
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    double deviation = mas[i] - average;
            //    Console.WriteLine("Год {0}: Среднее количество осадков - {1}, Отклонение от среднего - {2}", i + 1, average, deviation);

            //}

            ////Задание 2

            //// Заданный массив
            //int[] arr = { 4, 2, -1, 5, 3, -2, 6, 7, -3, 1 };

            //// Находим индекс первого отрицательного элемента
            //int firstNegativeIndex = -1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        firstNegativeIndex = i;
            //        break;
            //    }
            //}

            //// Вычисляем сумму элементов от первого отрицательного и до конца
            //int sum = 0;
            //for (int i = firstNegativeIndex + 1; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine("Сумма элементов от первого отрицательного и до конца: {0}", sum);

            //Задача 3

            // Исходный массив
            int[] array = { 1, 3, -2, 5, 7, 8, -4, 6, 2, 9 };

            // Находим индексы первого отрицательного и максимального элементов
            int firstNegativeIndex = -1;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && firstNegativeIndex == -1)
                {
                    firstNegativeIndex = i;
                }
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Если первый отрицательный элемент и максимальный элемент находятся в одной позиции, ничего не меняем
            if (firstNegativeIndex == maxIndex)
            {
                Console.WriteLine("Первый отрицательный и максимальный элементы находятся в одной позиции.");
            }
            else
            {
                // Меняем местами первый отрицательный и максимальный элементы
                int temp = array[firstNegativeIndex];
                array[firstNegativeIndex] = array[maxIndex];
                array[maxIndex] = temp;

                Console.WriteLine("Массив после замены местами:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
