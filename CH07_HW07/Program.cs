/*
 Напишите программу со статическим обобщенным методом, которому в качестве аргумента передается массив из элементов обобщенного типа.
 При вызове метода выполняется сортировка элементов массива в порядке возрастания/убывания. Исп. ограничение Icompaarable.
 */
using System;

namespace HW07
{
    class Program
    {
        static void Sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 25, 85, 45, 75, 15, 35, 95, 65, 25 };
            Sort<int>(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" | " + arr[i]);
            }
            Console.WriteLine("|");
            Console.ReadKey();
        }
    }
}