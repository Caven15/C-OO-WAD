using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo12.Interfaces;

namespace Demo12.Models
{
    public class Camion : Vehicule, IEntretien
    {
        public double Tonnage { get; set; }

        public Camion(string marque, double tonnage) : base(marque)
        {
            Tonnage = tonnage;
            Console.WriteLine($"[Camion] initialisation du tonnage : {tonnage}");

        }

        #region Méthodes
        public void EffectuerUneVidange()
        {
            Console.WriteLine($"[MAINTENANCE] Vidange lourde pour le camion {Marque}");
        }

        public override void Rouler()
        {
            Console.WriteLine($"Le camion {Marque} de {Tonnage}T transporte sa cargaison.");
        }
        #endregion
    }
}
