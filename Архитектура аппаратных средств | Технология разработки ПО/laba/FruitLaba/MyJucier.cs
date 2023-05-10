using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Light
{
    class MyJucier : Jucier
    {
        public void makeJuice(Fruit[] array) 
        {
            Console.WriteLine("Начинаю делать сок");
            Thread.Sleep(1000);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }

            if (array.Length == 0)
            {
                throw new JucierException();
            }


            int countFruitCitrus = 0;
            int countFruitNotCitrus = 0;
            foreach (var item in array)
            {
                // item.ToString();
                if (item.isCitrus())
                {
                    countFruitCitrus++;
                }
                else
                {
                    countFruitNotCitrus++;
                }
            }
            Console.WriteLine("Количество цитрусов: " + countFruitCitrus);
            Console.WriteLine("Количество не цитрусов: " + countFruitNotCitrus);

            int countApples = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].getName() == "Apple")
                {
                    countApples++;
                }
            }
            Console.WriteLine("Количество яблок: " + countApples);

           
            
            


        }
    }
}
