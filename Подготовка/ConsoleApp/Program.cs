using System.Reflection.Metadata;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 0;
            int number, number1, number2, number3, sum;
            double number4, number5, perimeter;
            Random random;
            bool repeat = true;

            while (repeat)
            {
                try
                {
                    Console.WriteLine("Введите номер задачи:");
                    string numberCheck = Convert.ToString(Console.ReadLine());
                    int numbers;
                    bool isInteger = int.TryParse(numberCheck, out numbers);

                    if (isInteger)
                    {
                        taskNumber = numbers; // Присваиваем значение number переменной taskNumber
                    }
                    else
                    {
                        throw new ArgumentException("Номер задачи может быть только целым числом");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }

                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Введите два целых числа:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());

                        sum = number1 + number2;
                        Console.WriteLine("Сумма чисел: " + sum);
                        break;

                    case 2:
                        Console.WriteLine("Введите три целых числа:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        number3 = Convert.ToInt32(Console.ReadLine());

                        sum = number1 + number2 + number3;
                        Console.WriteLine("Сумма чисел: " + sum);
                        break;

                    case 3:
                        Console.WriteLine("Введите два вещественных числа:");
                        number4 = Convert.ToDouble(Console.ReadLine());
                        number5 = Convert.ToDouble(Console.ReadLine());

                        double product = number4 * number5;
                        Console.WriteLine("Произведение чисел: " + product.ToString("F1"));
                        break;

                    case 4:
                        Console.WriteLine("Введите два вещественных числа:");
                        number4 = Convert.ToDouble(Console.ReadLine());
                        number5 = Convert.ToDouble(Console.ReadLine());

                        double result = number4 / number5;
                        Console.WriteLine("Результат деления: " + result.ToString("F3"));
                        break;

                    case 5:
                        Console.WriteLine("Введите два целых числа:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Сумма чисел (прямой порядок): {number1} + {number2} = {number1} + {number2}");
                        Console.WriteLine($"Сумма чисел (обратный порядок): {number1} + {number2} = {number2} + {number1}");
                        break;

                    case 6:
                        Console.WriteLine("Введите имя человека:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Введите его возраст:");
                        int age = Convert.ToInt32(Console.ReadLine());

                        int currentYear = DateTime.Now.Year;
                        Console.WriteLine("Имя: " + name + ", Возраст: " + age + ", Год рождения: " + (currentYear - age));
                        break;

                    case 7:
                        Console.WriteLine("Введите номинал купюры:");
                        int denomination = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите количество купюр:");
                        int count = Convert.ToInt32(Console.ReadLine());

                        int totalAmount = denomination * count;
                        Console.WriteLine("Общая сумма: " + totalAmount + " " + "руб.");
                        break;

                    case 8:
                        Console.WriteLine("Введите сторону квадрата:");
                        double side = Convert.ToDouble(Console.ReadLine());

                        perimeter = 4 * side;
                        Console.WriteLine("Периметр квадрата: " + perimeter);
                        break;

                    case 9:
                        Console.WriteLine("Введите стороны прямоугольника:");
                        double sideA = Convert.ToDouble(Console.ReadLine());
                        double sideB = Convert.ToDouble(Console.ReadLine());

                        perimeter = 2 * (sideA + sideB);
                        Console.WriteLine("Периметр прямоугольника: " + perimeter);
                        break;

                    case 10:
                        Console.WriteLine("Введите радиус окружности:");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        double circumference = 2 * Math.PI * radius;
                        Console.WriteLine("Длина окружности: " + circumference);
                        break;

                    case 11:
                        Console.WriteLine("Введите объем флэшки (в Гб):");
                        double flashDriveSize = Convert.ToDouble(Console.ReadLine());

                        double fileSize = 820.0;
                        double flashDriveCapacity = flashDriveSize * 1024;

                        int numberOfFiles = (int)(flashDriveCapacity / fileSize);
                        Console.WriteLine("Количество файлов, помещающихся на флэшку: " + numberOfFiles);
                        break;

                    case 12:
                        Console.WriteLine("Введите двузначное число:");
                        number = Convert.ToInt32(Console.ReadLine());

                        int tensDigit = number / 10;
                        int unitsDigit = number % 10;

                        Console.WriteLine("Первая цифра: " + tensDigit);
                        Console.WriteLine("Вторая цифра: " + unitsDigit);
                        break;

                    case 13:
                        Console.WriteLine("Введите целое число:");
                        number = Convert.ToInt32(Console.ReadLine());

                        if (number > 0)
                        {
                            number += 1;
                        }
                        else
                        {
                            number -= 2;
                        }

                        Console.WriteLine("Результат: " + number);
                        break;

                    case 14:
                        Console.WriteLine("Введите целое число:");
                        number = Convert.ToInt32(Console.ReadLine());

                        if (number > 0)
                        {
                            number += 1;
                        }
                        else if (number < 0)
                        {
                            number -= 2;
                        }
                        else
                        {
                            number = 10;
                        }

                        Console.WriteLine("Результат: " + number);
                        break;

                    case 15:
                        Console.WriteLine("Введите целое число:");
                        number = Convert.ToInt32(Console.ReadLine());

                        if (number > 0)
                        {
                            Console.WriteLine("Число положительное");
                        }
                        else if (number < 0)
                        {
                            Console.WriteLine("Число отрицательное");
                        }
                        else
                        {
                            Console.WriteLine("Число нулевое");
                        }
                        break;

                    case 16:
                        Console.WriteLine("Введите длины сторон треугольника:");
                        double sideA1 = Convert.ToDouble(Console.ReadLine());
                        double sideB2 = Convert.ToDouble(Console.ReadLine());
                        double sideC3 = Convert.ToDouble(Console.ReadLine());

                        if (sideA1 == sideB2 && sideB2 == sideC3)
                        {
                            Console.WriteLine("Треугольник равносторонний");
                        }
                        else
                        {
                            Console.WriteLine("Треугольник не равносторонний");
                        }
                        break;

                    case 17:
                        Console.WriteLine("Введите целое число:");
                        number = Convert.ToInt32(Console.ReadLine());

                        if (number != 0 && 3 % number == 0)
                        {
                            Console.WriteLine("Число является делителем числа 3");
                        }
                        else
                        {
                            Console.WriteLine("Число не является делителем числа 3");
                        }
                        break;

                    case 18:
                        random = new Random();

                        for (int i = 0; i < 10; i++)
                        {
                            number = random.Next(-30, 31);

                            if (number < 0)
                            {
                                Console.WriteLine(number + " - отрицательное");
                            }
                            else if (number > 0)
                            {
                                Console.WriteLine(number + " - положительное");
                            }
                            else
                            {
                                Console.WriteLine(number + " - нулевое");
                            }
                        }
                        break;

                    case 19:
                        random = new Random();

                        for (int i = 0; i < 8; i++)
                        {
                            number = random.Next(-20, 331);

                            if (number % 2 == 0)
                            {
                                Console.WriteLine(number + " - четное");
                            }
                            else
                            {
                                Console.WriteLine(number + " - нечетное");
                            }
                        }
                        break;

                    case 20:
                        Console.WriteLine("Введите два целых числа:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());

                        int maxNumber = Math.Max(number1, number2);
                        Console.WriteLine("Максимальное число: " + maxNumber);
                        break;

                    case 21:
                        Console.WriteLine("Введите номер дня недели (от 1 до 7):");
                        int dayNumber = Convert.ToInt32(Console.ReadLine());

                        string dayName = "";

                        switch (dayNumber)
                        {
                            case 1:
                                dayName = "Понедельник";
                                break;
                            case 2:
                                dayName = "Вторник";
                                break;
                            case 3:
                                dayName = "Среда";
                                break;
                            case 4:
                                dayName = "Четверг";
                                break;
                            case 5:
                                dayName = "Пятница";
                                break;
                            case 6:
                                dayName = "Суббота";
                                break;
                            case 7:
                                dayName = "Воскресенье";
                                break;
                            default:
                                Console.WriteLine("Некорректный номер дня недели");
                                break;
                        }

                        if (dayName != "")
                        {
                            Console.WriteLine("День недели: " + dayName);
                        }
                        break;

                    case 22:
                        Console.WriteLine("Bывод четных двузначных чисел");
                        for (number = 10; number < 100; number += 2)
                        {
                            Console.WriteLine(number);
                        }
                        break;

                    case 23:
                        Console.WriteLine("Bывод нечетных двузначных чисел");
                        for (number = 11; number < 100; number += 2)
                        {
                            Console.WriteLine(number);
                        }
                        break;

                    case 24:
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Привет!");
                        }
                        break;

                    case 25:
                        Console.WriteLine("Введите число n:");
                        int n = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Информатика");
                        }
                        break;

                    case 26:
                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case 27:
                        for (int i = 0; i < 18; i++)
                        {
                            Console.Write("-");
                        }
                        Console.WriteLine("");
                        break;

                    case 28:
                        for (int i = 10; i >= 1; i--)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case 29:
                        string line = "";

                        for (int i = 0; i < 18; i++)
                        {
                            line += "-";
                        }

                        Console.WriteLine(line);
                        break;

                    case 30:
                        double start = 1;
                        double end = 20;
                        double step = 2;

                        Console.WriteLine("|   x   |   y   |");
                        Console.WriteLine("|-------|-------|");

                        for (double x = start; x <= end; x += step)
                        {
                            double y = 5 * x - 2;
                            Console.WriteLine($"|  {x,-4} |  {y,-4} |");
                        }
                        break;

                    case 31:
                        int[] arr = { 1, 5, 7, 9, 11 };

                        foreach(var item in arr)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 32:
                        for (int i = 100; i <= 200; i++)
                        {
                            if (i % 3 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case 33:
                        double price = 20.4;

                        for (int quantity = 2; quantity <= 20; quantity++)
                        {
                            double totalCost = price * quantity;
                            Console.WriteLine($"Количество: {quantity}, Стоимость: {totalCost:f1} руб.");
                        }
                        break;

                    case 34:
                        int[] numbers = new int[6];

                        Console.WriteLine("Введите шесть целых чисел:");

                        for (int i = 0; i < 6; i++)
                        {
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("Введенные числа:");

                        foreach(var item in numbers)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 35:
                        int[] numb = new int[6];

                        Console.WriteLine("Введите шесть целых чисел:");

                        for (int i = 0; i < 6; i++)
                        {
                            numb[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Array.Reverse(numb);

                        Console.WriteLine("Введенные числа в обратном порядке:");

                        foreach (var item in numb)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 36:
                        double[] num = new double[5];

                        Console.WriteLine("Введите пять вещественных чисел:");

                        for (int i = 0; i < 5; i++)
                        {
                            num[i] = Convert.ToDouble(Console.ReadLine());
                        }

                        Console.WriteLine("Первый элемент массива: " + num[num.Length - 5]);
                        break;

                    case 37:
                        random = new Random();
                        double[] array = new double[5];

                        for (int i = 0; i < 5; i++)
                        {
                            array[i] = random.NextDouble() * 20 - 10;
                        }

                        Console.WriteLine("Массив вещественных чисел:");

                        foreach(var item in array)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Последний элемент массива: " + array[array.Length - 1]);
                        break;

                    case 38:
                        int[] mass = { 3, 4, -9, 8, 1, -6, 2, -5, -1, 7, 5, 9 };

                        Console.WriteLine("Массив чисел:");

                        foreach (var item in mass)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 39:
                        int[] mas = { -5, 2, 3, 6, 7, 9, -4, 8, 1, 2, 7, -3 };

                        Console.WriteLine("Массив чисел:");

                        foreach (var item in mas)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 40:
                        int[] numMass = { -37, 0, 50, 46, 34, 46, -4, 13 };
                        int negativeCount = 0;

                        Console.WriteLine("Массив чисел:");

                        foreach (var item in numMass)
                        {
                            Console.Write(item + " ");

                            if (item < 0)
                            {
                                negativeCount++;
                            }
                        }

                        Console.WriteLine("Количество отрицательных элементов: " + negativeCount);
                        break;

                    case 41:
                        random = new Random();
                        int[] numbers1 = new int[6];

                        for (int i = 0; i < 6; i++)
                        {
                            numbers1[i] = random.Next(1, 10);
                        }

                        Console.WriteLine("Массив чисел:");

                        foreach (var item in numbers1)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                }

                Console.WriteLine("Хотите повторить? (Да/Нет)");
                string answer = Console.ReadLine();

                if (answer.Equals("Нет", StringComparison.OrdinalIgnoreCase))
                {
                    repeat = false;
                }
            }
            Console.ReadKey();

        }
    }
}