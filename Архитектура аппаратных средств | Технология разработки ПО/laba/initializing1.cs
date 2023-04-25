using System;
using System.ComponentModel.Design.Serialization;
using System.Net.Cache;

namespace properties
{
    // Синтаксис инициализации объектов
    class Program
    {

        static void Main(string[] args)
        {
            // обычное создание экземпляра объекта класса
            // тут сначала объявлен объект, а уже потом начали работать с его полями
            Cat cat = new Cat();
            cat.Age = 3;
            cat.Name = "Барсик";
            // но чтобы облегчить данное создание, есть синтаксис инициализации объектов класса
            // мы можем инициализировать так: (в фигурных скобках и используются только те параметры, 
            // которые имеют модицикатор public

            // это называется ПОЛНАЯ инициализация объекта, вместе со всеми полями
            Cat cat2 = new Cat
            {
                Age = 3,
                Name = "Барсик"
            };

            Cat cat3 = new Cat("Барсик");
            cat3.Age = 3;

            Cat cat4 = new Cat("Барсик")
            {
                Age = 3
            };


            // в консоли будет выведено Васька 
            Cat cat5 = new Cat("Барсик")
            {
                Age = 3,
                Name = "Васька"

            };
        }

    }

    class Cat
    {
        // Инициализация объектов - это процесс создания экземпляра объекта класса
        public int Age { get; set; }
        public string Name { get; set; }
        public Cat()
        {

        }

        public Cat(string name)
        {
            Name = name;
        }
    }