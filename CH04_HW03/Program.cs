/*
 Напишите программу, в которой объявляются три переменне типа int. Первые две переменные получают случайные значения.
 Область памяти, выделенная под третью переменную, заполняется следующим образом: первые два байта копируются из первой переменной,
 а следующие два байта копируются из второй переменной. Предложите способ проверки корректности вычислений.
 */
using System;
class Program
{
    unsafe static void Main(string[] args)
    {
        Random rnd = new Random();
        int num1 = rnd.Next(1000000, 100000000);
        int num2 = rnd.Next(1000000, 100000000);
        Console.WriteLine(num1 + " " + num2);
        int num3;
        int size = sizeof(int) / sizeof(byte);
        void* pnt1 = &num1;
        byte* pntb1 = (byte*)pnt1;
        void* pnt2 = &num2;
        byte* pntb2 = (byte*)pnt2;
        void* pnt3 = &num3;
        byte* pntb3 = (byte*)pnt3;
        pntb3[0] = (byte)pntb1[0];
        pntb3[1] = (byte)pntb1[1];
        pntb3[2] = (byte)pntb2[2];
        pntb3[3] = (byte)pntb2[3];
        for (int k = 0; k < size; k++)
        {
            Console.Write("|" + pntb3[k]);
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}
