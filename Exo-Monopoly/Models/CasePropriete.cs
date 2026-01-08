using Exo_Monopoly.Enums;
using Exo_Monopoly.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    public class CasePropriete : Case, IProprietaire
    {
        public Couleurs Couleur { get; private set; }
        public int Prix { get; private set; }
        public bool EstHypotequee { get; private set; }
        public Joueur? Proprietaire { get; private set; }
        public CasePropriete(string nom, Couleurs couleur, int prix) : base(nom)
        {
            Couleur = couleur;
            Prix = prix;
            this.EstHypotequee = false;
        }

        #region Méthodes
        private void Acheter(Joueur acheteur)
        {
            if (acheteur.Solde >= Prix)
            {
                acheteur.Payer(Prix);
                Proprietaire = acheteur;
                acheteur.AjouterPropriete(this);
            }
        }

        private void Sejourner(Joueur visiteur)
        {
            // Calcul pour le séjour...
            int montantSejour = (int)Math.Floor(Prix / 4.0);

            visiteur.Payer(montantSejour);
            Proprietaire?.EtrePayer(montantSejour);
        }

        public override void Activer(Joueur visiteur)
        {
            if (Proprietaire == null)
            {
                Acheter(visiteur);
            }
            else if (Proprietaire != visiteur)
            {
                Sejourner(visiteur);
            }
        }

        public void Hypothequer()
        {
            if (!this.EstHypotequee && this.Proprietaire != null)
            {
                this.EstHypotequee = true;
                // Propriétaire reçoit 50% du prix
                this.Proprietaire.EtrePayer((int)(this.Prix * 0.5));
            }
        }

        public void Deshypothequer()
        {
            if (this.EstHypotequee && this.Proprietaire != null)
            {
                // Propriétaire paye 60% du prix
                int cout = (int)(this.Prix * 0.6);

                this.Proprietaire.Payer(cout);
                this.EstHypotequee = false;
            }
        }

        #endregion

    }
}
