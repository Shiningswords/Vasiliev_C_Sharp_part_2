/*
 напишите программу, в которой создается текстовый объект, а потом с помощью указателей непосредственно в этом объекте
 выполняется инверсия текста: порядок символов заменяется на противоположный.
 */
using System;
class Program
{
    unsafe static void Main(string[] args)
    {
        String txt = "Пограмируем";
        Console.WriteLine(txt);
        fixed (char* pnt = txt)
        {
            char[] tmp = txt.ToCharArray();
            for (int i = txt.Length - 1, j = 0; i >= 0 || j < txt.Length; i--, j++)
            {
                pnt[i] = tmp[j];
            }
            Console.WriteLine(txt);
            Console.ReadKey();
        }
    }
}