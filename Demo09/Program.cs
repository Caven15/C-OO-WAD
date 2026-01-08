using Demo09.Models;

namespace Demo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("BMW", "M5");
            Vehicule vehicule = new Vehicule("Mercedes");
            Camion camion = new Camion("Scania", 15);

            voiture.Rouler();
            vehicule.Rouler();
            camion.Rouler();
        }
    }
}
