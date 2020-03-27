/*
 Напишите программу, в которой есть статический обобщенный метод. Метод не возвращает результат, а аргументом методу
 передается массив с элементами обобщенного типа. При вызове метода выполняется циклическая перестановка элементов массива:
 первый элемент становится вторым, второй элемент третьим, и такдалее, а последний элемент становится первым.
 */
using System;

namespace HW02
{
    class Program
    {
        static public void Method<T>(T[] arr)
        {
            T temp = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = temp;
        }
        static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" | " + arr[i]);
            }
            Console.WriteLine("|");
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Show(arr);
            Method<int>(arr);
            Show(arr);
            Console.ReadKey();
        }
    }
}