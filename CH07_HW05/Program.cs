/*
 Напишите программу, в которой создается цепочка из объектов, созданных на основе обобщенного класса:
 имеется последовательность объектов, и в этой последовательности первый объект ссылается на второй, второй на третий и т.д.
 Обобщенный класс, помимо прочего, должен содержать поле обобщенного типа и поле, являющееся ссылкой на следующий объект в цепочке.
 Предложите методы для работы с такой цепочкой объектов.
 */
using System;

namespace HW05
{
    class MyClass<T>
    {
        public T field;
        public MyClass<T> Next;
        public override string ToString()
        {
            if (Next != null) return $"{field}";
            else return $"{field}, this is the last one";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> A1 = new MyClass<int>();
            A1.field = 1;
            MyClass<int> A2 = new MyClass<int>();
            A1.Next = A1;
            A2.field = 2;
            MyClass<int> A3 = new MyClass<int>();
            A3.field = 3;
            A2.Next = A3;

            Console.WriteLine(A1);
            Console.WriteLine(A2);
            Console.WriteLine(A3);
            Console.ReadKey();
        }
    }
}