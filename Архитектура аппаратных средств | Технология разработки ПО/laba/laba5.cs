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
    
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] arr = new double[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100,100);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            double n= 0;
            Console.WriteLine("Рассматриваем первый метод:");
            Nom1(out n, arr);
            Console.WriteLine(n);

            Console.WriteLine("Рассматриваем второй метод:");
            n = Convert.ToDouble(Console.ReadLine());
            Nom2(ref n, arr);
            Console.WriteLine(n);

            
        }
         static void Nom1(out double n, double[] arr)
        {
            n = 0;
            //foreach (var item in arr)
            //{
            //    if (item > 0)
            //    {
            //        n = item;
            //        return;
            //    }
            //}
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    n = i; 
                    return;
                    
                }
            }
        }

        static void Nom2(ref double n, double[] arr)
        {

            for (int i = (int)n; i < arr.Length; i++)
            {
                n += arr[i];
            }

            n /= arr.Length;
        }
    }
       
}

    

