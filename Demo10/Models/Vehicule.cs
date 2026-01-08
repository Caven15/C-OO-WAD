using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.Models
{
    public abstract class Vehicule
    {
        public string Marque { get; set; }

        public Vehicule(string marque)
        {
            Marque = marque;
        }

        public virtual void PasserEntretien()
        {
            Console.WriteLine($"Vérification standard du véhicule {Marque}...");
        }
    }
}
