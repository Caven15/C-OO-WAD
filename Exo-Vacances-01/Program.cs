namespace Exo_Vacances_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lesson csharpOO = new Lesson("C# : Programmation Orienté Objet", new Person("Samuel", "Legrain"));

            ClassRoom wad25 = new ClassRoom("Web Applications Developpers 2025");
            int nbEleves = wad25.AjouterEleve("Coudyzer", "Laura");
            nbEleves = wad25.AjouterEleve("Krempolska", "Yuliia");
            nbEleves = wad25.AjouterEleve("Tran", "Chuong");
            nbEleves = wad25.AjouterEleve("Karmous", "Orsula");

            wad25.DonnerCours(csharpOO);

            Console.WriteLine($"Actuellement, chez les {wad25.Formation}, il y a {nbEleves} élèves :");
            foreach (Person eleve in wad25.Eleves)
            {
                Console.WriteLine($"\t- {eleve.Nom} {eleve.Prenom}");
            }
            if (wad25.AvoirCours)
            {
                Console.WriteLine($"Elles ont cours avec {wad25.Formateur.Nom} {wad25.Formateur.Prenom}");
            }
            else
            {
                Console.WriteLine($"Elles n'ont pas cours.");
            }
        }
    }
}
