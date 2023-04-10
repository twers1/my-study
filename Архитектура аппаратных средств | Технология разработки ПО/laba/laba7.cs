using System;
using System.Linq;
using System.Collections.Generic;

class Program : Student
{
    static void Main(string[] args)
    {
        Student[] arr = new Student[4];

        for (int i = 0; i < arr.Length; i++)
        {
            Student.GetStudent();
        }

        GetAdult(arr);

    }

}


// Задание 7. Классы 

class Student
{


    
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int age { get; set; }
    public string group { get; set; }

    public static Student GetStudent()
    {
        Student student = new Student();
        Console.WriteLine("Заполни информацию о студенте: ");
        Console.WriteLine("Введите имя: ");
        student.firstName = Console.ReadLine();
        Console.WriteLine("Введите фамилию: ");
        student.lastName = Console.ReadLine();
        Console.WriteLine("Введите возраст: ");
        student.age = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите группу: ");
        student.group = Console.ReadLine();
        return student;
    }

    public void Print()
    {
        Console.WriteLine($"Имя: {firstName}");
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Возраст: {age}");
        Console.WriteLine($"Группа: {group}");
    }
    public static void GetAdult(Student[] students)
    {
        for (int i = 0; i < students.Length; i++)
        {
            students.Where(student => student.age > 18);
        }
        
    }
    //public static Student GetAdult(Student[] arr)
    //{
    //    Student student = new Student();
    //    foreach (var item in arr)
    //    {
    //        if (item.age > 18)
    //            Console.WriteLine(item);
    //    }
    //    return student;
    //}
}