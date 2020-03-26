/*
 Напишите программу, содержащую структуру с целочисленным массивом. Опишите конструктор с одним аргументом,
 определяющим размер массива. Массив должен заполняться случайными числами. В структуре должны быть методы,
 возвращающие результатом наибольший элемент в массиве, наименьший элемент в массиве, а также метод,
 возвращающий среднее значение элементов в массиве (сумма элементов массива, деленная на количество элементов в массиве).
 */
using System;
struct Structure
{
    public int[] arr;
    public Structure(int n)
    {
        this.arr = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            this.arr[i] = rnd.Next(0, 100);
        }
    }
    public int Max()
    {
        int max = arr[0];
        for (int i = 1; i < this.arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
        }
        return max;
    }
    public int Min()
    {
        int min = arr[0];
        for (int i = 1; i < this.arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
        }
        return min;
    }
    public int Middle()
    {
        int i = 0;
        for (int j = 0; j < this.arr.Length; j++)
        {
            i += arr[j];
        }
        i = i / this.arr.Length;
        return i;
    }
    public override string ToString()
    {
        string txt = "";
        for (int i = 0; i < arr.Length; i++)
        {
            txt += arr[i] + " ";
        }
        return txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Structure A = new Structure(4);
        Console.WriteLine(A);
        Console.WriteLine(A.Max());
        Console.WriteLine(A.Min());
        Console.WriteLine(A.Middle());
        Console.ReadKey();
    }
}