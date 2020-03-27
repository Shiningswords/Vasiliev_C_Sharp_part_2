/*
 Напишите программу, в которой есть обощенный статический метод с двумя аргументами обобщенного типа.
 При вызове  метода аргументы должны обмениваться значениями.
 */
using System;

namespace HW01
{
    class Program
    {
        static public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int x = 5;
            int y = 1;
            Console.WriteLine($"x: {x}, y: {y}");
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");
            Console.ReadKey();
        }
    }
}
