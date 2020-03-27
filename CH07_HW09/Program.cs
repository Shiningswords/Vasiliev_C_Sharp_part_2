/*
 Напишите программу, в которой есть обобщенный класс. У обобщенного класса есть поле, являющееся ссылкой на массив из элементов
 обобщенного типа. Опишите для класса операторный метод для оператора +, позволяющий вычислять сумму двух объектов класса. Результатом является
 объект этого же класса. Массив в объекте-результате получается объединением массивов суммируемых объектов.
 */
using System;

namespace HW09
{
    class MyClass<T>
    {
        public T[] arr;
        static public MyClass<T> operator +(MyClass<T> A, MyClass<T> B)
        {
            MyClass<T> Arr = new MyClass<T>();
            Arr.arr = new T[B.arr.Length + A.arr.Length];
            for (int i = 0; i < A.arr.Length; i++)
            {
                Arr.arr[i] = A.arr[i];
            }
            for (int i = A.arr.Length, j = 0; i < Arr.arr.Length; i++)
            {
                Arr.arr[i] = B.arr[j];
            }
            return Arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> A = new MyClass<int> { arr = new int[] { 1, 1, 1, 1 } };
            MyClass<int> B = new MyClass<int> { arr = new int[] { 1, 1, 1, 1 } };
            MyClass<int> C = A + B;
            for (int i = 0; i < C.arr.Length; i++)
            {
                Console.Write("| " + C.arr[i]);
            }
            Console.WriteLine(" | ");
            Console.ReadKey();
        }
    }
}