using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_Monopoly.Interfaces;

namespace Exo_Monopoly.Models
{
    public abstract class Case : IVisiteur
    {
        #region Variables membres

        private List<Joueur> _Visiteurs;

        #endregion

        #region Prop's
        public string Nom { get; private set; }
        #endregion

        #region Encapsulation

        public Joueur[] Visiteurs
        {
            get
            {
                return _Visiteurs.ToArray();
            }
        }

        #endregion

        #region Constructeur(s)
        public Case(string nom)
        {
            Nom = nom;
            _Visiteurs = new List<Joueur>();
        }
        #endregion

        #region Méthodes
        public void AjouterVisiteur(Joueur visiteur)
        {
            if (!_Visiteurs.Contains(visiteur))
            {
                _Visiteurs.Add(visiteur);
                Activer(visiteur);
            }
        }

        public void RetirerVisiteur(Joueur visiteur)
        {
            _Visiteurs.Remove(visiteur);
        }

        public abstract void Activer(Joueur visiteur);
        #endregion
    }
}