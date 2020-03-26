/*
 напишите программу, в которой объявляется структура с целочисленным, текстовым и символьным полями. Предложите такие версии конструктора:
 с тремя аргументами (целое число, текст, символ), с двумя аргументами (целое число, текст) и с одним аргументом (текст).
 В структуре должен быть метод, при вызове которого отображаются значения полей экземпляра структуры.
 */
using System;
struct Structure
{
    public int num;
    public string txt;
    public char symb;

    public Structure(int num, string txt, char symb)
    {
        this.num = num;
        this.txt = txt;
        this.symb = symb;
    }
    public Structure(int num, string txt)
    {
        this.num = num;
        this.txt = txt;
        this.symb = ' ';
    }
    public Structure(string txt)
    {
        this.num = 0;
        this.txt = txt;
        this.symb = ' ';
    }
    public override string ToString()
    {
        return num + " " + txt + " " + symb;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Structure A = new Structure(4, "gherg", 'f');
        Structure B = new Structure(5, "hergheg");
        Structure C = new Structure("hrgegas");
        Structure D = new Structure();
        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);
        Console.WriteLine(D);
        Console.ReadKey();
    }
}