/*
 Напишите программу, в которой создается ассоциативная коллекция. Значения элементов в коллекции - это случайные буквы.
 Значения ключей определяются так: первый ключ равен 1, второй равен 2, а каждый последующий ключ определяется как сумма двух предыдущих.
 */
using System;
using System.Collections;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            SortedList sl = new SortedList();
            sl.Add(1, (char)rnd.Next(65, 100));
            sl.Add(2, (char)rnd.Next(65, 100));
            for (int j = 0, i = (int)sl.GetKey(j) + (int)sl.GetKey(j + 1); i < 100; j++, i = (int)sl.GetKey(j) + (int)sl.GetKey(j + 1))
            {
                sl.Add(i, (char)rnd.Next(65, 100));
            }
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine($"ключ: {sl.GetKey(i)} значение: {sl[sl.GetKey(i)]}");
            }
            Console.ReadKey();
        }
    }
}