﻿/*
 Напишите программу, содержащую статический метод, первым аргументом которого является целочисленный массив,
 а вторым аргументом - целочисленное значение. Методом при вызове выполняется проверка относительно наличия в массиве (первый аргумент)
 элемента со значением, определяемым вторым аргументом. Если такой элемент есть, то результатом возвращается индекс этого элемента
 (первого из них если таких элементов несколько). Если элемента с указанным значением в массиве нет, то метод генерирует исключение.
 Предложите способ проверки функциональности метода, включая обработку исключений.
 */
using System;

namespace HW05
{
    class Program
    {
        static int Method(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) return i;
            }
            throw new Exception("Такого значения нет");
        }
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5, 6 };
                int num = 4;
                int res = Method(arr, num);
                Console.WriteLine(res);
                res = Method(arr, 0);
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}