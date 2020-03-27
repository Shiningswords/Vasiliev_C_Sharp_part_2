/*
 напишите программу, в которой описаны два класса пользовательских исключений (один создается наследованием класса Exception,
 а другой создается наследованием класса ApplicationException). Опишите класс с закрытым символьным массивом и индексатором, который позволяет
 присваиваивать значения элементам массива и считывать их значения. Определите индексатор таким образом, чтобы при слишком большом индексе
 (выходящем за верхнюю границу) генерировалось исключение первого пользовательского класса исключений, а при отрицательном индексе генерировалось
 исключение второго пользовательского класса. В главном методе предложите механизм проверки функциональности индексатора для индексируемых объектов.
 */
using System;

namespace HW09
{
    class MyException1 : Exception { }
    class MyException2 : ApplicationException { }
    class MyClass
    {
        private char[] symbs;
        public MyClass(int size)
        {
            symbs = new char[size];
            char a = 'A';
            for (int i = 0; i < symbs.Length; i++)
            {
                symbs[i] = a++;
            }
        }
        public char this[int n]
        {
            get
            {
                return symbs[n];
            }
            set
            {
                if (n < 0) throw new MyException1();
                else if (n > symbs.Length - 1) throw new MyException2();

                symbs[n] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClass A = new MyClass(6);
                Console.WriteLine(A[3]);
                A[55] = '4';
                A[-1] = '2';
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}