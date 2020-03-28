/*
 Напишите программу, в которой на основе классе ArrayList создается коллекция и заполняется текстовыми элементами.
 Текстовые значения - это слова из текста, записанного в текстовую переменную. Исходите из того, что слова в тексте разделяются пробелами.
 */
using System;
using System.Collections;
using System.Text;

namespace HW08
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Аптека, улица, фонарь, аптека, бессмысленный и тусклый свет, живи ещё хоть четверть века, исхода нет";
            ArrayList al = new ArrayList(txt.Split(' '));
            foreach (string str in al)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}