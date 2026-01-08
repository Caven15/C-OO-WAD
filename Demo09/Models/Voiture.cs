using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09.Models
{
    public class Voiture : Vehicule
    {
        public string Modele { get; set; }

        public Voiture(string marque, string modele) : base(marque)
        {
            Modele = modele;
        }

        // Redéfinir les méthodes
        public override void Rouler()
        {
            Console.WriteLine($"La voiture {Marque} {Modele} file silencieusement");
        }
    }
}
