/*
 Напишите программу, в которой описывается класс для ошибки пользовательского типа. У класса должно быть поле,
 являющееся ссылкой на символьный массив. В качестве аргумента конструктору класса передается целое число, определяющее размер массива.
 Массив заполняется последовательностью букв (например, начиная с буквы А). В главном методе программы для реализации символьного массива 
 создается объект исключения пользовательского класса. Для отображения содержимого массива исскуственно генерируется исключение, в обработка исключения
 сводится к отображению содержимого массива из объекта исключения.
 */
using System;

namespace HW08
{
    class MyException : ApplicationException
    {
        public char[] symbs;
        public MyException(int size)
        {
            symbs = new char[size];
            char a = 'A';
            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = a++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyException A = new MyException(10);
            try
            {
                throw A;
            }
            catch (MyException e)
            {
                for (int i = 0; i < e.symbs.Length; i++)
                {
                    Console.Write(e.symbs[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}