using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

// Проект
class Program
{
    static void Main(string[] args)
    {
        Car car2 = new Car(130, new Engine(25.5, "Лучший двигатель"));
        car2.Print();


        Car[] cars = new Car[2];
        cars[0] = new Car(140, new Engine(15.5, "Плохой двигатель"));
        cars[1] = new Car(300, new Engine(200, "Лучший двигатель"));
        Car.getFastestCar(cars);
    }

}


// Класс двигатель 
class Engine
{
    public double power { get; set; }
    public string name { get; set; }

    public Engine(double power, string name)
    {
        this.power = power;
        this.name = name;
    }
}
// Enum для цвета машины
enum Color
{
    Black,
    White,
    Red,
    Gray,
    Blue
}

// Класс машина
class Car
{
    // Чтобы сделать так, чтобы автомобиль не мог изменить массу - надо убрать сеттер. 
    public string nameCar { get; set; }
    public int massCar { get;  }

    public Color colorCar { get; set; }
    public int speedCar { get; set; }
    public Engine engineCar { get; set; }

    public Car()
    {

    }

    public Car(int speedCar, Engine engineCar)
    {
        this.speedCar = speedCar;
        this.engineCar = engineCar;
    }

    // Метод, ищущий машину с максимальной скоростью
    public static Car getFastestCar(Car[] array)
    {
        //Console.WriteLine("Введите какое количество машин будет в вашем массиве: ");
        //int n = Convert.ToInt32(Console.ReadLine());

        Car car = new Car();
        int maxSpeed = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i].speedCar > maxSpeed)
            {
                maxSpeed = array[i].speedCar;
            }
        }
        
        return car;
        

    }

    // Метод, который выводит всю информацию о машине
    public void Print()
    {
        Console.WriteLine("Бренд машины" + nameCar);
        Console.WriteLine("Текущая скорость: "+ speedCar);
        Console.WriteLine("Цвет: "+colorCar);
        Console.WriteLine("Мощность двигателя: "+engineCar);
    }


}











