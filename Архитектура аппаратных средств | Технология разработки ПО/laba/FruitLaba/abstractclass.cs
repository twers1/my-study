using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
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
}
