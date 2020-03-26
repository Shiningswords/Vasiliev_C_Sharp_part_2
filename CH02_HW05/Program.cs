/*
 Напишите программу, в которой с помощью делегатов и анонимных методов (лямбда-выражений) создается экземпляр делегата,
 который вызывается без аргументов, а результатом возвращает число из последовательности Фибоначчи - при каждом новом вызове 
 получаем новое число в последовательности. В последовательности Фибоначчи первые два числа равны единице, а каждое следующее
 число равно сумме двух предыдущих.
 */
using System;
delegate int MyDelegate();
class Program
{
    static int num1 = 1;
    static int num2 = 1;
    static int count = 0;
    static void Main(string[] args)
    {
        MyDelegate Fib = () =>
        {
            int temp = num1 + num2;
            if (count < 2)
            {
                count++;
                return 1;
            }
            else
            {
                num2 = num1;
                num1 = temp;
                return num1;
            }
        };
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine(Fib());
        }
        Console.ReadKey();
    }
}