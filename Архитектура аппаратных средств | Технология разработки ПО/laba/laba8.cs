using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Box box = new Box(1,1,3);
        box.SetLength(1);
        int l = box.GetLength();

        Box box2 = new Box(2,2,3);
        box2.Width= 2;
        int w = box2.Width;

        Box box3 = new Box(3,3,3);
        box3.Height= 2;
        int h = box3.Height;


    }

}


// Задание 8. Свойства (Properties)

class Box
{
    // ctor + 2tab. Создание конструктора класса Box
    public Box(int l, int w, int h)
    {
        this.l = l;
        this.w = w;
        Height = h;
    }

    // Первый способ создания свойства класса(поля)
    private int l;

    public void SetLength(int l)
    { 
        this.l = l;
    }
    public int GetLength() 
    {
        return l;
    }

    // Второй способ создания свойства класса(поля) width. Propfull + 2tab

    private int w;

    public int Width
    {
        get
        { 
            return w; 
        }
        set
        { 
            w = value; 
        }
    }

    // Третий способ создания свойства класса(поля) height. Prop + 2tab. Получается автоматическое свойство
    public int Height { get; set; }

    // Метод для создания объема коробки

    public int Volume()
    {
        return l * w * Height;
    }


}