/*
 Напишите программу, в которой есть класс с целочисленным полем. На основе класса создайте объект. С помощью указателей
 запишите в первые 2 байта области памяти, выделенной под поле объекта, символ 'A', а в следующие 2 байта символ 'B'.
 Проверьте значения поля и объясните результат.
 */
using System;
class MyClass
{
    public int num;
}
class Program
{
    unsafe static void Main(string[] args)
    {
        MyClass A = new MyClass();
        fixed (void* pnt = &A.num)
        {
            byte* pntb = (byte*)pnt;
            pntb[0] = (byte)'A';
            pntb[1] = (byte)'A';
            pntb[2] = (byte)'B';
            pntb[3] = (byte)'B';
            Console.WriteLine($"{(char)pntb[0]} {(char)pntb[1]} {(char)pntb[2]} {(char)pntb[3]}");
            Console.WriteLine(A.num);
        }
        Console.ReadKey();
    }
}