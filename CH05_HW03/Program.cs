/*
 Напишите программу, в которой уравнение вида Ax=B решается на множестве целых чисел.
 Решением является такое целое число x, которое, будучи умноженным на целое число А дает целое число B.
 Решение существует только в том случае, если целое число B без остатка делится на целое число A. или если оба параметра равны нулю.
 Предусмотреть обработку исключительных ситуаций.
 */
using System;

namespace HW03
{
    class Program
    {
        static int solve(int A, int B)
        {
            string msg;
            if (A == 0 && B == 0) msg = "Решение - любое число";
            else if (B % A == 0) return B / A;
            else msg = "Решений нет";
            throw new ArithmeticException(msg);
        }
        static void Main()
        {
            int A, B, x;
            Console.WriteLine("Решение уравнения Ax=B");
            try
            {
                Console.Write("Параметр A=");
                A = Int32.Parse(Console.ReadLine());
                Console.Write("Параметр B=");
                B = Int32.Parse(Console.ReadLine());
                x = solve(A, B);
                Console.WriteLine("Решение x={0}", x);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}