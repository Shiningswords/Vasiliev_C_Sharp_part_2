/*
 Напишите программу, в которой объявлены две структуры. У первой структуры есть целочисленное поле, а у второй структуры есть два целочисленных поля.
 Предложите операторный метод, с помощью которого сумма двух экземпляров первой структуры возвращала бы результатом экземпляр второй структуры
 (поля экземпляра-результата - это поля суммируемых экземпляров). Во второй структуре опишите метод, который результатом возвращает массив из двух
 экземпляров первой структуры. В этом случае экземпляр с двумя полями, из которого вызывается метод, "разбивается" на два экземпляра, у каждого из которых по одному полю.
 */
using System;
struct Str1
{
    public int num;
    public Str1(int num)
    {
        this.num = num;
    }
    static public Str2 operator +(Str1 A, Str1 B)
    {
        return new Str2(A.num, B.num);
    }
}
struct Str2
{
    public int num1;
    public int num2;
    public Str2(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    public Str1[] Method()
    {
        Str1[] arr = { new Str1(this.num1), new Str1(this.num2) };
        return arr;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Str2 A = new Str1(1) + new Str1(2);
        Console.WriteLine(A.num1 + " " + A.num2);
        Str1[] arr = A.Method();
        Console.WriteLine(arr[0].num + " " + arr[1].num);
        Console.ReadKey();
    }
}