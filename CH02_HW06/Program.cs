/*
 Напишите программу, в которой с помощью делегатов и анонимных методов (лямбда-выражений) создается экземпляр делегата, который
 вызывается без аргументов, а результатом возвращает текстовое значение с названием дня недели.
 При каждом вызове экземпляра результатом возвращается название следующего дня недели. После "Воскресения" результатом возвращается "Понедельник" и т.д.
 */
using System;
delegate string MyDelegate();

class Program
{
    static string[] arr = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    static int count = 0;

    static MyDelegate Delegate = () =>
    {
        switch (count)
        {
            case 0:
                count++;
                return arr[0];
            case 1:
                count++;
                return arr[1];
            case 2:
                count++;
                return arr[2];
            case 3:
                count++;
                return arr[3];
            case 4:
                count++;
                return arr[4];
            case 5:
                count++;
                return arr[5];
            case 6:
                count = 0;
                return arr[6];
            default:
                return arr[0];
        }
    };
    static void Main(string[] args)
    {
        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine(Delegate());
        }
        Console.ReadKey();
    }
}