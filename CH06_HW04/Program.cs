/*
 Напишите программу, в которой два потока заполняют целочисленный массив. Один поток заполняет массив
 с начала до конца числами являщимися степенями двойки. Другой поток заполняет массив с конца до начала числами,
 являющимися степенями тройки.
 */
using System;
using System.Threading;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            Thread A = new Thread(() =>
            {
                int num = 2;
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = num;
                    num *= 2;
                    Thread.Sleep(1000);
                }
            });
            Thread B = new Thread(() =>
            {
                int num = 3;
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    nums[i] = num;
                    num *= 3;
                    Thread.Sleep(1000);
                }
            });
            A.Start();
            B.Start();
            bool check = true;
            while (true)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(" | " + nums[i]);
                }
                Console.WriteLine(" |");
                Thread.Sleep(100);
                if (!B.IsAlive && !A.IsAlive && !check) break;
                if (!B.IsAlive && !A.IsAlive) check = false;
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}