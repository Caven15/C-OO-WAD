using Exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    public class Joueur
    {
        private List<CasePropriete> _proprietes;


        public CasePropriete[] Proprietes
        {
            get { return _proprietes.ToArray(); }
        }
        public string Nom { get; set; }
        public Pions Pion { get; set; }        
        public int Position { get; private set; }
        public int Solde { get; private set; }

        public Joueur(string nom, Pions pion)
        {
            Nom = nom;
            Pion = pion;
            Solde = 1500;
            _proprietes = new List<CasePropriete>();
        }

        // Opérateur 1 : Joueur + int           => Renvoie le joueur
        public static Joueur operator +(Joueur joueur, int montant)
        {
            joueur.EtrePayer(montant);
            return joueur;
        }

        // Opérateur 2 : Joueur + CasePropriete => CasePropriete[]
        //public static CasePropriete[] operator +(Joueur joueur, CasePropriete caseProp)
        //{
        //    caseProp.Acheter(joueur);
        //    return joueur.Proprietes;
        //}

        public bool Avancer()
        {
            //De.valeurMin = 1;
            //De.valeurMax = 6;
            int[] lances = De.Lancer(2);
            for (int i = 0; i < lances.Length; i++)
            {
                Position += lances[i];
            }
            return lances[0] == lances[1];
        }
        public void EtrePayer(int montant)
        {
            if (montant > 0)
            {
                Solde += montant;
            }
        }
        public void Payer(int montant)
        {
            if(montant > 0 && Solde >= montant)
            {
                Solde -= montant;
            }
        }
        public void AjouterPropriete(CasePropriete propriete)
        {
            if(propriete.Proprietaire == this && !_proprietes.Contains(propriete))
            {
                _proprietes.Add(propriete);
            }
        }
    }
}
