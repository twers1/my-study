using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;



// Задача Фрукты

namespace Light
{
    class Program
    {
        static void Main(string[] args)
        {
            MyJucier myJucier = new MyJucier();

            Fruit[] array = {
                new Apple(), new Banana(), new Orange(), new Apple(), new Lemon(), new Apple(), new Lemon()
            };

            myJucier.makeJuice(array);
        }

    }
}













