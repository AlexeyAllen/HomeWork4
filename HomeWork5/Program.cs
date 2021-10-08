using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pow2
{
    class pow2
    {
        static void Main(string[] args)
        {
            //Найти квадрат введенного целого положительного числа N,
            //используя формулу: N^2 = 1 + 3 + 5 + ... + (2*N – 1), вывод квадратов чисел от 1 до N
            Console.WriteLine("Введите положительное целое число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("Значения квадратов чисел от 1 до N включительно = ");
            for (int i = 1; i < n + 1; i++)
            {
                sum += 2 * i - 1;
                Console.Write("{0} ", sum);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
