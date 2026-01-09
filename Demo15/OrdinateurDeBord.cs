using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15
{
    // Définition du délégué : signature (int, string)
    public delegate void AlerteTemperature(int temperature, string composant);
    public class OrdinateurDeBord
    {
        // Le délégé qui servira de point d'entré pour les alertes
        public AlerteTemperature TemperatureCritique;

        public void AnalyserCapteur(string nom, int valeurLue)
        {
            Console.WriteLine($"[Analyse] {nom} : {valeurLue} °C");

            // si la température dépasse et qu'il y a des abonnés
            if (valeurLue > 100 && TemperatureCritique != null)
            {
                // Invocation de mon délégué (appelle toutes les méthodes liés)
                TemperatureCritique(valeurLue,nom);
            }
        }
    }
}
