using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo06.Models
{
    public class Voiture
    {
        #region variables avec propriétés
        private string _immatriculation;
        public string Immatriculation
        {
            get
            {
                return _immatriculation;
            }
            private set
            {
                value = value.Trim();
                if (Regex.IsMatch(value, "^[\\dA-Z]-[A-Z]{3}-\\d{3}$"))
                {
                    _immatriculation = value;
                }
            }
        }
        private string _typeMoteur;
        public string TypeMoteur
        {
            get
            {
                return _typeMoteur;
            }
            private set
            {
                _typeMoteur = value;
                if (value == "Électrique")
                {
                    IsAutomatic = true;
                }
            }
        }
        #endregion
        #region Auto-propriétés
        public string Couleur { get; private set; }
        public ushort NbRoues { get; private set; } 
        public bool IsAutomatic { get; private set; }


        #endregion

        #region Constructeurs
        public Voiture(string immatriculation) : this(immatriculation, "Blanche") 
        { 
            //...
        }
        public Voiture(string immatriculation, string couleur) : this(immatriculation, couleur, "Inconnu")
        {
            //....
        }

        public Voiture(string immatriculation, string couleur, string typeMoteur, bool isAutomatic = false, ushort nbRoues = 4)
        {
            Immatriculation = immatriculation;
            Couleur = couleur;
            NbRoues = nbRoues;
            IsAutomatic = isAutomatic;
            TypeMoteur = typeMoteur;
        }
        #endregion

        #region Les méthodes
        #endregion
    }
}
