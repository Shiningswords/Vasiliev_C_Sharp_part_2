/*
 Напишите программу, в которой для указанного интервала времени (в годах) определяются годы, первый  день которых (1 января) попадает на понедельник.
 */
using System;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1991;
            int end = 2050;
            int day = 1;
            int month = 1;
            DateTime dt;
            for (int year = start; year <= end; year++)
            {
                dt = new DateTime(year, month, day);
                if (dt.DayOfWeek == DayOfWeek.Monday) Console.WriteLine(dt.ToString("d"));
            }
            Console.ReadKey();
        }
    }
}