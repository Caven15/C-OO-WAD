using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09.Models
{
    public class Camion : Vehicule
    {
        public double CapaciteTonnage { get; set; }

        public Camion(string marque, double tonnage) : base(marque)
        {
            CapaciteTonnage = tonnage;
        }

        public override void Rouler()
        {
            Console.WriteLine($"Le camion {Marque} de {CapaciteTonnage} tonnes transporte sa cargaison");
        }
    }
}
