class Program
    {

        enum Color
        {
            black,
            white,
            red,
            yellow,
            blue,
            grey,
            brown
        }

        static void Main(string[] args)
        {
            Color[] colors = {Color.black, Color.grey, Color.blue, Color.brown, Color.white };
            PrintColor(colors);

        }

        static void PrintColor(Color[] arr)
        {

            ConsoleKey key = Console.ReadKey().Key;

            //int keyCode = (int)key;

            //Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] % 2 == 0) // четные элементы
                {
                    Console.WriteLine("Вы нажали на четную клавишу: " +(key == ConsoleKey.Y));
                }
                if ((int)arr[i] % 2 != 0) // нечетные элементы
                {
                    Console.WriteLine("Вы нажали на нечетную клавишу: " + (key == ConsoleKey.N));
                }
            }


        }

    }