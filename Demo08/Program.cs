using Demo08.Models;

namespace Demo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("Peugeot", "208", 110);
            Voiture voiture2 = new Voiture("Bmw", "M5", 727);

            Console.WriteLine($" Voiture 1 : {voiture1.Marque}");
            Console.WriteLine($" Voiture 2 : {voiture2.Marque}");

            Console.WriteLine("\n--- Test suppresion Opérateur + ---");

            int puissanceTotale = voiture1 + voiture2;

            Console.WriteLine($"Puissance cumulée des voitures : {puissanceTotale}");

            if (voiture1 == voiture2)
            {
                Console.WriteLine("Les voiture sont de la même marque et modèle");
            }
            else
            {
                Console.WriteLine("LEs voitures son différentes...");
            }

            Test test = new Test();

        }
    }
}
