/*
 Напишите программу, в которой класс создается на основе двух интерфейсов. В каждом из интерфейсов объявлено текстовое свойство
 с одним и тем же названием, доступное только для чтения. В классе выполнить общую (неявную) реализацию свойства, а также явную специализацию свойства для каждого интерфейса.
 Проверьте значение свойства для объекта класса, выполнив ссылку на объект через объектную переменную и интерфейсные переменные.
 */
using System;
interface MyInterface1
{
    string TXT { get; }
}
interface MyInterface2
{
    string TXT { get; }
}
class MyClass : MyInterface1, MyInterface2
{
    public string TXT
    {
        get => "Неявно реализованное свойство";
    }
    string MyInterface1.TXT
    {
        get => "Явно реализованное свойство интерфейса MyInterface1";
    }
    string MyInterface2.TXT
    {
        get => "Явно реализованное свойство интерфейса MyInterface2!";
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        MyInterface1 A1 = A;
        MyInterface2 A2 = A;
        Console.WriteLine(A.TXT);
        Console.WriteLine(A1.TXT);
        Console.WriteLine(A2.TXT);
        Console.ReadKey();
    }
}