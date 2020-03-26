/*
 Напишите программу, в которой есть структура с символьным полем. Также в программе должен быть статический метод,
 аргументом которому передается текстовое значение. Результатом метод возвращает массив из экземпляров структуры.
 Размер массива определяется длиной текста. Значения символьных полей экземпляров структуры в массиве задаются
 символами из текста. Предложите метод, которому в качестве аргумента передается массив из экземпляров структуры,
 а результатом метод возвращает текстовую строку, составляющую из символьных значений полей экземпляров в массиве.
 */
using System;
struct Structure
{
    public char symb;
    public Structure(char symb)
    {
        this.symb = symb;
    }
    public static Structure[] Method(string txt)
    {
        Structure[] arr = new Structure[txt.Length];
        for (int i = 0; i < txt.Length; i++)
        {
            arr[i] = new Structure(txt[i]);
        }
        return arr;
    }
    public static string Show(Structure[] arr)
    {
        string txt = "";
        for (int i = 0; i < arr.Length; i++)
        {
            txt += arr[i].symb + " ";
        }
        return txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Structure[] arr = Structure.Method("yoyyoyoyoyo");
        Console.WriteLine(Structure.Show(arr));
        Console.ReadKey();
    }
}