/*
Напишите программу, в которой объявляется переменная типа double и одномерный массив, элементы которого являются указателями
на значения типа byte. В этот массив записываются адреса однобайтовых блоков из области памяти, выделенной под double-переменную,
но через один: адрес первого блока, третьего, пятого и т.д. Используя этот массив указателей путем их индексирования, следует
заполнить все байты в области памяти, выделенной под double-переменную, последовательностью натуральных чисел и проверить результат.
*/
using System;

class Program
{
    unsafe static void Main(string[] args)
    {
        double num;
        void* pnt = &num;
        byte* pntb = (byte*)pnt;
        int size = sizeof(double) / sizeof(byte);
        byte*[] arr = new byte*[size];
        for (int i = 1; i < arr.Length; i += 2)
        {
            arr[i] = &pntb[i];
        }
        for (int i = 1, j = 1; i < arr.Length; i++)
        {
            if (i - 1 == 0)
            {
                arr[1][-1] = (byte)j;
                j++;
            }
            if (i % 2 != 0)
            {
                arr[i][0] = (byte)(j);
                arr[i][1] = (byte)(j + 1);
                j += 2;
            }
        }
        for (int k = 0; k < size; k++)
        {
            Console.Write("|" + pntb[k]);
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}
