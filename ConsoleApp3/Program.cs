using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double D;
            double x1, x2;
            while (true)
            {
                Console.WriteLine("Введите коэффициенты при х для квадратного уравнения:");

                if (!double.TryParse(Console.ReadLine(), out a) || a == 0)
                {
                    Console.WriteLine("Некорректное значение для a. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Некорректное значение для b. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Некорректное значение для c. Введите корректное значение.");
                    continue;
                }
                break;
            }
            if (b != 0 && c != 0)
            {
                D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0)
                {
                    Console.WriteLine($"Дискриминант положительный = {D}.");
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
                if (D == 0)
                {
                    Console.WriteLine($"Дискриминант равен {D}.");
                    x1 = -b / (2 * a);
                    Console.WriteLine($"x1 = {x1}");
                }
                if (D < 0)
                {

                    Console.WriteLine($"Дискриминант отрицательный = {D}.");
                    Console.WriteLine($"x1 = {-b / (2 * a)} + {Math.Sqrt(Math.Abs(D))/(2 * a)}i");
                    Console.WriteLine($"x2 = {-b / (2 * a)} - {Math.Sqrt(Math.Abs(D)) / (2 * a)}i");
                }
            }
            else if (b == 0 && c != 0)
            {
                if (c < 0)
                {
                    x1 = -(Math.Sqrt(-c / a));
                    x2 = (Math.Sqrt(-c / a));
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
                else
                {
                    Console.WriteLine($"x1 = {Math.Sqrt(Math.Abs(c / a))}i");
                    Console.WriteLine($"x2 = - {Math.Sqrt(Math.Abs(c / a))}i");
                }
            }
            else if (b != 0 && c == 0)
            {
                x1 = 0;
                x2 = -b / a;
            }
            Console.ReadKey();
        }
    }
}
