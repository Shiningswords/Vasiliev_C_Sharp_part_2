/*
 напишите программу, содержащую два интерфейса. В первом интерфейсе опишите метод с символьным аргументом и целочисленным
 результатом, а во втором интерфейсе - метод с целочисленным аргументом и символьным результатом. опишите класс, реализующий
 оба интерфейса. Проверьте работу методов, вызвав их через объектную переменную и через интерфейсные переменные (там, где это возможно).
 */
using System;
interface MyInterface1
{
    int Method(char symb);
}
interface MyInterface2
{
    char Method2(int n);
}
class MyClass : MyInterface1, MyInterface2
{
    public int Method(char symb)
    {
        return (int)symb;
    }
    public char Method2(int n)
    {
        return (char)n;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        MyInterface1 AI1 = A;
        MyInterface2 AI2 = A;
        Console.WriteLine(A.Method2(42) + " " + A.Method((char)42));
        Console.WriteLine(AI1.Method((char)42) + " " + AI2.Method2(42));
        Console.ReadKey();
    }
}