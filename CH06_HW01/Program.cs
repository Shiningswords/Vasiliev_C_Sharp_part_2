/*
 Напишите программу, в которой для заданного целочисленного значения вычисляется факториал, двойной факториал и 
 число из последовательности Фибоначчи. Для вычисления каждого из значений запускается дочерний поток.
 Факториал n! вычисляется как произведение чисел от 1 до этого числа включительно. Двойной факториал n!!
 вычисляется как произведение натуральных чисел "через одно", то есть n!! = n * (n - 2) * (n - 4) *... 
 (последний множитель равен 2 или 1 в зависимости от того, четное число n, или нечетное).
 */
using System;
using System.Threading;

namespace HW01
{
    class Program
    {
        static public int Fact(int num)
        {

            if (num <= 1) return 1;
            else return num * Fact(num - 1);
        }
        static public int Fact2(int num)
        {
            if (num <= 1) return 1;
            if (num == 2) return 2;
            else return num * Fact2(num - 2);
        }
        static public int Fib(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            else return Fib(num - 1) + Fib(num - 2);
        }
        static void Main(string[] args)
        {
            int num = 8;
            Thread A = new Thread(() =>
            {
                Console.WriteLine($"Вычисление факториала {num}!");
                Thread.Sleep(1000);
                Console.WriteLine($"Факториал {num} = {Fact(num)}");
            });
            A.Start();
            Thread B = new Thread(() =>
            {
                Console.WriteLine($"Вычисление двойного факториала {num}!");
                Thread.Sleep(1500);
                Console.WriteLine($"Двойной факториал {num} = {Fact2(num)}");
            });
            B.Start();
            Thread C = new Thread(() =>
            {
                Console.WriteLine($"Вычисление числа Фибонначи под номером {num}!");
                Thread.Sleep(2000);
                Console.WriteLine($"Число Фибонначи под номером {num} = {Fib(num)}");
            });
            C.Start();
        }
    }
}