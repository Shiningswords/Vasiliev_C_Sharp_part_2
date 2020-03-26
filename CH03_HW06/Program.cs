/*
 Напишите программу, в которой есть структура с двумя целочисленными полями. Опишите в структуре операторные методы для
 выполнения операций сложения, вычитания и умножения двух экземпляров структуры. Во всех случаях результатом должен
 быть новый экземпляр структуры, значения полей которого вычисляются соответственно как сумма, разность или произведение
 соответствующих полей экземпляров-операндов. Предложите два операторных метода для унарных операторов, которые возвращали бы результатом наибольшее и наименьшее
 из значений полей экземпляра структуры.
 */
using System;
struct Structure
{
    public int num1;
    public int num2;
    public Structure(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    static public Structure operator +(Structure A, Structure B)
    {
        Structure Res = new Structure((A.num1 + B.num1), (A.num2 + B.num2));
        return Res;
    }
    static public Structure operator -(Structure A, Structure B)
    {
        Structure Res = new Structure((A.num1 - B.num1), (A.num2 - B.num2));
        return Res;
    }
    static public Structure operator *(Structure A, Structure B)
    {
        Structure Res = new Structure((A.num1 * B.num1), (A.num2 * B.num2));
        return Res;
    }
    static public Structure operator --(Structure A)
    {
        Structure Res = new Structure((A.num1--), (A.num2--));
        return Res;
    }
    static public Structure operator ++(Structure A)
    {
        Structure Res = new Structure((A.num1++), (A.num2++));
        return Res;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Structure A = new Structure(2, 1);
        Structure B = new Structure(1, 2);
        Console.WriteLine(A.num1 + " " + A.num2);
        Console.WriteLine(B.num1 + " " + B.num2);
        A = A - B;
        Console.WriteLine(A.num1 + " " + A.num2);
        B = A + B;
        Console.WriteLine(B.num1 + " " + B.num2);
        A = A * B;
        Console.WriteLine(A.num1 + " " + A.num2);
        Console.ReadKey();
    }
}
