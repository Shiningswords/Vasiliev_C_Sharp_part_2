﻿/*
 Напишите программу, в которой объявлен делегат, предназначенный для работы с методами, не имеющими аргумента и возвращающими символьный результат.
 Опишите класс, у которого есть текстовое поле, а также закрытое поле, являющееся ссылкой на экземпляр делегата.
 В классе нужно описать открытое свойство, доступное только для чтения. Значением свойства является значение закрытого поля (т.е. ссылка на экземпляр делегата)
 Опишите конструктор класса с двумя аргументами: текстовым и логическим. Первый текстовый аргумент определяет значение текстового поля объекта, а второй логический
 аргумент определяет значение закрытого поля типа делегата. Если второй аргумент истинный, то закрытому полю значением присваивается анонимный метод (или лямбда выражение),
 возвращающий результатом первый символ из текстового поля. Если логический аргумент ложный, то закрытому полю значением присваивается анонимный метод (или лямбда выражение),
 возвращаюий результатом последний символ из текстового поля. Создайте объекты класса и проверьте функциональность свойства: его можно вызывать как метод, без аргументов,
 а результатом является первый или последний символ в текстовом поле (в зависимости от того, с каким логическим аргументом создавался объект).
 */
using System;
delegate char MyDelegate();
class MyClass
{
    string txt;
    private MyDelegate Delegate;
    public MyClass(string txt, bool flag)
    {
        this.txt = txt;
        if (flag)
        {
            Delegate = () => this.txt[0];
        }
        else
        {
            Delegate = () => this.txt[this.txt.Length - 1];
        }
    }
    public char prop
    {
        get
        {
            return Delegate();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass("first", true);
        MyClass B = new MyClass("second", false);
        Console.WriteLine(A.prop);
        Console.WriteLine(B.prop);
        Console.ReadKey();
    }
}