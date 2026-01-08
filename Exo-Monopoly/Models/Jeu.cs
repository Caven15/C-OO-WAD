using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_Monopoly.Enums;

namespace Exo_Monopoly.Models
{
    public class Jeu
    {
        private List<Joueur> _Joueurs;
        private List<Case> _Plateau;

        public Jeu(Case[] caseInitial)
        {
            _Plateau = new List<Case>(caseInitial);
            _Joueurs = new List<Joueur>();
        }

        public Joueur[] Joueurs => _Joueurs.ToArray();
        public Case[] Plateau
        {
            get { return _Plateau.ToArray(); }
        }



        public Case this[int numero]
        {
            get
            {
                if (numero < 0 || numero >= _Plateau.Count)
                {
                    throw new IndexOutOfRangeException("Numéro de case invalide !!!!");
                }
                return _Plateau[numero];
            }
        }


        public Joueur this[Pions pion]
        {
            get 
            { 
                return _Joueurs.FirstOrDefault(j => j.Pion == pion);

                //V2
                //foreach (var joueur in _Joueurs)
                //{
                //    if (joueur.Pion == pion)
                //    {
                //        return joueur;
                //    }
                //}
                //return null;
            }
        }

        public void AjouterJoueur(string nom, Pions pion)
        {
            if (this[pion] != null)
            {
                throw new InvalidOperationException($"Le pion {pion} est déjà pris par un autre joueur...");
            }

            _Joueurs.Add(new Joueur(nom, pion));
        }
    }
}
