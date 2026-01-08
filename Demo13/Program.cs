using Demo13.Models;

namespace Demo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Le bloc Usin garantir l'appel à Dispose() => à la fin des accolades
                using (FakeDbConnection db = new FakeDbConnection("Server=GarageServer;Database=Voitures"))
                {
                    db.Requete("SELECT * FROM Voitures WHERE Marque = 'Tesla'");

                    // Simulation d'erreur pendant l'utilisation de la db
                    Console.WriteLine("[APP] Une erreur imprévue");
                    throw new Exception("Crash pendal la lecture des données");
                } // <- Appel de dispose

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CATCH] Erreur interceptée : {ex.Message}");
            }

            Console.WriteLine("--- Fin de programme ---");
            Console.ReadLine();
        }
    }
}
