/*
 Напишите программу, в которой с помощью дочернего потока вычисляется сумма 2^n(n+1)/n! (точное значение для суммы равно 3е^2-1=21,167168)
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
            Console.WriteLine("Контрольное значение: {0}", 21.167168);
            Thread calc = new Thread(() => {
                // Индексная переменная:
                int n = 1;
                // Добавка к сумме:
                double q = 1;
                // Бесконечный цикл:
                do
                {
                    // Прибавление слагаемого к сумме:
                    s += q;
                    // Новое значение для индексной переменной:
                    n++;
                    // Вычисление добавки к сумме
                    // для следующего цикла:
                    q = Math.Pow(2, n) * (n + 1);
                    for (int k = 1; k <= n; k++)
                    {
                        q /= k;
                    }
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