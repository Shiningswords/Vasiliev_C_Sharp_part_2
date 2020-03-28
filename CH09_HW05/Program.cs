/*
 Напишите программу, содержащую статический метод, которому передается два аргумента, определяющих некоторые даты.
 Метод сравнивает эти даты на предмет совпадения. Даты считаются совпадающими, если они отличаются не более чем на определенный интервал времени.
 Интервал времени задается третьим аргументом метода.
 */
using System;

namespace HW05
{
    class Program
    {
        static bool Compare(DateTime dt2, DateTime dt1, int ticks)
        {
            if (dt1.Ticks > dt2.Ticks && dt1.Ticks - dt2.Ticks <= ticks) return true;
            else if (dt1.Ticks < dt2.Ticks && dt2.Ticks - dt1.Ticks <= ticks) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2020, 12, 31, 14, 05, 00);
            DateTime dt2 = new DateTime(ticks: dt1.Ticks + 15);
            DateTime dt3 = new DateTime(ticks: dt1.Ticks + 30);
            Console.WriteLine(Compare(dt1, dt2, 20));
            Console.WriteLine(Compare(dt2, dt3, 20));
            Console.WriteLine(Compare(dt1, dt3, 20));
            Console.WriteLine(Compare(dt3, dt1, 30));
            Console.ReadKey();
        }
    }
}