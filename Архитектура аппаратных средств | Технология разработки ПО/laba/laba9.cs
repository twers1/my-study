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
        Console.WriteLine("Нажми на клавиши 1, 2, 3");

        
        Console.WriteLine(ArrCalc(arr));
        

    }
    static int ArrCalc(params int[] parametres)
    {
        ConsoleKey key = Console.ReadKey().Key;
        int sum = 0;
        int max = 0;

        if (key == ConsoleKey.NumPad1)
        {
            for (int i = 0; i < parametres.Length; i++)
            {
                sum += parametres[i];
                return sum;
            }
            
        }


        if (key == ConsoleKey.NumPad2)
        {
            for (int i = 0; i < parametres.Length; i++)
            {
                sum += parametres[i];
                return sum / parametres.Length;
            }
            
        }
        if (key == ConsoleKey.NumPad3)
        {
            for (int i = 0; i < parametres.Length; i++)
            {
                if (parametres[i] > max)
                {
                    max = parametres[i];
                    return max;
                }
            }
            
        }
        else
        {
            Console.WriteLine("Неверная операция");
        }
        return ArrCalc();
    }

}







