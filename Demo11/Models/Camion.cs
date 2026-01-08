using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11.Models
{
    public class Camion : Vehicule
    {

        public Camion(string marque) : base(marque) { }
        public int Test { get; set; } = 5;
        public override int Victoire { get; set; }

        public override void Lavage()
        {
            Console.WriteLine($"Lavage du camion {this.Marque}");
        }

        public override void PasserEntretien()
        {
            Console.WriteLine($"[CAMION {Marque}] Vidange du système hydraulique et controle du tachygraphe");
        }
    }
}
