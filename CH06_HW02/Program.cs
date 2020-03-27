/*
 Напишите программу, в которой в главном потоке целочисленная переменная через определенные промежутки получает случайное значение.
 Два дочерних потока периодически (через определнные промежутки времени) проверяют значение переменной. Первый поток проверяет является ли
 значение переменной нечетным, а второй поток проверяет, делится ли значение переменной на 3. Если проверка успешная то соответствующий поток выводит
 выводит в консольное окно сообщение.
 */
using System;
using System.Threading;

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Random rnd = new Random();
            Thread A = new Thread(() =>
            {
                while (true)
                {
                    num = rnd.Next(1, 100);
                    Console.WriteLine(num);
                    Thread.Sleep(1000);
                }
            });
            Thread B = new Thread(() =>
            {
                while (true)
                {
                    if (num % 2 != 0) Console.WriteLine($"Число {num} нечетное");
                    Thread.Sleep(1000);
                }
            });
            Thread C = new Thread(() =>
            {
                while (true)
                {
                    if (num % 3 == 0) Console.WriteLine($"Число {num} делится на 3");
                    Thread.Sleep(1000);
                }
            });
            A.Start();
            B.Start();
            C.Start();
        }
    }
}