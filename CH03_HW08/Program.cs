/*
 напишите программу, в которой объявлены две структуры. У одной структуры есть текстовое поле, а у другой структуры есть
 символьное поле. В первой структуре (с текстовым полем) должен быть метод с целочисленным аргументом, который результатом
 возвращает экземпляр второй структуры (с символьным полем). Значение символьного поля экземпляра-результата определяется как символ из текста
 (поле экземпляра, из которого вызывается метод) с индексом, определяемым аргументом метода.
 */
using System;
struct Str1
{
    public string txt;
    public Str1(string txt)
    {
        this.txt = txt;
    }
    public Str2 Method(int n)
    {
        return new Str2(this.txt[n]);
    }
}
struct Str2
{
    public char symb;
    public Str2(char symb)
    {
        this.symb = symb;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Str1 A = new Str1("text");
        Str2 B = A.Method(2);
        Console.WriteLine(B.symb);
        Console.ReadKey();
    }
}