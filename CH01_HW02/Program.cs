/*
 Напишите программу, содержащую базовый класс с защищенным текстовым полем. У класса должен быть конструктор
 с текстовым аргументом, доступное для чтения абстрактное целочисленное свойство, доступный для чтения абстрактный индексатор с
 целочисленным индексом, не возвращающий результат абстрактный метод с текстовым аргументом, не возвращающий результат абстрактный
 метод без аргументов. В производном классе: свойство результатом возвращает количество символов в текстовом поле, значением
 выражения с проиндексированным объектом является код символа в тексте, метод с текстовым аргументом присваивает новое значение полю,
 а метод без аргументов отображает значение поля в консольном окне.
 */
using System;
abstract class Base
{
    protected string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public abstract int Size { get; }
    public abstract int this[int n] { get; }
    public abstract void Change(string txt);
    public abstract void Change();
}
class MyClass : Base
{
    public MyClass(string txt) : base(txt) { }
    public override int Size { get => txt.Length; }
    public override int this[int n]
    {
        get => (int)txt[n];
    }
    public override void Change(string txt)
    {
        this.txt = txt;
    }
    public override void Change()
    {
        Console.WriteLine(this.txt);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass("Коничива!");
        Console.WriteLine(A[0]);
        Console.WriteLine(A.Size);
        A.Change();
        A.Change("Конбанва!");
        A.Change();
        Console.ReadKey();
    }
}