using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Выберите номер практической";
            Console.Write("Введите номер праклической: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 2:
                    Console.Clear();
                    Console.Title = "Практическая №2";
                    Console.Write("Введите номер задачи: ");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("a = ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("b = ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"{a:f2} + {b:f2} = {a + b:f2}");
                            break;

                        case 2:
                            Console.Clear();
                            int num = 1234;
                            int sum = 0;

                            sum += num % 10;
                            num /= 10;

                            sum += num % 10;
                            num /= 10;

                            sum += num % 10;
                            num /= 10;

                            sum += num % 10;

                            Console.WriteLine(sum);
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Введите площадь полной поверхности куба: ");
                            double cubeArea = Convert.ToDouble(Console.ReadLine());
                            double edge = Math.Sqrt(cubeArea / 6);
                            Console.WriteLine("Длина ребра:{0}", edge);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Такой задачи нет");
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.Title = "Практическая №3";
                    Console.Write("Введите номер задачи: ");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.Clear();
                            double alphaCentauri = 4.3;
                            int speedOfLight = 300000;
                            int starshipSpeed = 100;
                            Console.Write($"Дано:\nПуть до Альфа Центавра = {alphaCentauri} световых лет\nСкорость света = {speedOfLight} км/с\nСкорость земного звездолета = {starshipSpeed} км/с\n\n");
                            double i = alphaCentauri * speedOfLight / starshipSpeed;
                            Console.WriteLine($"Решение:\n\n{alphaCentauri} * {speedOfLight} / {starshipSpeed} = {i}\nЗвездолет долетит до звезды за {i} лет");
                            break;
                        case 2:
                            Console.Clear();
                            int n, d;
                            Console.Write("Введите первый член прогрессии (n): ");
                            n = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите разность (d): ");
                            d = Convert.ToInt32(Console.ReadLine());
                            int sum = 0;
                            for(int j = 0; j < n; j++)
                            {
                                int t = n + j * d;
                                sum += t;
                            }
                            Console.WriteLine($"Сумму первых {n} членов арифметической прогрессии: {sum}");
                            break;
                        case 3:
                            Console.Clear();
                            double y, x = 4.3;
                            y = (1 + Math.Sqrt(Math.Abs(3 - Math.Pow(x, 2)))) / Math.Atan(Math.Pow(x, 2));
                            Console.WriteLine($"{y:f2}");
                            break;
                        case 4:
                            Console.Clear();
                            Console.Write("Введите a: ");
                            ulong aa1 = ulong.Parse(Console.ReadLine());
                            ulong aa2 = aa1 * aa1;
                            Console.WriteLine(aa2);
                            ulong aa4 = aa2 * aa2;
                            Console.WriteLine(aa4);
                            ulong aa8 = aa4 * aa4;
                            Console.WriteLine(aa8);
                            ulong aa16 = aa8 * aa8;
                            Console.WriteLine(aa16);
                            ulong aa20 = aa16 * aa4;
                            Console.WriteLine(aa20);
                            ulong aa21 = aa20 * aa1;
                            Console.WriteLine(aa21);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Такой задачи нет");
                            break;
                    }
                    break;
                /*case 4:
                    Console.Clear();
                    Console.Title = "Практическая №4";
                    Console.Write("Введите номер задачи: ");
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {

                    }
                    break;*/
                default:
                    Console.WriteLine("Такой Практической нет");
                    break;
            }
        }
    }
}
