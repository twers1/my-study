using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Threading;

// Задача Фрукты
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

// Интерфейс Jucier

interface Jucier
{
    void makeJuice(Fruit[] array);
    
}

public interface Fruit
{
    string getName();
    string getColor();
    bool isCitrus();
}

class JucierException : Exception
{
    
}
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

        
        int countFruitCitrus = 0;
        foreach  (var item in array)
        {
           // item.ToString();
            if (item.isCitrus())
            {
                countFruitCitrus++;
            }
        }
        Console.WriteLine("Количество цитрусов: " + countFruitCitrus);

        int countApples = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].getName() == "Apple")
            {
                countApples++;
            }
        }
        Console.WriteLine("Количество яблок: "+countApples);


    }
}

abstract class Citrus 
{
    bool isCitrus()
    {
        return true;
        
    }
}

abstract class NonCitrus
{
    bool isCitrus()
    {
        return false;
    }
}

class Lemon : Citrus, Fruit
{
    public Lemon()
    {

    }

    public string name { get; } = "Lemon";
    public string color { get; } = "Yellow";

    public string getName()
    {
        return name;
    }

    public string getColor()
    {
        return color;
    }
    public bool isCitrus()
    {
        if (name == "Lemon" || name == "Orange")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string ToString()
    {
        return "Название фрукта: " + name + " " +  "Цвет фрукта: " +color;
    }
}

class Orange : Citrus, Fruit
{
    public Orange()
    {

    }
    public string name { get; } = "Orange";
    public string color { get; } = "Yellow";

    public string getName()
    {
        return name;
    }

    public string getColor()
    {
        return color;
    }
    public bool isCitrus()
    {
        if (name == "Lemon" || name == "Orange")
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public override string ToString()
    {
        return "Название фрукта: " + name + " " + "Цвет фрукта: " + color;
    }
}

class Banana : NonCitrus, Fruit
{
    public Banana()
    {

    }

    public string name { get; } = "Banana";
    public string color { get; } = "Yellow";

    public string getName()
    {
        return name;
    }

    public string getColor()
    {
        return color;
    }
    public bool isCitrus()
    {
        if (name == "Lemon" || name == "Orange")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string ToString()
    {
        return "Название фрукта: " + name + " " + "Цвет фрукта: " + color;
    }
}

class Apple : NonCitrus, Fruit
{
    public Apple()
    {

    }

    public string name { get; } = "Apple";

    public string color { get; } = "Green";

    public string getName()
    {
        return name;
    }

    public bool isCitrus()
    {
        if (name == "Lemon" || name == "Orange")
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public string getColor()
    {
        return color;
    }

    public override string ToString()
    {
        return "Название фрукта: " + name + " " + "Цвет фрукта: " + color;
    }


}













