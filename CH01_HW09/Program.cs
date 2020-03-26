/*
 Напишите программу, в которой класс создается на основе абстрактного базового класса и интерфейса. В абстрактном классе есть поле,
 являющееся ссылкой на защищенный символьный массив. Конструктору класса передается текстовый аргумент, на основе которого создается и заполняется
 символьный массив. В абстрактном классе опишите метод, который по целочисленному аргументу возвращает значение символа с соответствующим индексом в массиве.
 Также в абстрактном классе должен быть объявлен абстрактный метод с двумя аргументами (целое число и символ), не возвращающий результат. В интерфейсе должен быть
 объявлен метод с таким же именем, но с одним текстовым аргументом. Также в интерфейсе должен быть объявлен индексатор (с двумя аксессорами) с символьным результатом
 и целочисленным индексом. На основе абстрактного классе и интерфейса нужно создать класс. Абстрактный метод из базового класса переопределить таким образом,
 чтобы он присваивал значение элементу массива, метод из интерфейса должен создавать новый массив, а индексатор должен предоставлять доступ к элементам массива.
 */
using System;
abstract class Base
{
    protected char[] symbs;
    public Base(string txt)
    {
        symbs = new char[txt.Length];
        for (int i = 0; i < symbs.Length; i++)
        {
            symbs[i] = txt[i];
        }
    }
    public char Symbol(int n)
    {
        return (char)symbs[n];
    }
    abstract public void Method(int n, char symb);
}
interface MyInterface
{
    void Method(string txt);
    char this[int n] { get; set; }
}
class MyClass : Base, MyInterface
{
    public MyClass(string txt) : base(txt) { }
    public override void Method(int n, char symb)
    {
        this.symbs[n] = symb;
    }
    public void Method(string txt)
    {
        symbs = new char[txt.Length];
        for (int i = 0; i < symbs.Length; i++)
        {
            symbs[i] = txt[i];
        }
    }
    public char this[int n]
    {
        get => symbs[n];
        set => symbs[n] = value;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass("Hello!");
        Console.WriteLine(A.Symbol(0));
        A.Method(0, 'Y');
        Console.WriteLine(A[0]);
        A.Method("Goodbye");
        for (int i = 0; i < "Goodbye".Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.ReadKey();
    }
}