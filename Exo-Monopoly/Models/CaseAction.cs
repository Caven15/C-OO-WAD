using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    public delegate bool CaseDelegate(Joueur joueur);
    internal class CaseAction : Case
    {
        private CaseDelegate _Action;
        public CaseAction(string nom, CaseDelegate action) : base(nom)
        {
            this._Action = action;
        }

        public override void Activer(Joueur visiteur)
        {
            // On exécute le délégué stocké dans _Action
            bool resultat = this._Action(visiteur);

            // On peut utiliser le résultat booléen pour logger le succès de l'action
            if (resultat)
            {
                Console.WriteLine($"L'action de la case '{this.Nom}' a bien été effectué avec succès pour {visiteur.Nom}");
            }
        }
    }
}
