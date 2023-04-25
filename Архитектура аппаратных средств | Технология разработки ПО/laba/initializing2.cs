using System;
using System.ComponentModel.Design.Serialization;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Runtime;

namespace properties
{
    // Синтаксис инициализации объектов
    class Program
    {

        static void Main(string[] args)
        {
            // Обычное создание объекта класса
            Person person = new Person();
            person.FirstName = "dads";
            person.LastName = "asdda";

            Address address = new Address();
            address.Country = "dasda";
            address.City = "sadad";
            address.Region = "dadas";

            person.Address = address;

            // Инициализация объекта класса
            Person person2 = new Person
            {
                FirstName = "Xxa",
                LastName = "Xd",
                Address = new Address
                {
                    Country = "Вв",
                    Region = "A",
                    City = "da"
                }
            };


            Person person3 = new Person("xa", "xa")
            {
                Address = new Address
                {
                    Country = "Вв",
                    Region = "A",
                    City = "da"
                }
            };
        }

    }

    class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
    }