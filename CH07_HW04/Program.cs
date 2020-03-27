/*
 Напишите программу, содержащую обобщенный класс с индексатором обобщенного типа. Также в классе должно быть поле,
 являющееся ссылкой на массив из элементов обобщенного типа. Считывание и присваивание значений с использованием индексатора
 подразумевают считывание значений элементов массива и присваивание значений элементам массива.
 */
using System;

namespace HW04
{
    class MyClass<T>
    {
        private T[] arr = new T[5];
        public T this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> A = new MyClass<int>();
            A[0] = 120;
            A[4] = 11;
            Console.WriteLine($"{A[0]} {A[4]}");
            Console.ReadKey();
        }
    }
}