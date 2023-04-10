using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    static void Main(string[] args)
    {
        // Лабораторная работа 2(задание 1)

        int[] mass = new int[5];
        int min = mass[0];
        int max = mass[9];
        int sum = 0;

        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] < min)
            {
                min = mass[i];
            }
            if (mass[i] > max)
            {
                max = mass[i];
            }
            sum += mass[i];
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
        }
        // Задание 2 
        Random rand = new Random();
            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());

            int[,] array2 = new int[n,m];

            Console.WriteLine("Введи мне произвольный размер двумерного массива");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array2[i, j] = rand.Next(0, 10);
                }
            }
            Console.WriteLine("Вывод таблицы: ");
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine();
                for (int j = 0; j<5; j++ )
                {
                    Console.WriteLine("{0}\t", array2[i,j]);
                }
            }

        // Задание 3

        int n = Int32.Parse(Console.ReadLine());
        int m = Int32.Parse(Console.ReadLine());

        int[,] arr2 = new int[n, m];

        // Задание 3
        int[] arr3 = new int[10];
        Console.WriteLine("Введите мне произвольный размер массива(10 чисел)");

        for (int i = 0; i < arr3.Length; i++)
        {
            arr3[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr3[i];
        }

        int print = sum / arr3.Length;

        // Задание 4

        // Пузырьковая сортировка

        int[] numbers = { 28, 36, 64, 1911, 57, 18, 109 };
        int temp;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length-1-i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;

                }
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Сортировка методом выбора

        int[] numbers2 = { 6, 4, 10, 21, 15, 7, 8, -10, -5, 0 };
        int temp2;
        int min2;

        for (int i = 0; i < numbers2.Length; i++)
        {
            min2 = i;
            for (int j = 0; j < numbers2.Length; j++)
            {
                if (numbers2[j] < numbers2[min])
                {
                    min2 = j;
                }
            }

            temp2 = numbers2[i];
            numbers[min] = numbers[i];
            numbers2[i] = temp2;
        }

        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.WriteLine(numbers2[i]);
        }
    }
}
