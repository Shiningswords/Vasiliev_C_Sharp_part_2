/*
 напишите программу, в которой пользователь последовательно вводит два целых числа.
 Программа вычисляет остаток от деления большего числа на меньшее число. Программный код следует 
 написать с учетом обработки возможных ошибок.
 */
using System;

namespace HW02
{
    class Program
    {
        static int Divide(int a, int b)
        {
            try
            {
                int res;
                if (a > b)
                {
                    res = a % b;
                }
                else
                {
                    res = b % a;
                }
                return res;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("number 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("number 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int res = Divide(num1, num2);
                Console.WriteLine(res);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}