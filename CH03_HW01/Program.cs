/*
 Напишите программу, в которой объявляется перечисление для представления дней недели. Предложите методы (или добавьте в главный метод блоки кода),
 позволяющие по числовому значению определить день недели (с учетом периодической повторяемости дней), а также позволяющие по двум значениям из перечисления
 определить минимальное количество дней между соответствующими днями недели.
 */
using System;
enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

class Program
{
    static void DayofWeek(int n)
    {
        if (n >= 1 && n <= 7)
        {
            Console.WriteLine((Days)n);
        }
        else
        {
            Console.WriteLine("Нет такого дня недели");
        }
    }
    static void Count(Days first, Days last)
    {
        if (first > last)
        {
            Console.WriteLine((int)(first - last - 1));
        }
        else
        {
            Console.WriteLine((int)(last - first - 1));
        }
    }
    static void Main(string[] args)
    {
        DayofWeek(1);
        DayofWeek(6);
        DayofWeek(75);
        Count((Days)4, (Days)5);
        Count((Days)7, (Days)1);
        Console.ReadKey();
    }
}
