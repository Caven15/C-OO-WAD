using Demo12.Interfaces;
using Demo12.Models;

namespace Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("BMW", "M5", 750);
            Voiture voiture2 = new Voiture("Honda", "Civic TypeR", 350);

            Console.WriteLine("------------------------------");

            voiture1[0] = "Climatisation";
            Console.WriteLine($"Option 0 de voiture 1 : {voiture1[0]}");

            int puissanceTotal = voiture1 + voiture2;
            Console.WriteLine($"Puissance total : {puissanceTotal} CV");

            Console.WriteLine("------------------------------");


            List<Vehicule> garage = new List<Vehicule>();
            garage.Add(voiture1);
            garage.Add(voiture2);
            garage.Add(new Camion("Volvo", 30.0));

            Console.WriteLine("Polymorphisme");
            foreach (Vehicule vehicule in garage)
            {
                Console.WriteLine("---");

                vehicule.Rouler(); // Appelle la bone version (Voiture ou Camion)

                if (vehicule is IEntretien objetMaintenable)
                {
                    objetMaintenable.EffectuerUneVidange();
                }

                if (vehicule is IAssurable objetAssurable)
                {
                    objetAssurable.CalculerPrime();
                }
                Console.WriteLine("---");

            }

            Console.WriteLine("------------------------------");
            Console.ReadLine();
        }
    }
}
