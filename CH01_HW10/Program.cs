/*
 Напишите программу, содержащую абстрактный класс и два интерфейса. Класс должен содержать объявление абстрактного свойства (с двумя аксессорами),
 абстрактного индексатора (с двумя аксессорами) и абстрактного метода. Такое же свойство, индексатор и метод должны быть и в интерфейсах.
 На основе абстрактного класса и интерфейсов необходимо создать класс. В этом классе необходимо выполнить явную реализацию свойства, индексатора и метода для каждого из
 интерфейсов. Проверьте работу свойства, индексатора и метода, получив доступ к объекту класса через объектную переменную и через интерфейсные переменные.
 */
using System;
abstract class Base
{
    abstract public int Property { get; set; }
    abstract public int this[int n] { get; set; }
    abstract public void Method();
}
interface MyInterface1
{
    int Property { get; set; }
    int this[int n] { get; set; }
    void Method();
}
interface MyInterface2
{
    int Property { get; set; }
    int this[int n] { get; set; }
    void Method();
}
class MyClass : Base, MyInterface1, MyInterface2
{
    public override int Property { get; set; }
    public override int this[int n] { get => n; set => Property += n; }
    public override void Method() { Console.WriteLine("Общий метод"); }
    int MyInterface1.Property { get; set; }
    int MyInterface1.this[int n] { get => n + 1; set => Property += value + 1; }
    void MyInterface1.Method() { Console.WriteLine("MyInterface1"); }
    int MyInterface2.Property { get; set; }
    int MyInterface2.this[int n] { get => n + 2; set => Property += value + 2; }
    void MyInterface2.Method() { Console.WriteLine("MyInterface2"); }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        MyInterface1 I1 = A;
        MyInterface2 I2 = A;
        Console.WriteLine(A[0] + " " + I1[0] + " " + I2[0]);
        A[0] = 1;
        I1[0] = 1;
        I2[0] = 1;
        Console.WriteLine(A.Property + " " + I1.Property + " " + I2.Property);
        A.Method();
        I1.Method();
        I2.Method();
        Console.ReadKey();
    }
}