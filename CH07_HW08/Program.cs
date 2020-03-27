/*
 напишите программу, содержащую обобщенный статический метод. В качестве аргумента методу передается значение обобщенного типа.
 Методом в консольное окно выводится одно из трех разных сообщений, в зависимости от типа переданного аргумента. Отслеживаются такие случаи:
 аргументом является тип инт, чар и значение отличное от них.
 */
using System;

namespace HW08
{
    class Program
    {
        static void Show<T>(T x)
        {
            if (x is int) Console.WriteLine("INT");
            else if (x is char) Console.WriteLine("CHAR");
            else Console.WriteLine("!");
        }
        static void Main(string[] args)
        {
            Show<int>(7);
            Show<char>('7');
            Show<double>(7.7);
            Console.ReadKey();
        }
    }
}