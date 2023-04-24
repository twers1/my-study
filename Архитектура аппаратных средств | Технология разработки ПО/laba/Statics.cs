using System;
using System.Linq;
using System.Collections.Generic;

// Задание Статика
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Иванов","Иван");
        Student student2 = new Student("Иванов", "Петр");
        Student student3 = new Student("Иванов", "Захар");
        Student.group = 701;
        student1.Print();
        student2.GetGroup();

    }

}


class Student
{
    // Создание полей
    public string firstName;
    public string lastName;
    public static int group;


    // Создание конструктора для полей firstName и lastName
    public Student(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // Создание статического свойства 
    public static int Group
    {
        get { return group; }
        set { group = value; }
    }

    // Создание нестатического метода, который возвращает значение поля группа
    public int GetGroup()
    {
        return group;
    }

    // Создание нестатического метода, который выводит информацию о студенте
    public void Print()
    {
        Console.WriteLine("Имя: " +firstName);
        Console.WriteLine("Фамилия: " +lastName);
        Console.WriteLine("Группа: " + group);
    }



}








