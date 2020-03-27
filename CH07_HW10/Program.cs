/*
 Напишите программу, в которой есть обобщенный класс с двумя обобщенными параметрами (первый и второй). У класса есть два поля,
 являющихся ссылками на массивы элементов обобщенного типа (первого и второго). Массивы имеют одинаковые размеры. Опишите индексатор, в котором
 индексом указывается значение второго обобщенного типа, а результатом индексатора является значение первого обобщенного типа.
 Предполагается, что индексом указывается одно из значений из второго массива, а считывается или присваивается значение для соответствующего элемента из первого массива.
 Предложите механизм добавления новых элементов в массивы и удаления уже существующих элементов из массивов. Операции должны выполняться так,
 чтобы количество элементов в обоих массивах было ьодинаковым.
 */
using System;

namespace HW10
{
    class MyClass<T, Y>
    {
        public T[] arr1;
        public Y[] arr2;
        public MyClass(int size)
        {
            arr1 = new T[size];
            arr2 = new Y[size];
        }
        public void Add()
        {
            arr1 = new T[arr1.Length + 1];
            arr2 = new Y[arr2.Length + 1];

        }
        public void Delete()
        {
            arr1 = new T[arr1.Length - 1];
            arr2 = new Y[arr2.Length - 1];

        }
        Random rnd = new Random();
        public T this[Y x]
        {
            get => arr1[rnd.Next(0, 5)];
            set => arr1[rnd.Next(0, 5)] = value;
        }

    }
    class Program
    {
        static void Show(MyClass<int, char> A)
        {
            for (int i = 0; i < A.arr1.Length; i++)
            {
                Console.Write(A.arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < A.arr2.Length; i++)
            {
                Console.Write(A.arr2[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            MyClass<int, char> A = new MyClass<int, char>(5);
            Show(A);
            A.Add();
            Show(A);
            A.Delete();
            Show(A);
            Console.WriteLine(A[A.arr2[0]]);
            Console.ReadKey();

        }
    }
}