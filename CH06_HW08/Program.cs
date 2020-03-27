/*
 напишите программу, в которой создается двумерный символьный массив. Массив заполняется случайными символами.
 Заполнение выполняется по столбикам. Для заполнения каждого столбика запускается отдельный дочерний поток.
 */
using System;
using System.Threading;

namespace HW08
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] symbs = new char[5, 5];
            Random rnd = new Random();
            Thread[] thrds = new Thread[symbs.GetLength(1)];
            for (int i = 0; i < thrds.Length; i++)
            {
                int I = i;
                thrds[I] = new Thread(() =>
                {
                    for (int j = 0; j < symbs.GetLength(0); j++)
                    {

                        symbs[j, I] = (char)rnd.Next(65, 100);
                    }
                });
                Console.WriteLine($"Столбец {i} заполнен");
                thrds[I].Start();
                Thread.Sleep(100);
            }

            for (int i = 0; i < thrds.Length; i++)
            {
                if (thrds[i].IsAlive) thrds[i].Join();
            }

            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    Console.Write("{0,-4}", symbs[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}