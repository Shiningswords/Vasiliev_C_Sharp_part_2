/*
 Напишите программу, в которой объявляется переменная типа int. Переменной в качестве значения присваивается случайное число.
 Затем (с использованием указателей) выполняется циклический сдвиг байтов: первый байт становится вторым, второй байт становится третьим,
 третий байт становится четвертым, а четвертый байт становится первым. Предложите способ проверки правильности вычислений.
 */
using System;

class Program
{

    unsafe static void Main(string[] args)
    {
        Random rnd = new Random();
        int size = sizeof(int) / sizeof(byte);
        int num = rnd.Next(1000000, 100000000);
        void* pnt = &num;
        byte* pntb = (byte*)pnt;
        for (int k = 0; k < size; k++)
        {
            Console.Write("|" + pntb[k]);
        }
        Console.WriteLine("|");
        byte tmp = (byte)pntb[0];
        pntb[0] = (byte)pntb[1];
        pntb[1] = (byte)pntb[2];
        pntb[2] = (byte)pntb[3];
        pntb[3] = tmp;
        for (int k = 0; k < size; k++)
        {
            Console.Write("|" + pntb[k]);
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}
