﻿/*
 Напишите программу, содержащую класс с индексатором. При индексировании объекта в качестве значения соответствующего выражения
 возвращается целое число и, соответственно, присваивается целое число типа int. Присваиваемые значения записываются в массив с
 элементами типа byte. Используя обработку исключений и инструкцию checked, опишите индексатор так, чтобы при попытке присвоить
 проиндексированному объекту значение, выходящее за допустимый диапазон для значений типа byte, соответствующий элемент массива
 получал значение 255.
 */
using System;

namespace HW10
{
    class A
    {
        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    class B : A
    {
        public void Foo2()
        {
            Console.Write("Class B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj2 = new B();
            obj2.Foo();

            B obj3 = new B();
            obj3.Foo2();
            Console.ReadKey();
        }
    }
}