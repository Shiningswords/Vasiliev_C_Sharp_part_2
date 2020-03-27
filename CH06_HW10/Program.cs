/*
 Напишите программу, в которой с помощью дочернего потока вычисляется сумма n^3-1/n^3+1 (точное значение для суммы равно 2/3)
 */
using System;
using System.Threading;

namespace HW09
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.WriteLine("Контрольное значение: {0}", 0.66666666666666);
            Thread calc = new Thread(() => {
                // Индексная переменная:
                int n = 2;
                do
                {
                    s = (Math.Pow(n, 3) - 1) / (Math.Pow(n, 3) + 1);
                    Thread.Sleep(100);
                } while (true);
            });
            calc.Start();
            Thread.Sleep(3000);
            calc.Abort();
            Console.WriteLine("Вычисленное значение: {0}", s);
        }
    }
}