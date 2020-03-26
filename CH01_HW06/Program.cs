/*
 Напишите программу, в которой на основе двух интерфейсов создается класс. В одном интерфейсе объявлен индексатор
 с символьным индексом, возвращающий целочисленное значение. В другом интерфейсе объявлен индексатор с целочисленным индексом,
 возвращающий символьное значение.
 */
using System;
interface MyInterface1
{
    int this[char symb] { get; }
}
interface MyInterface2
{
    char this[int n] { get; }
}
class MyClass : MyInterface1, MyInterface2
{
    public int this[char symb]
    {
        get => (int)symb;
    }
    public char this[int n]
    {
        get => (char)n;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        Console.WriteLine(A[(char)42] + " " + A[42]);
        Console.ReadKey();
    }
}