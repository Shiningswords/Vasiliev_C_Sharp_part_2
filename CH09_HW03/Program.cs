/*
 напишите программу, в которой пользователь вводит дату своего рождения, а программа вычисляет, сколько прошло полных лет,
 месяцев и дней от указанной даты до текущей.
 */
using System;

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите дату вашего рождения");
                DateTime dtn = DateTime.Now;
                DateTime dt = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"С даты вашего рождения прошло: лет - {(dtn - dt).Days / 365}, месяцев - {(dtn - dt).Days / 12}, дней - {(dtn - dt).Days}");
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели неправильный формат даты.");
            }
            Console.ReadKey();
        }
    }
}