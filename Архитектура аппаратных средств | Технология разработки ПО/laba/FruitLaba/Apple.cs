using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
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
            if (name != GetType().Name)
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
}
