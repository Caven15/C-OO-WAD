using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exo_Monopoly.Models;

namespace Exo_Monopoly.Exceptions
{
    public class NotEnoughMoneyException : Exception
    {
        public Joueur Payeur { get; }
        public int Montant { get; }
        public CasePropriete Bien { get; }

        // Constructeur pour un payement simple (loyer)
        public NotEnoughMoneyException(Joueur payeur, int montant) : base($"{payeur.Nom} n’a pas su payer la somme de {montant}.")
        {
            this.Payeur = payeur;
            this.Montant = montant;
        }

        // Constructeur pour un achat immobilier (loyer)
        public NotEnoughMoneyException(Joueur payeur, int montant, CasePropriete bien) : base($"{payeur.Nom} n’a pas su payer la somme de\r\n{montant} pour acquérir le bien {bien.Nom}.")
        {
            this.Payeur = payeur;
            this.Montant = montant;
            this.Bien = bien;
        }

    }
}
