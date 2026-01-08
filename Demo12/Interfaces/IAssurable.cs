using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.Interfaces
{
    public interface IAssurable
    {
        public string NumeroPolice { get; set; }

        void CalculerPrime();
    }
}
