/*
 Напишите программу, содержащую обощенный класс со свойством обобщенного типа. Значением свойства возвращается значение закрытого поля
 обощенного типа. При присваивании значения свойству значение присваивается закрытому полю.
 */
using System;

namespace HW03
{
    class MyClass<T>
    {
        private T var;
        public MyClass(T var)
        {
            this.var = var;
        }
        public T Var { get => var; set => var = value; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> A = new MyClass<int>(100);
            Console.WriteLine(A.Var);
            A.Var = 2000;
            Console.WriteLine(A.Var);
            Console.ReadKey();
        }
    }
}