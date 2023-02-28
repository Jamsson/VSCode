using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задание 1

            //// объявляем массив
            //int[] arr = new int[10];

            //// заполнение массива
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Введите значение для элемента {i}: ");
            //    int value = int.Parse(Console.ReadLine());
            //    arr.SetValue(value, i);
            //}

            //// выводим значения одномерного массива
            //Console.WriteLine("Массив:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int value = (int)arr.GetValue(i);
            //    Console.WriteLine($"Элемент {i}: {value}");
            //}

            ////Задание 2 

            //// объявляем массив
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// Очищаем три элемента, начиная со второго
            //Array.Clear(arr, 1, 3);

            //// выводим значения одномерного массива
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}

            ////Задача 3

            //// объявляем массив
            //int[] arr = { 1, 2, 3, 4, 5 };

            ////Выполняем реверс одномерного массива
            //Array.Reverse(arr);

            //// выводим значения одномерного массива
            //foreach (int element in arr)
            //{
            //    Console.Write(element + " ");
            //}

            //Задание 4

            // объявляем массив
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // уменьшаем размер массива до 6
            Array.Resize(ref arr, 6);

            // выводим значения одномерного массива
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
