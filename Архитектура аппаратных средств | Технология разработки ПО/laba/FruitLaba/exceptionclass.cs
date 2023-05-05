using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light
{
    class JucierException : Exception
    {
        public JucierException() : base("Фруктов нет!")
        {
            try
            {

            }
            catch (JucierException)
            {
                Console.WriteLine("Фруктов нет");
            }
        }
    }
}
