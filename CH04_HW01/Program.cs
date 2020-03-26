/*
 Напишите программу, в которой объявляется переменная типа int. В первый и последний байты области памяти,
 выделенной под эту переменную, запишите число 1, а в два внутренних байта запишите символ 'A'.
 */
using System;

class Program
{
    unsafe static void Main(string[] args)
    {
        int num;
        void* pnt = &num;
        int n = sizeof(int) / sizeof(byte);
        byte* pntb = (byte*)pnt;
        pntb[0] = 1;
        pntb[n - 1] = 1;
        for (int i = 1; i < n - 1; i++)
        {
            pntb[i] = (byte)'A';
        }
        for (int k = 0; k < n; k++)
        {

            if (pntb[k] == (char)65) Console.Write("|" + (char)pntb[k]);
            else Console.Write("|" + pntb[k]);
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}
