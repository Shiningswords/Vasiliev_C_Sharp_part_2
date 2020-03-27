/*
 Напишите программу, содержащую статический метод, не возвращающий результат. Аргументом методу передается целое число.
 Если число четное, то метод генерирует исключение класса ArithmeticException, а если число нечетное, то генерируется
 исключение класса OverflowException. В главном методе выполняется оператор цикла, в котором за каждый цикл пользователь вводит целое число,
 оно передается аргументом методу. Организовать обработку событий таким образом, чтобы в результате появлялось сообщение о том,
 четное число или нечетное. оператор цикла должен завершать работу, если пользователь вводит не число.
 */
using System;

namespace HW06
{
    class Program
    {
        static void Method(int num)
        {
            try
            {
                if (num % 2 == 0) throw new ArithmeticException();
                else throw new OverflowException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Method(Int32.Parse(Console.ReadLine()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}