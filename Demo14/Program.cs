using Demo14.Exceptions;
using Demo14.Models;

namespace Demo14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Moteur moteur = new Moteur();

            try
            {
                moteur.Demarrer();
                moteur.Accelerer(20);
                moteur.Accelerer(30);
            }
            catch (SurchauffeMoteurExceptionn ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Erreur surchauffe] {ex.Message}");
                Console.WriteLine($"Température critique relevée : {ex.TemperatureActuelle} °C");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Erreur inconnue] Type : {ex.GetType().Name}");
                Console.WriteLine($"Message : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\n [Sécurité] Éxecution du protocle de protection...");
                if (moteur.EstEnMarche)
                {
                    moteur.Arreter();
                }
                Console.WriteLine("Système sécurisé");
            }

            Console.WriteLine("\nLe programme continue sans avoir crashé");
            Console.ReadLine();
        }
    }
}
