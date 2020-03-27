/*
 напишите программу, в которой решается квадратное уровнение Ax^2+Bx+C=0. В общем случае уравнение имеет два решения
 x=-B+-Sqrt(B^2-4AC)/2A. Предложите схему обработки исключительных ситуаций. Для вычисления квадратного корня можно
 использовать статический метод Sqrt() из класса Math.
 */
using System;

namespace HW04
{
    class Program
    {
        static void Solve(double A, double B, double C, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;
            if (Math.Pow(B, 2) - (4 * A * C) > 0 && A != 0)
            {
                x1 = Math.Round((double)((-B + (Math.Sqrt((Math.Pow(B, 2) - 4 * A * C)))) / (2 * A)), 2);
                x2 = Math.Round((double)((-B - (Math.Sqrt((Math.Pow(B, 2) - 4 * A * C)))) / (2 * A)), 2);
            }
            else if (Math.Pow(B, 2) - (4 * A * C) == 0 && A != 0)
            {
                x1 = Math.Round((double)((-B + (Math.Sqrt((Math.Pow(B, 2) - 4 * A * C)))) / (2 * A)), 2);
                x2 = Math.Round((double)((-B - (Math.Sqrt((Math.Pow(B, 2) - 4 * A * C)))) / (2 * A)), 2);
            }
            else if (Math.Pow(B, 2) - (4 * A * C) < 0)
            {
                throw new ArithmeticException("Нет корней");
            }
            else
            {
                throw new ArithmeticException("A не может быть равно 0");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Параметр A=");
                double A = Double.Parse(Console.ReadLine());
                Console.Write("Параметр B=");
                double B = Double.Parse(Console.ReadLine());
                Console.Write("Параметр C=");
                double C = Double.Parse(Console.ReadLine());
                double x1 = 0, x2 = 0;
                Solve(A, B, C, out x1, out x2);
                Console.WriteLine("Решение x1={0} x2={1}", x1, x2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}