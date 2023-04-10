//1. Лаба 1 задача 1 вариант 1
            //for (int i = 3; i <= 60; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //вариант 2
            //for (int i = 1, a=3; i <=20; i++, a+=3)
            //{
            //    Console.WriteLine("Шаг "+i+" Значение "+a);    
            //}
            //2. Задачка 2
            //string password = "admin123";
            //string попытка;
            //do
            //{
            //    Console.WriteLine("Введите пароль: ");
            //    попытка = Console.ReadLine();
            //    if(password != попытка)
            //    Console.WriteLine("Пароль неправильный!");
            //}
            //while (password != попытка);
            //Console.WriteLine("Пароль верный!");
            //3. Задачка 3
            //int[] arr1 = { 1, 8, 4, 4, 5 };
            //int[] arr2 = { 1, 2, 3 };
            //int[] arr3 = { 1, 2, 2, 8, 9, 20, 16 };
            //int sum = 0;
            //arr3[0] = 10;
            //arr2[2] = 16;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    sum += arr1[i];
            //}

            //Console.WriteLine("Сумма= " + sum);

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    sum += arr2[i];
            //}

            //Console.WriteLine("Сумма= " + sum);

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    sum += arr3[i];
            //}
            //Console.WriteLine("Сумма= " + sum);
            //
            //int[] arr1 = { 1, 8, 4 };
            //int[] arr2 = { 1, 2, 3 };
            //int[] arr3 = { 1, 2, 2 };
            //int sum = 0;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    sum += arr1[i] + arr2[i] + arr3[i];
            //}
            //Console.WriteLine("Cумма = "+sum);
            //Задача 4
            int[,] arr = {
                {1,2,3,4 },
                {2,3,4,5 },
                {7,8,5,7 }
            };
            int sum = 0;
            // int[,] arr1 = new int[3,4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) ; j++)
                {
                    sum += arr[i, j];

                }
            }
            Console.WriteLine(sum);