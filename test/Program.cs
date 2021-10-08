using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqrsQty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение кол-ва квадратов в прямоугольнике
            Console.WriteLine("Введите размеры сторон прямоугольника А, В и размер стороны квадрата = С");
            Console.WriteLine("Ввведите размер А");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввведите размер B");
            int sideB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввведите размер C");
            int sideC = Convert.ToInt32(Console.ReadLine());
            int sum1 = sideC;
            int sum2 = 0;
            int sum3 = 0;

            while (sideA > sum2)
            {
                while (sideB > sum1)
                {
                    sum1 += sideC;
                }
                sum2++;
                sum3 += sum1;
                sum1 = 0;
            }
            Console.WriteLine("Количество квадратов = {0}", sum3);
            Console.ReadKey();
        }
    }
}
