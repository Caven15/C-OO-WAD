using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11.Models
{
    public class Voiture : Vehicule
    {
        public Voiture(string marque) : base(marque){ }

        public override int Victoire { get; set; }

        public override void Lavage()
        {
            Console.WriteLine($"Lavage de la voiture {this.Marque}");
        }

        public override void PasserEntretien()
        {
            Console.WriteLine($"[VOITURE {Marque}] Nettoyage des injecteurs et vérification des pneus.");
        }
    }
}
