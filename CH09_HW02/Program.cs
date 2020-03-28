/*
 Напишите программу, в которой есть производный класс. Класс создается на основе базового класса и реализует интерфейс.
 Производный класс, базовый класс и интерфейс описываются в разных пространствах имен.
 */
using System;

namespace First
{
    class A
    {
        protected int num = 100;
    }
}
namespace Second
{
    class B : First.A, Third.C
    {
        public void Show()
        {
            Console.WriteLine(num);
        }
    }
}
namespace Third
{
    interface C
    {
        void Show();
    }
}

namespace HW02
{
    class Program
    {
        static void Main(string[] args)
        {
            Second.B obj = new Second.B();
            obj.Show();
            Console.ReadKey();
        }
    }
}