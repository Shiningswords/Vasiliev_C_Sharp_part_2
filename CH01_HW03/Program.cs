/*
 Напишите программу, в которой будет описан интерфейс с методом без аргументов, который возвращает результатом целое число.
 На основе интерфейса создайте 2 класса. У каждого класса должно быть целочисленное поле. В первом классе метод результатом возвращает сумму
 сумму четных чисел, во втором классе метод возвращает результатом сумму нечетных чисел. Количество слогаемых в сумме определяется полем объекта,
 из которого вызван метод. Проверьте работу метода, получив доступ к объекту класса через объектную переменную и через интерфейсную переменную.
 */
using System;
interface MyInterface
{
    int Num();
}
class MyClass1 : MyInterface
{
    private int size;
    public MyClass1(int size)
    {
        this.size = size;
    }
    public int Num()
    {
        int count = this.size;
        int n = 0;
        int res = 0;
        while (true)
        {
            if (n % 2 == 0)
            {
                res += n;
                count--;
                if (count < 0) break;
            }
            n++;
        }
        return res;
    }
}
class MyClass2 : MyInterface
{
    private int size;
    public MyClass2(int size)
    {
        this.size = size;
    }
    public int Num()
    {
        int count = this.size;
        int n = 0;
        int res = 0;
        while (true)
        {
            if (n % 2 != 0)
            {
                res += n;
                count--;
                if (count <= 0) break;
            }
            n++;
        }
        return res;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass1 A = new MyClass1(5);
        MyInterface B = A;
        Console.WriteLine(A.Num());
        Console.WriteLine(B.Num());

        MyClass2 C = new MyClass2(5);
        MyInterface D = C;
        Console.WriteLine(C.Num());
        Console.WriteLine(D.Num());

        Console.ReadKey();
    }
}