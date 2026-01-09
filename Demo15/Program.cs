namespace Demo15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrdinateurDeBord ordinateur = new OrdinateurDeBord();

            // Variable locale (au Main) (Inaccecible pour une méthode classique)
            int compteurAlerte = 0;
            string nomConducteur = "Jean";

            // 1. Ajout d'une méthodes classique
            ordinateur.TemperatureCritique += ServicesExternes.LoggerDansFichier;

            // 2. Ajout d'une méthode anonyme
            // Pourquoi c'est mieux ?
            // - On a accès à compteurAlerte et nomConducteur
            // - Le code qui sera spécifique à l'affichage console du main
            if (ordinateur.TemperatureCritique != null)
            {
                ordinateur.TemperatureCritique += delegate (int temp, string composant)
                {
                    compteurAlerte++; // On incrémente la variable du main

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"[ALERTE] n°{compteurAlerte} pour {nomConducteur} !!!");
                    Console.WriteLine($"[DANGER] : {composant} est en surchauffe à {temp}°C");
                    Console.ResetColor();
                };
            }

            // SIMULATION
            Console.WriteLine("--- Début du trajet ---");
            ordinateur.AnalyserCapteur("Huile Moteur", 85);     // Pas d'alerte
            ordinateur.AnalyserCapteur("Freins Avants", 120);   // Déclenche les DEUX méthodes
            ordinateur.AnalyserCapteur("Batterie", 120);        // Déclenche les DEUX méthodes

            Console.WriteLine($"\n Trajet terminé. Nombre total d'alertes traités : {compteurAlerte}");
            Console.ReadKey();

        }
    }
}
