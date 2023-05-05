using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    // Интерфейс Jucier
    public interface Jucier
    {
        void makeJuice(Fruit[] array);

    }

    public interface Fruit
    {
        string getName();
        string getColor();
        bool isCitrus();
    }
}
