using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08.Models
{
    public class Voiture
    {
        #region Prop's
        public string Marque { get; private set; }
        public string Modele { get; private set; }
        public int Puissance { get; set; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Construction d'une voiture
        /// </summary>
        /// <param name="modele"> ajout d'un modèle de la marque honda</param>
        public Voiture(string modele) : this(modele, "Honda", 0)
        {
            //...
        }


        public Voiture(string marque, string modele, int puissance)
        {
            Marque = marque;
            Modele = modele;
            Puissance = puissance;
        }
        #endregion

        #region Surcharge opérateur

        /// <summary>
        /// Permet d'aditionner le total de la puissance des 2 voitures
        /// </summary>
        /// <param name="voiture1">voiture 1</param>
        /// <param name="voiture2">voiture 2</param>
        /// <returns>Total calculé sur la puissance</returns>
        public static int operator +(Voiture voiture1, Voiture voiture2)
        {
            return voiture1.Puissance + voiture2.Puissance;
        }

        /// <summary>
        ///  Considéré deux voiture égales si elle on la même marque et le même modèles
        /// </summary>
        public static bool operator ==(Voiture voiture1, Voiture voiture2)
        {
            // Gestion des cas null pour éviter les soucis de crash
            if (ReferenceEquals(voiture1, null) || ReferenceEquals(voiture2, null))
            {
                return ReferenceEquals(voiture1, voiture2);
            }

            return voiture1.Marque == voiture2.Marque && voiture1.Modele == voiture2.Modele;
        }

        // Obligation de surcharger != si on surcharge le ==
        public static bool operator !=(Voiture voiture1, Voiture voiture2)
        {
            return !(voiture1 == voiture2);
        }

        #endregion

        #region Méthodes
        public void Decsription()
        {
            Console.WriteLine($"Voiture de marque {Marque} {Modele}");
        }
        #endregion
    }
}
