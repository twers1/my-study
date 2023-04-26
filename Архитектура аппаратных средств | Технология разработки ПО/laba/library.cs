using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;

// Лабораторная работа Библиотека
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Проверка первого метода: ");
        Console.WriteLine("Введите количество элементов в массиве: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Ваш ответ на первое задание: ");
        Library.Increasing(arr);


        Console.WriteLine("Проверка второго метода: ");
        Console.WriteLine("Введите число, факториал которого нужно найти");
        int m = Convert.ToInt32(Console.ReadLine());
        Library.Factorial(m);


        Console.WriteLine("Проверка третьего метода: ");
        Console.WriteLine("Введите количество элементов в массиве: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n1];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Library.Mass(arr1);




    }

}


class Library
{
    // Метод, сортирующий массив в порядке возрастания
    public static void Increasing(int[] math)
    {
        for (int i = 0; i < math.Length; i++)
        {
            for (int j = 0; j < math.Length - 1; j++)
            {
                if (math[j] > math[j + 1])
                {
                    int temp = math[j];
                    math[j] = math[j + 1];
                    math[j + 1] = temp;
                }
            }
        }
        foreach (var item in math)
        {
            Console.WriteLine(item);
        }
    }

    // Метод, который считает факториал введенного числа
    public static void Factorial(int n)
    {
        int fact = n;
        long n2 = 1;
        if(fact == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                n2 *= i;
            }
            Console.WriteLine(n2);
        }
    }

    // Метод, который будет выполнять следующее: Если сумма
    // четных элементов массива больше, чем сумма нечетных, то нужно
    // вывести результат суммы первого и последнего элемента массива,
    // если наоборот – то их разность.

    public static void Mass(int[] array)
    {
        int chet = 0;
        int nechet = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2==0)
            {
                chet+= array[i];
            }
        }
        // Console.WriteLine("Сумма четных элементов равна = " + chet);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 !=0)
            {
                nechet+= array[i];
            }
        }
        // Console.WriteLine("Сумма нечетных элементов равна = " + nechet);

        Console.WriteLine("Проверяю условие сумма четных > сумма нечетных");
        if(chet > nechet)
        {
            Console.WriteLine("Ответ(первое условие): "+(array[0]+array.Length-1));
        }
        else
        {
            Console.WriteLine("Ответ(второе условие): "+(array[0]-array.Length-1));
        }
    }
}








