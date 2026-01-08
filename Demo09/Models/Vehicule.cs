using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09.Models
{
    public class Vehicule
    {
        public string Marque { get; set; }

        public Vehicule(string marque)
        {
            Marque = marque;
        }

        public virtual void Rouler()
        {
            Console.WriteLine($"Le véhicule de marque {Marque} circule sur la route");
        }
    }
}
