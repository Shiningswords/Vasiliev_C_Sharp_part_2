/*
 Напишите программу, в которой описывается класс с тремя полями (целое число, символ и текст). Создайте объект этого класса,
 прочитав  значения для его полей из бинарного файла. Файл предварительно создается программой.
 */
using System;
using System.IO;

namespace HW07
{
    class MyClass
    {
        public int num;
        public char symb;
        public string txt;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = 123;
            char symb = 'A';
            string txt = "Hello, World!";
            string file = "MyData.dat";
            MyClass A = new MyClass();
            Console.WriteLine("Запись данных в файл...");
            try
            {
                BinaryWriter bw = new BinaryWriter(new FileStream(file, FileMode.Create));
                bw.Write(num);
                bw.Write(symb);
                bw.Write(txt);
                bw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка записи в файл!");
                Console.WriteLine(e.Message);
                return;
            }
            try
            {
                BinaryReader br = new BinaryReader(new FileStream(file, FileMode.Open));
                A.num = br.ReadInt32();
                A.symb = br.ReadChar();
                A.txt = br.ReadString();
                br.Close();
                Console.WriteLine($"{A.num} {A.symb} {A.txt}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка записи в файл!");
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}