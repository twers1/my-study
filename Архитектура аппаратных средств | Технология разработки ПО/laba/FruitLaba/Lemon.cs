using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
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
            if (name == GetType().Name)
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
}
