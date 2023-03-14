namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            //Console.Write("Введите количество элементов в массиве: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Random rand = new Random();

            //Console.Write("Массив: ");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = rand.Next(1, 81);
            //    Console.Write(arr[i] + " ");
            //}

            //int minIndex = 0, maxIndex = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] < arr[minIndex])
            //    {
            //        minIndex = i;
            //    }
            //    if (arr[i] > arr[maxIndex])
            //    {
            //        maxIndex = i;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Минимальный элемент: " + arr[minIndex]);
            //Console.WriteLine("Максимальный элемент: " + arr[maxIndex]);

            //int temp = arr[minIndex];
            //arr[minIndex] = arr[maxIndex];
            //arr[maxIndex] = temp;

            //Console.Write("Массив после обмена: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Задание 2

            //double[] arr = new double[12];
            //Console.WriteLine("Введите 12 элементов массива:");
            //for (int i = 0; i < 12; i++)
            //{
            //    arr[i] = double.Parse(Console.ReadLine());
            //}

            //// Сортировка массива по убыванию
            //Array.Sort(arr);
            //Array.Reverse(arr);

            //Console.WriteLine("Массив в порядке убывания:");
            //foreach (double item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //// Вычисление суммы максимального и минимального элементов
            //double sum = arr[0] + arr[11];
            //Console.WriteLine("Сумма максимального и минимального элементов: " + sum);

            //Задание 3

            double[] arr = new double[14];
            Console.WriteLine("Введите 14 элементов массива:");
            for (int i = 0; i < 14; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }

            // Сортировка первой половины массива по возрастанию
            Array.Sort(arr, 0, 7);

            // Сортировка второй половины массива по убыванию
            Array.Sort(arr, 7, 7);
            Array.Reverse(arr, 7, 7);

            Console.WriteLine("Массив после сортировки:");
            foreach (double item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();

        }
    }
}