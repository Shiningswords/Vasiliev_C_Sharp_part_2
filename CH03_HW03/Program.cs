/*
 напишите программу, содержащую структуру с полем, которое является символьным массивом. Предложите две версии конструктора:
 с текстовым аргументом (символьный массив формируется на основе текста) и с двумя аргументами (целое число и символ).
 В последнем случае целочисленный аргумент определяет размер массива, а символьный аргумент определяет значение, которое 
 присваивается всем элементам массива. Опишите в структуре индексатор, который позволял бы считывать значение символа из массива
 и присваивать значение элементу массива. Предложите метод, который при вызове менял бы порядок символов в массиве на противоположный.
 Переопределите метод ToString() таким образом, чтобы он возвращал текстовую строку, содержащую символы из массива и числовые коды этих символов.
 */
using System;
struct Structure
{
    public char[] arr;
    public Structure(string txt)
    {
        this.arr = new char[txt.Length];
        for (int i = 0; i < txt.Length; i++)
        {
            this.arr[i] = txt[i];
        }
    }
    public Structure(int num, char symb)
    {
        this.arr = new char[num];
        for (int i = 0; i < arr.Length; i++)
        {
            this.arr[i] = symb;
        }
    }
    public char this[int n]
    {
        get
        {
            return this.arr[n];
        }
        set
        {
            this.arr[n] = value;
        }
    }
    public void Reverse()
    {
        char[] tmp = new char[arr.Length];
        for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
        {
            tmp[j] = arr[i];
        }
        this.arr = tmp;
    }
    public override string ToString()
    {
        string tmp = "";
        for (int i = 0; i < this.arr.Length; i++)
        {
            tmp += arr[i] + " = " + (int)arr[i] + "|";
        }
        return tmp;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Structure A = new Structure("text!");
        Structure B = new Structure(4, 'b');
        Console.WriteLine(A);
        A.Reverse();
        Console.WriteLine(A);
        Console.WriteLine(B[2]);
        B[2] = '!';
        Console.WriteLine(B[2]);
        Console.ReadKey();
    }
}