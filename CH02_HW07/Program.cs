/*
 Напишите программу, содержащую статический метод. Первым аргументом статическому методу передается целочисленный массив.
 Вторым аргументом статическому методу передается ссылка на другой метод. У метода-аргумента должен быть целочисленный аргумент, 
 и он должен возвращать целочисленный результат. Результатом статический метод возвращает целочисленный массив. Элементы этого массива
 вычисляются как результат вызова метода-аргумента, если ему передавать значения элементов из массива-аргумента. Предложите механизм
 проверки функциональности данного статического метода.
 */
using System;
delegate int MyDelegate(int n);
class Program
{
    static int[] Method(int[] arr, MyDelegate Del)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Del(arr[i]);
        }
        return arr;
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        MyDelegate Del = (x) => x + 1;
        Method(arr, Del);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}