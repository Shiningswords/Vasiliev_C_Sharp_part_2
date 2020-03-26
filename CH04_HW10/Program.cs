/*
 напишите программу, в которой объявляется переменная типа int, а также указатель на указатель на значение типа char.
 С помощью этого указателя нужно записать в первые два байта в области памяти, выделенной под переменную Int, символ 'A',
 а в следующие два байта - символ 'B'. Проверьте значение целочисленной переменной и объясните результат.
 */
using System;
class Program
{
    unsafe static void Main(string[] args)
    {
        int num;
        void* pnt = &num;
        byte* pntb1 = (byte*)pnt;
        byte* pntb2 = (byte*)pnt + 1;
        byte* pntb3 = (byte*)pnt + 2;
        byte* pntb4 = (byte*)pnt + 3;
        char* pntc = (char*)pntb1;
        char** pntpnt = &pntc;

        **pntpnt = 'A';
        pntc = (char*)pntb2;
        **pntpnt = 'A';
        pntc = (char*)pntb3;
        **pntpnt = 'B';
        pntc = (char*)pntb4;
        **pntpnt = 'B';

        Console.WriteLine(num);
        Console.WriteLine($"| {(char)pntb1[0]} | {(char)pntb2[0]} | {(char)pntb3[0]} | {(char)pntb4[0]} |");
        Console.ReadKey();
    }
}