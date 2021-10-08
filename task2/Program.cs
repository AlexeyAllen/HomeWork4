using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cравнение, последовательности целых чисел для отрицательных и положительных значений,
            // ограничение - нуль.
            Console.WriteLine("Введите последовательность из целых чисел. Ограничением последовательности является нуль");
            int n;
            int sum1 = 0;
            int sum2 = 0;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    sum1 += n;
                }
                else if (n < 0)
                {
                    sum2 += Math.Abs(n);
                }

                if ((sum1 > sum2) && n == 0)
                {
                    Console.WriteLine("Сумма положительных чисел больше суммы отрицательных чисел");
                }
                else if ((sum1 < sum2) && n == 0)
                {
                    Console.WriteLine("Сумма отрицательных чисел больше суммы положительных чисел");
                }

            } while (n != 0);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
