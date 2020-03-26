/*
 Напишите программу, в которой класс создается на основе двух интерфейсов. В первом интерфейсе есть целочисленное свойство,
 доступное для чтения и записи. Во втором индексаторе есть текстовое свойство, доступное для чтения и записи. В каждом из
 интерфейсов объявлены одинаковые (с одинаковыми именами) методы , без аргументов, не возвращающие результат.
 В классе описать соответствующий метод, который в консольном окне отображает значения свойств.
 */
using System;
interface MyInterface1
{
    int Num { get; set; }
    void Method();

}
interface MyInterface2
{
    string Txt { get; set; }
    void Method();
}
class MyClass : MyInterface1, MyInterface2
{
    public MyClass(int num, string txt)
    {
        this.Num = num;
        this.Txt = txt;
    }
    public int Num { get; set; }
    public string Txt { get; set; }
    public void Method()
    {
        Console.WriteLine($"{this.Num} |||| {this.Txt}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(42, "Hi!");
        A.Method();
        MyInterface1 B = A;
        B.Method();
        Console.ReadKey();
    }
}