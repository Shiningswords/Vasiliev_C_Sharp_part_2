/*
 Напишите программу, в которой объявляется делегат для методов с символьным аргументом, не возвращающих результат.
 Опишите класс, в котором должно быть символьное поле и метод, позволяющий присвоить значение символьному полю объекта.
 У метода один символьный аргумент, и метод не возвращает результат. Создайте массив объектов данного класса. Создайте экземпляр делегата.
 В список вызовов этого делегата необходимо добавить ссылки на метод (присваивающий значение символьному полю) каждого объекта из массива.
 Проверьте результат вызова такого экземпляра делегата.
 */
using System;
delegate void MyDelegate(char s);
class MyClass
{
    public char s;
    public MyClass(char s) { this.s = s; }
    public void Set(char s)
    {
        this.s = s;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass[] arr = { new MyClass('a'), new MyClass('b'), new MyClass('c'), new MyClass('d') };
        MyDelegate Delegate = new MyDelegate(arr[0].Set);
        Delegate += arr[1].Set;
        Delegate += arr[2].Set;
        Delegate += arr[3].Set;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i].s + " ");
        }
        Console.WriteLine();
        Delegate('!');
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i].s + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}