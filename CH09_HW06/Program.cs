/*
 Напишите программу, в которой считывается содержимое текстового файла и создается новый текстовый файл.
 В новый текстовый файл заносится текст из исходного текстового файла, но все пробелы заменяются подчеркиваниями,
 а заглавные буквы заменяются строчными.
 */
using System;
using System.IO;
using System.Text;

namespace HW06
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("first.txt");
                StringBuilder str = new StringBuilder(sr.ReadToEnd());
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ') str[i] = '_';
                    if (str[i].ToString().ToUpper() == str[i].ToString()) str[i] = str[i].ToString().ToLower().ToCharArray()[0];
                }
                StreamWriter sw = new StreamWriter("second.txt");
                sw.WriteLine(str.ToString());
                sw.Close();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Конец программы.");
            Console.ReadKey();
        }
    }
}