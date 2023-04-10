using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// МЕТОДЫ
namespace Light
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
        Console.WriteLine(Sum(numbers));
    }
    static int Sum(int[] arr)
    {
        int total = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                total += arr[i];
            }
        }
        return total;
    }
}
