namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Тема 9. Компьютерный практикум 6";

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Введите номер задания: ");

            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.Clear();

                    Console.Title = "Тема 9. Компьютерный практикум 6. Задание 1";

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write("Введите количество элементов в массиве: ");

                    int n = int.Parse(Console.ReadLine());

                    int[] arr = new int[n];
                    Random rand = new Random();

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Write("Массив: ");
                    for (int j = 0; j < n; j++)
                    {
                        arr[j] = rand.Next(1, 81);
                        Console.Write(arr[j] + " ");
                    }

                    int minIndex = 0, maxIndex = 0;
                    for (int j = 1; j < n; j++)
                    {
                        if (arr[j] < arr[minIndex])
                        {
                            minIndex = j;
                        }
                        if (arr[j] > arr[maxIndex])
                        {
                            maxIndex = j;
                        }
                    }

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Минимальный элемент: " + arr[minIndex]);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Максимальный элемент: " + arr[maxIndex]);

                    int temp = arr[minIndex];
                    arr[minIndex] = arr[maxIndex];
                    arr[maxIndex] = temp;

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Массив после обмена: ");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ReadKey();
                    break;


                case 2:
                    Console.Clear();

                    Console.Title = "Тема 9. Компьютерный практикум 6. Задание 2";

                    double[] array = new double[12];

                    Console.ForegroundColor = ConsoleColor.Yellow;




                    Console.WriteLine("Введите 12 элементов массива:");
                    for (int j = 0; j < 12; j++)
                    {
                        array[j] = double.Parse(Console.ReadLine());
                    }

                    // Сортировка массива по убыванию
                    Array.Sort(array);
                    Array.Reverse(array);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Массив в порядке убывания:");
                    foreach (double item in array)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();

                    // Вычисление суммы максимального и минимального элементов
                    double sum = array[0] + array[11];

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Сумма максимального и минимального элементов: " + sum);
                    Console.ResetColor();
                    Console.ReadKey();
                    break;


                case 3:
                    Console.Clear();

                    Console.Title = "Тема 9. Компьютерный практикум 6. Задание 3";

                    double[] mass = new double[14];

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Введите 14 элементов массива:");
                    for (int j = 0; j < 14; j++)
                    {
                        mass[j] = double.Parse(Console.ReadLine());
                    }

                    // Сортировка первой половины массива по возрастанию
                    Array.Sort(mass, 0, 7);

                    // Сортировка второй половины массива по убыванию
                    Array.Sort(mass, 7, 7);
                    Array.Reverse(mass, 7, 7);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Массив после сортировки:");
                    foreach (double item in mass)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.ReadKey();
                    break;

                default: 
                    Console.WriteLine("Ошибка");
                    break;



            }

        }
    }
}
