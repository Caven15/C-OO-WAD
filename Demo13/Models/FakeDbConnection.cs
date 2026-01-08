using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13.Models
{
    public class FakeDbConnection : IDisposable
    {
        public string ChaineConnection { get; set; } = string.Empty;
        public bool EstOuverte { get; private set; } 

        public FakeDbConnection(string chaineConnetion)
        {
            ChaineConnection = chaineConnetion;
            Ouvrir();
        }

        #region Méthodes
        public void Ouvrir()
        {
            this.EstOuverte = true;
            Console.WriteLine($"[DB] Connexion établie vers : {ChaineConnection}");
        }

        public void Requete(string sql)
        {
            if (!EstOuverte) throw new InvalidOperationException("LA connexion est fermée !");
            Console.WriteLine($"[DB] Exécution de la requête : {sql}");
        }

        public void Dispose()
        {
            // C'est ici que l'on libère réelement la ressource
            Fermer();
        }

        private void Fermer()
        {
            EstOuverte = false;
            Console.WriteLine("[DB] Connexion fermée et ressources liberées");
        }
        #endregion
    }
}
