/*
 напишите программу, в которой создается одномерный целочисленный массив и запускаются два дочерних потока.
 Один дочерний поток выполняет поиск элемента с наибольшим значением, а второй поток выполняет поиск элемента с наименьшим значением.
 Найденные значения отображаются в консольном окне.
 */
using System;
using System.Threading;

namespace HW06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 25, 54, 87, 12, 65, 98, 71, 21, 65, 92, 3, 6, 84, 1, 45, 690, 120, 69 };
            Thread A = new Thread(() =>
            {
                int min = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < min) min = nums[i];
                    Thread.Sleep(100);
                }
                Console.WriteLine($"Минимальное число в массиве {min}");
            });
            Thread B = new Thread(() =>
            {
                int max = nums[0];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > max) max = nums[i];
                    Thread.Sleep(150);
                }
                Console.WriteLine($"Максимальное число в массиве {max}");
            });
            A.Start();
            B.Start();
        }
    }
}