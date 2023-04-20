using System;
using System.Linq;
using System.Collections.Generic;

// Задание 9. Params
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в умный калькулятор массивов");
        Console.WriteLine("При нажатии 1 на numpad - найдется вся сумма массива\nПри нажатии 2 на numpad - найдется среднее арифметическое массива\n" +
            "При нажатии 3 на numpad - найдется максимальный элемент в массиве");

        Console.WriteLine("Введите мне размер массива");
        int n = Int32.Parse(Console.ReadLine());

        int[] arr = new int[n];


        Console.WriteLine("Введите мне элементы массива ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Выберите действие(1,2,3)");


        Console.WriteLine(ArrCalc(arr));
        

    }
    static int ArrCalc(params int[] arr)
    {
        ConsoleKey key = Console.ReadKey().Key;
        int sum =0;
        int max = 0;
        int result;


        if (key == ConsoleKey.NumPad1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Сумма: " + sum);
        }


        else if(key == ConsoleKey.NumPad2)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            result = sum / arr.Length;
            Console.WriteLine("Среднее арифметическое: " + result);
        }


        /* ВТОРОЙ СПОСОБ (ЧИТАБЕЛЬНЫЙ) */
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    sum += arr[i];
        //}
        //result = sum / arr.Length;
        //if (key == ConsoleKey.NumPad2)
        //{
        //    Console.WriteLine("avg" + result);
        //}

        //if (key == ConsoleKey.NumPad1)
        //{
        //    Console.WriteLine("Сумма" + sum);

        //}

        else if(key == ConsoleKey.NumPad3)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    
                }
            }
            Console.WriteLine("Максимальное значение: " + max);

        }
        else
        {
            Console.WriteLine("Неверная операция!");
        }

        
        return ArrCalc(arr);
    }

}







