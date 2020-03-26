/*
 напишите программу, содержащую статический метод с тремя действительными (тип double) аргументами. Результатом статического метода
 является ссылка на метод, вычисляющий квадратичный трехчлен с коэффициентами, определяемыми аргументами статического метода.
 Другими словами, если статический метод вызывается с числовыми аргументами a, b и c, то результатом является ссылка на метод,
 который для аргумента x типа double результатом вычисляет значение выражения a*x*x+b*x+c.
 */
using System;
delegate double MyDelegate(double x);
class Program
{
    static MyDelegate Method(double a, double b, double c)
    {
        MyDelegate Del = (x) => a * x * x + b * x + c;
        return Del;
    }
    static void Main(string[] args)
    {
        MyDelegate Del = Method(1.1, 2.2, 3.3);
        Console.WriteLine(Del(2));
        Console.ReadKey();
    }
}