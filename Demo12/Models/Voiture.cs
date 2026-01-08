using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Demo12.Interfaces;

namespace Demo12.Models
{
    public class Voiture : Vehicule, IEntretien, IAssurable
    {
        #region Prop's
        public string Modele { get; set; }
        public int Puissance { get; set; }
        public string NumeroPolice { get; set ; }

        private List<string> _options = new List<string>();

        #endregion

        #region Constructeur
        public Voiture(string marque, string modele, int puissance) : base(marque)
        {
            Modele = modele;
            Puissance = puissance;
            Console.WriteLine($"[Voiture] initialisation du modèle et puissance : {modele} : {puissance} CV");

        }

        #endregion

        #region Indexeurs

        public string this[int index]
        {
            get
            {
                return (index >= 0 && index < _options.Count) ? _options[index] : "Options inconnue";
            }
            set
            {
                _options.Add(value);
            }
        }

        #endregion

        #region Surcharge opérateurs

        public static int operator +(Voiture voiture1, Voiture voiture2)
        {
            return voiture1.Puissance + voiture2.Puissance;
        }

        #endregion

        #region Méthodes

        public void CalculerPrime()
        {
            Console.WriteLine($"[ASSURANCE] Calcul pour la police {NumeroPolice}");
        }

        public void EffectuerUneVidange()
        {
            Console.WriteLine($"[MAINTENANCE] Vidange faite sur la {Modele}");
        }

        public override void Rouler()
        {
            Console.WriteLine($"La voiture {Marque} {Modele} file sur la route.");
        }

        #endregion
    }
}
