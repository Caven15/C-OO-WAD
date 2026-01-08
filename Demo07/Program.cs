using System.Security.AccessControl;
using Demo07.Models;

namespace Demo07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.Ajouter(new Voiture("Civic"));
            garage.Ajouter(new Voiture("Peugeot", "208"));
            garage.Ajouter(new Voiture("Bmw","M5"));


            Console.WriteLine("--- État initial du garage ---");

            Console.WriteLine($"place 0 : {garage[0].Marque}");
            Console.WriteLine($"place 1 : {garage[1].Marque}");
            Console.WriteLine($"place 2 : {garage[2].Marque}");

            Console.WriteLine("\n--- Remplacement d'une voiture ---");

            garage[1] = new Voiture("Tesla", "Model 3");

            Console.WriteLine($"Nouvelle voiture place 1: {garage[1].Marque}");

            if (garage[99] == null)
            {
                Console.WriteLine("\nLa place 99 n'existe pas...");
            }

            Console.ReadLine();
        }
    }
}
