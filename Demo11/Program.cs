using Demo11.Models;

namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicule> garage = new List<Vehicule>();

            garage.Add(new Voiture("Honda"));
            garage.Add(new Camion("Toyota"));
            int count = 1;
            foreach (Vehicule vehicule in garage)
            {
                Console.WriteLine($"--- tour {count} ---");
                vehicule.PasserEntretien();
                vehicule.Lavage();
                count += 1;
                Console.WriteLine("---------------------");
            }

            Console.ReadLine();
        }
    }
}
