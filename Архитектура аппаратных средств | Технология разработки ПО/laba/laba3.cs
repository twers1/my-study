
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    internal class Program
    {

// LINQ
        static void Main(string[] args)
        {
            // Задание 1 

            //var notUniqueElements = 0;      //Счётчик не уникальных элементов
            //int[] myArray = { 0, 3, 4, 4, 5, 12, 14, 14, 121, 256, 256 };
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    for (int a = i - 1; a >= 0; a--)
            //    {
            //        if (myArray[i] == myArray[a])   //Проверяем элемент на уникальность
            //        {
            //            notUniqueElements++;     //Если такой элемент уже есть, считаем его
            //            break;                             //И переходим к следующему элементу
            //        }

            //    }

            //}

            //Console.WriteLine("Кол-во не уникальных: " + notUniqueElements);
            //int[] uniqueArray = new int[myArray.Length - notUniqueElements]; // Массив уникальных элементов
            // uniqueArray[0] = myArray[0];   //Первый элемент уже уникальный, записываем его
            //for (int i = 1, b = 1; i < myArray.Length; i++)
            //{
            //    var uniqueElement = true;   //Для проверки на уникальность
            //    for (int a = i - 1; a >= 0; a--)
            //    {
            //        if (myArray[i] == myArray[a])    //Делаем тоже самое, только для записи уникальных чисел в массив
            //        {
            //            uniqueElement = false;  //Если элемент не уникальный
            //            break;                          //Пропускаем его
            //        }
            //    }
            //    if (uniqueElement)                        //Если уникальный
            //    {
            //        uniqueArray[b] = myArray[i];    // Запись уникального элемента в массив
            //        b++; //Индекс для записи в массив уникальных чисел
            //    }
            //}
            //foreach (var el in uniqueArray)      // Вывод элементов на консоль
            //{
            //    Console.WriteLine(el);
            //}

            //Console.ReadKey();


            // Задание 2 

            int[] numbers = { 1, 2, 3, 4, 5 };
            //5  4  3  2  1
            int temp = 0;

            for (int i = 0; i < numbers.Length - i; i++)
            {
                temp = numbers[i]; // 1 2
                numbers[i] = numbers[numbers.Length - 1 - i]; // [4] [3]
                numbers[numbers.Length - 1 - i] = temp;

            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Задание 3 

            Random random = new Random();
            int[][] steirs = new int[4][];
            steirs[0] = new int[4];
            steirs[1] = new int[5];
            steirs[2] = new int[6];
            steirs[3] = new int[7];
            
            int[] steirs2 = new int[4];

            for (int i = 0; i < steirs.Length; i++)
            {
                for (int j = 0; j < steirs[i].Length; j++)
                {
                    steirs[i][j] = random.Next(1,10);
                }
            }

            Console.WriteLine("Значение массивов");

            foreach (var item in steirs)
            {
                
                foreach (var items in item)
                {
                    Console.WriteLine(items);
                }
            }

            Console.WriteLine("Наш второй цикл: ");
            for (int i = 0; i < steirs.Length; i++)
            {
                steirs2[i] = steirs[i].Max();
                
            }

            foreach (var item in steirs2)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("Максимальное значение: " + steirs2.Max());
            Console.WriteLine("Сумма элементов: " + steirs2.Sum());
        }
    }
}