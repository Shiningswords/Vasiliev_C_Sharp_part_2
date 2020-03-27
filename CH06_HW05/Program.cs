/*
 Напишите программу, содержащую класс с двумя полями: одно является ссылкой на целочисленный массив, а другое является ссылкой на символьный массив.
 Создайте объект класса, а также запустите на выполнение два дочерних потока. Один дочерний поток должен заполнить символьный массив объекта, а второй
 дочерний поток объекта должен заполнить целочисленный массив объекта. Способ заполнения предложите самостоятельно (например случайные символы и числа).
 */
using System;
using System.Threading;

namespace HW05
{
    class MyClass
    {
        public char[] symbs = new char[10];
        public int[] nums = new int[10];
        public Random rnd = new Random();
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            Thread A = new Thread(() =>
            {
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} начал работу.");
                for (int i = 0; i < obj.symbs.Length; i++)
                {
                    obj.symbs[i] = (char)obj.rnd.Next(65, 100);
                    Console.WriteLine($"Элемент symbs[{i}] заполнен значением {obj.symbs[i]}");
                    Thread.Sleep(obj.rnd.Next(1000, 2000));
                }
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} завершил работу.");
            });
            Thread B = new Thread(() =>
            {
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} начал работу.");
                for (int i = 0; i < obj.nums.Length; i++)
                {
                    obj.nums[i] = obj.rnd.Next(65, 100);
                    Console.WriteLine($"Элемент nums[{i}] заполнен значением {obj.nums[i]}");
                    Thread.Sleep(obj.rnd.Next(1000, 2000));
                }
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId} завершил работу.");
            });
            A.Start();
            B.Start();
        }
    }
}