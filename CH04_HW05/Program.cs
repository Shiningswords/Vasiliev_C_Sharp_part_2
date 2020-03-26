/*
 Напишите программу, содержащую структуру с символьным и целочисленным полями, а также метод, который при вызове
 отображает значения этих полей. Создайте указатель на экземпляр структуры и с помощью этого указателя присвойте
 значения полям экземпляра структуры и вызовите метод из экземпляра.
 */
using System;
struct Structure
{
    public int num;
    public char symb;
    public void Show()
    {
        Console.WriteLine(num + " " + symb);
    }
}
class Program
{
    unsafe static void Main(string[] args)
    {
        Structure A = new Structure();
        Structure* pnt = &A;
        pnt->num = 1;
        pnt->symb = 'A';
        pnt->Show();
        Console.ReadKey();
    }
}