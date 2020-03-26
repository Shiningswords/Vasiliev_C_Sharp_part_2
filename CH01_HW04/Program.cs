/*
 Напишите программу, содержащую абстрактный класс с двумя защищенными целочисленными полями и конструктор с
 двумя целочисленными аргументами. В классе должен быть объявлен абстрактный индексатор целочисленным индексом.
 Опишите интерфейс, в котором есть метод с целочисленным аргументом и целочисленным результатом.
 Опишите класс, который наследует абстрактный базовый класс и реализует интерфейс. В этом классе опишите индексатор так,
 чтобы при четном выполнялось обращение к первому полю, а при нечетном индексе обращение выполнялось ко второму полю.
 Метод следует описать таким образом, чтобы он результатом возвращал сумму значений полей, умноженную на аргумент метода.
 */
using System;
abstract class Base
{
    protected int num1;
    protected int num2;
    public Base(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    abstract public int this[int n] { get; }
}
interface MyInterface
{
    int Method(int n);
}
class MyClass : Base, MyInterface
{
    public MyClass(int num1, int num2) : base(num1, num2) { }
    public override int this[int n]
    {
        get
        {
            if (n % 2 == 0) return num1;
            else return num2;
        }
    }
    public int Method(int n)
    {
        return (this.num1 + this.num2) * n;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(42, 24);
        Console.WriteLine(A[2] + " " + A[1]);
        Console.WriteLine(A.Method(2));
        Console.ReadKey();
    }
}