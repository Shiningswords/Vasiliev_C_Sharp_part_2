/*
 Напишите программу, в которой создается двумерный целочисленный массив. Массив заполняется построчно: первая строка заполняется числами,
 являющимися степенями двойки, вторая заполняется степенями 3, и так далее. Для заполнения каждой строки запускается дочерний поток.
 Объектные переменные для потоков следует организовать в виде массива.
 */
using System;
using System.Threading;

namespace HW07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[5, 5];
            int num = 2;
            Thread[] thrds = new Thread[nums.GetLength(0)];
            for (int i = 0; i < thrds.Length; i++)
            {
                int I = i;
                thrds[I] = new Thread(() =>
                {
                    int tmp = num;
                    int tmp2 = num;
                    for (int j = 0; j < nums.GetLength(1); j++)
                    {

                        nums[I, j] = tmp;
                        tmp *= tmp2;

                    }
                });
                Console.WriteLine($"Строка {i} заполнена");
                thrds[I].Start();
                Thread.Sleep(100);
                num++;
            }
            for (int i = 0; i < thrds.Length; i++)
            {
                if (thrds[i].IsAlive) thrds[i].Join();
            }
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write("{0,-4}", nums[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}