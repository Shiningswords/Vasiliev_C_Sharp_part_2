/*
 Напишите программу, в которой объявляется делегат для методов с двумя аргументами (символ и текст) и целочисленным результатом.
 В главном классе необходимо описать два статических метода. Один статический метод результатом возвращает количество вхождений символа (первый аргумент)
 в текстовую строку (второй аргумент). Другой метод результатом возвращает индекс первого вхождения символа (первый аргумент) в текстовую строку (второй аргумент)
 или значение -1, если символ в текстовой строке не встречается. В главном методе создать экземпляр делегата и с помощью этого экземпляра вызвать каждый из
 статических методов.
 */
using System;
delegate int MyDelegate(char symb, string txt);

class Program
{
    static int Count(char s, string txt)
    {
        int res = 0;
        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] == s) res++;
        }
        return res;
    }
    static int First(char s, string txt)
    {
        int res = -1;
        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] == s)
            {
                res = i + 1;
                break;
            }
        }
        return res;
    }

    static void Main(string[] args)
    {
        char s = 'b';
        string txt = "aaabababbab";
        MyDelegate Delegate = new MyDelegate(Count);
        Console.WriteLine($"Строка {txt}, Символ {s}, Count = {Delegate(s, txt)}");
        Delegate = First;
        Console.WriteLine($"Строка {txt}, Символ {s}, First = {Delegate(s, txt)}");
        Console.ReadKey();
    }
}
