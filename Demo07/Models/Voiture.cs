using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo07.Models
{
    public class Voiture
    {
        #region Prop's
        public string Marque { get; private set; }
        public string Modele { get; private set; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Construction d'une voiture
        /// </summary>
        /// <param name="modele"> ajout d'un modèle de la marque honda</param>
        public Voiture(string modele) : this(modele, "Honda")
        {
            //...
        }


        public Voiture(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
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
