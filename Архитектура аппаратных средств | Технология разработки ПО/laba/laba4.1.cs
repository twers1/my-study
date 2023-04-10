using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    class Program
    {
        // 1 Задание && 2 Задание
        /*static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[10];
            int[] i = Class.GeArray(array);
            Console.WriteLine(Class.Method(i));
            foreach (var item in i)
            {
                Console.WriteLine("Элементики: " + item);
            }
        }*/
        //static void Main(string[] args)
        //{
        //    Random rand = new Random();
        //    int[] array = new int[10];
        //    int[] i = Class.GeArray(array);
        //    Console.WriteLine(Class.Method(i, 7));
        //    foreach (var item in i)
        //    {
        //        Console.WriteLine("Элементики: " + item);
        //    }
        //}

        static void Main(string[] args)
        {
            int[] i = Class.Method(10, 12, 23, 1, 4, 5, -500);
            Class.SomethingMethod(i);

        }

        class Class
        {

            public static int Method1(int[] arr)
            {
                int a = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    a += arr[i];
                }
                return a / arr.Length;
            }
            public static int[] Method(int[] arr, int остановка_индекса)
            {
                int avg = 0;
                int avg1 = 0;
                for (int i = 0; i < остановка_индекса; i++)
                {
                    avg += arr[i];
                }
                int[] a = new int[2];
                a[0] = avg / остановка_индекса;
                for (int j = остановка_индекса; j < arr.Length; j++)
                {
                    avg1 += arr[j];
                }
                a[1] = avg1 / (arr.Length - остановка_индекса);
                return a;
            }
            public static int[] Method(params int[] numbers)
            {
                int temp;

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers.Length - 1 - i; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }

                    }
                }
                return numbers;
            }
            public static int[] GeArray(int[] array)
            {
                Random rand = new Random();
                int[] arr = array;
                for (int i = 0; i < array.Length; i++)
                {
                    arr[i] = rand.Next(0, 100);
                }
                return arr;

            }
            public static void SomethingMethod(int[] i)
            {
                foreach (var item in i)
                {
                    Console.WriteLine("Элементики: " + item);
                }
            }
        }
    }
}