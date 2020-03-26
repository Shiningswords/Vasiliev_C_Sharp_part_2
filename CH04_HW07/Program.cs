/*
 Напишите программу, в которой создается массив из двух элементов типа int. Заполните этот массив по байтам
 последовательностью натуральных чисел. Проверьте значения байтов, значения элементов целочисленного массива
 и объясните результат.
 */
using System;
class Program
{
    unsafe static void Main(string[] args)
    {
        int[] arr = new int[2];
        fixed (void* ptn = arr)
        {
            byte* ptnb = (byte*)ptn;
            for (int i = 0, j = 1; i < (sizeof(int) / sizeof(byte) * arr.Length); i++, j++)
            {
                ptnb[i] = (byte)j;
            }
            for (int k = 0; k < (sizeof(int) / sizeof(byte) * arr.Length); k++)
            {
                Console.Write("|" + ptnb[k]);
            }
            Console.WriteLine("|");
        }
        for (int k = 0; k < arr.Length; k++)
        {
            Console.Write("|" + arr[k]);
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}