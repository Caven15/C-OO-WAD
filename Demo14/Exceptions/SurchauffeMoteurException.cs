using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14.Exceptions
{
    public class SurchauffeMoteurExceptionn : Exception
    {
        public int TemperatureActuelle { get; set; }

        public SurchauffeMoteurExceptionn(string message, int temp) : base(message)
        {
            TemperatureActuelle = temp;
        }
    }
}
