/*
 Напишите программу, в которой есть структура с двумя целочисленными полями. Предложите статический метод,
 аргументом которому передается целочисленный массив. Результатом метод возвращает экземпляр структуры,
 первое поле которого равно значению максимального (или минимального) элемента в массиве, а второе поле
 экземпляра равно индексу этого элемента в массиве.
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
}
class Program
{
    static Structure Method(int[] arr)
    {
        int min = arr[0], max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
            else if (arr[i] > max) max = arr[i];
        }
        return new Structure(max, min);
    }
    static void Main(string[] args)
    {
        int[] arr = { 2, 25, 68, 52, 1, 0, 66 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Structure A = Method(arr);
        Console.WriteLine(A.num1 + " " + A.num2);
        Console.ReadKey();

    }
}