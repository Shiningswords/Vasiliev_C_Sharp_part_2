/*
 Напишите программу, в которой символьный массив заполняется с помощью двух дочерних потоков:
 первый поток заполняет элементы с четными индексами латинскими буквами, а второй заполняет элементы
 с нечетными индексами кириллическими буквами.
 */
using System;
using System.Threading;

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[20];
            char symb1 = 'A';
            char symb2 = 'а';
            Thread A = new Thread(() =>
            {
                for (int i = 0; i < arr.Length; i = i + 2)
                {
                    Thread.Sleep(900);
                    arr[i] = symb1;
                    symb1++;
                }
            });
            Thread B = new Thread(() =>
            {
                for (int i = 1; i < arr.Length; i = i + 2)
                {
                    Thread.Sleep(1200);
                    arr[i] = symb2;
                    symb2++;
                }
            });
            A.Start();
            B.Start();
            bool check = true;
            while (true)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" | " + arr[i]);
                }
                Console.WriteLine(" |");
                Thread.Sleep(500);
                if (!B.IsAlive && !A.IsAlive && !check) break;
                if (!B.IsAlive && !A.IsAlive) check = false;
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}