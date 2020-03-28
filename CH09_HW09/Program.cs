/*
 Напишите программу, содержащую статический метод с аргументом, являющимся целочисленным массивом.
 Результатом метод возвращает стек, состоящий из тех элементов массива, значение которых не меньше среднего значения по массиву.
 */
using System;
using System.Collections;

namespace HW09
{
    class Program
    {
        static Stack Method(int[] arr)
        {
            int avr = 0;
            Stack stack = new Stack();
            for (int i = 0; i < arr.Length; i++)
            {
                avr += arr[i];
            }
            avr /= arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= avr) stack.Push(arr[i]);
            }
            return stack;
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 6, 8, 5, 7, 4, 5, 6, 9, 10, 5, 8 };
            Stack stack = Method(arr);
            foreach (int num in stack)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}