/*
 напишите программу, содержащую класс с индексатором. Через индексатор можно получить доступ к элементам закрытого целочисленного массива
 Используя обработку исключений, опишите статический метод, аргументом которому передается объект класса, а результатом возвращается
 размер закрытого массива в этом объекте.
 */
using System;

namespace HW07
{
    class MyClass
    {
        private int[] arr = { 1, 2, 54 };
        public int this[int n]
        {
            get
            {
                return arr[n];
            }
            set
            {
                arr[n] = value;
            }
        }
    }
    class Program
    {
        static int Length(MyClass A)
        {
            int i = 0;
            int res = 0;
            while (true)
            {
                try
                {
                    res = A[i];
                }
                catch (Exception) { break; }
                i++;
            }
            return i;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Length(new MyClass()));
            Console.ReadKey();
        }
    }
}