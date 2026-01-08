using Demo06.Models;

namespace Demo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("1-ABC-123","Rouge","Électrique",true, 5);

            Console.WriteLine(
@$"Nous venons d'enregistrer cette voiture :
Immatriculation : {v1.Immatriculation}
Couleur : {v1.Couleur}
Moteur : {v1.TypeMoteur} (Boîte {((v1.IsAutomatic)?"Automatique" : "manuelle")})
Nombre de roues : {v1.NbRoues} roues");

            Voiture v2 = new Voiture("1-DEF-123", "Bleue");

            Console.WriteLine(
@$"Nous venons d'enregistrer cette voiture :
Immatriculation : {v2.Immatriculation}
Couleur : {v2.Couleur}
Moteur : {v2.TypeMoteur} (Boîte {((v2.IsAutomatic) ? "Automatique" : "manuelle")})
Nombre de roues : {v2.NbRoues} roues");

        }
    }
}
