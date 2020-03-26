/*
 Напишите программу, в которой объявляется переменная типа double. В область памяти, выделенную под эту переменную, 
 запишите такие значения: в первый байт запишите значение 1, в следующие два байта запишите символ 'A', в следующие четыре байта
 запишите значение 2 и в оставшийся восьмой байт запишите значение 3.
 */
using System;
class Program
{
    unsafe static void Main(string[] args)
    {
        double num;
        int size = sizeof(double) / sizeof(byte);
        void* pnt = &num;
        byte* pntb = (byte*)pnt;
        pntb[0] = 1;
        pntb[1] = (byte)'A';
        pntb[2] = (byte)'A';
        pntb[3] = 2;
        pntb[4] = 2;
        pntb[5] = 2;
        pntb[6] = 2;
        pntb[7] = 3;
        for (int k = 0; k < size; k++)
        {

            if (pntb[k] == (char)65) Console.Write("|" + (char)pntb[k]);
            else Console.Write("|" + pntb[k]);
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}