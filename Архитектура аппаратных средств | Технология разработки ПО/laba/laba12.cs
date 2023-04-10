using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Light
{
    // для структурных типов данных подойдет больше ключевое слово ref, так как он значимый тип данных, а не ссылочный
    class Program
    {
        static void Main(string[] args)
        {
            // Лабораторная работа 12 
            // Задание 1 

            string s = "Tesla - это такая себе машина, конечно. Tesla — американская компания. Bitcoin - какая-то монета, а tesla - какая-то машина. Bitcoin больше доллара";
            s = s.Replace("Bitcoin", "Tesla");
            Console.WriteLine("Ответ на первое задание:");
            Console.WriteLine(s);

            // Задание 2 

            string s2 = "Видеокарта – компонент архитектуры современного ПК,\r\nотвечает за преобразование графической информации в видеосигнал\r\nдля монитора. Видеокарта представляет собой плату расширения,\r\nкоторая устанавливается в специальный слот (PCI-Express)\r\nматеринской платы/";
            s2 = s2.Substring(1, s2.Length - 19);
            s2 = s2.Substring(206);
            Console.WriteLine("Ответ на второе задание:");
            Console.WriteLine(s2);

            // Задание 3 

            string s3 = "MoiSeev, ToMatin, RogAchev, lvaNov";
            string[] array = s3.Split();
            Console.WriteLine("Ответ на третье задание:");
            Console.WriteLine(s3.ToLower());
            

            // Задание 4 

            string s4 = "C# Лучший язык программирования";
            string s5 = "но С++ тоже крутой язык программирования";
            Console.WriteLine("Ответ на четвертое задание:");
            Console.WriteLine(s4+ ", " + s5);
        }
        
    }
       
}

    
