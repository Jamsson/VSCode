using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int maxPick = 1;
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во шагов для числа {0}", CollatzMax(num, ref maxPick, ref steps));
            Console.WriteLine("шагов{0} Макс пик{1}", steps, maxPick);
            Console.ReadKey();
        }
        static int CollatzMax(int n, ref int max, ref int steps)
        {
            if (n == 1)
                return 1;
            int pick = Pick(n, max);
            if (pick > max)
            {
                max = pick;
            }
            steps++;
            return 1 + CollatzMax(pick, ref max, ref steps);
        }

            static int Pick(int n, int max)
            {
            if (n % 2 == 0)
                return n / 2;
            else
                return n * 3 + 1;

            }


    }
}
