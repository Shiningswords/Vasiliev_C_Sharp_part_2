/*
 Напишите программу, содержащую структуру с тремя закрытыми целочисленными полями. Предложите версии конструктора с одним,
 двумя и тремя целочисленными аргументами. В структуре должно быть два целочисленных свойства. Одно свойство результатом
 возвращает наименьшее из значений полей экземпляра структуры. Другое свойство возвращает наибольшее из значений
 полей экземпляра структуры. Предложите вариант обработки ситуации, когда первому или второму свойству присваивается значение.
 */
using System;
struct Structure
{
    private int num1;
    private int num2;
    private int num3;
    public Structure(int n1)
    {
        num1 = n1;
        num2 = 0;
        num3 = 0;
    }
    public Structure(int n1, int n2)
    {
        num1 = n1;
        num2 = n2;
        num3 = 0;
    }
    public Structure(int n1, int n2, int n3)
    {
        num1 = n1;
        num2 = n2;
        num3 = n3;
    }
    public int Min
    {
        get
        {
            int res = num1;
            if (num2 < num1 && num2 < num3) res = num2;
            else if (num3 < num1 && num3 < num2) res = num3;
            return res;
        }
        set
        {
            num1 = value;
            num2 = value;
            num3 = value;
        }
    }
    public int Max
    {
        get
        {
            int res = num1;
            if (num2 > num1 && num2 > num3) res = num2;
            else if (num3 > num1 && num3 > num2) res = num3;
            return res;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Structure A = new Structure(1, 2, 3);
        Console.WriteLine(A.Max);
        Console.WriteLine(A.Min);
        A.Min = 4;
        Console.WriteLine(A.Max);
        Console.WriteLine(A.Min);
        Console.ReadKey();
    }
}