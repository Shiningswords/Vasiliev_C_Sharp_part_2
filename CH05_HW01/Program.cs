/*
 Напишите программу, в которой пользователь вводит через консоль размер целочисленного массива.
 Массив создается, заполняется натуральными числами, а затем содержимое массива отображается в консольном окне.
 Предусмотреть обработку исключений, связанных с тем, что пользователь ввел некорректное значение для размера массива или
 ввел нечисловое значение.
 */
using System;

namespace HW01
{
    class Program
    {
        static void show(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
                Console.Write("|" + arr[i]);
            }
            Console.WriteLine("|");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            try
            {
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                show(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}