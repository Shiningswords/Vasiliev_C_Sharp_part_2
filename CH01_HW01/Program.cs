/*
 Напишите программу, содержащую абстрактный базовый класс с защищенным полем, являющимся ссылкой на целочисленный массив.
 У класса должен быть конструктор с одним аргументом (определяет размер массива и создает его), целочисленное свойство (значение - 
 размер массива), абстрактный метод (без аргументов, не возвращает результат) и индексатор с целочисленным индексом (доступен для чтения и записи).
 В производном классе описать абстрактный метод из базового класса, чтобы он отображал в консоли содержимое массива. Индексатор определить так,
 чтобы с его помощью можно было прочитать значение элемента массива и присвоить значение элементу массива.
 */
using System;
abstract class Base
{
    protected int[] arr;
    public Base(int n)
    {
        arr = new int[n];
    }
    public int Size { get => arr.Length; }
    public abstract void Show();
    public abstract int this[int n] { get; set; }
}
class MyClass : Base
{
    public MyClass(int n) : base(n) { }
    public override void Show()
    {
        for (int i = 0; i < this.Size; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    public override int this[int n]
    {
        get
        {
            if (n >= 0 && n <= this.Size) return arr[n];
            else return 0;
        }
        set
        {
            if (n >= 0 && n <= this.Size) arr[n] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(4);
        Console.WriteLine("Размер: " + A.Size + " " + A[56]);
        A.Show();
        A[3] = 42;
        A.Show();
        Console.ReadKey();
    }
}