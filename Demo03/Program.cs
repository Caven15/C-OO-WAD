namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maFerrari = new Voiture();
            maFerrari.couleur = "Rouge";
            maFerrari.marque = "Twingo";
            maFerrari.nbPortes = 3;
            maFerrari.nbRoues = 4;

            Console.WriteLine($"Fier, je viens d'acheter une {maFerrari.marque}, de couleur {maFerrari.couleur}, avec ses {maFerrari.nbPortes} portes et ses {maFerrari.nbRoues} roues!");

            Console.WriteLine("Je la présente à mes parents, là, ma maman dit qu'elle ressemble à une fraise.");

            Voiture laFraise = maFerrari;

            Console.WriteLine("En colère, je part à tout allure! Et BOUM! Je crashe ma voiture...");

            maFerrari.nbRoues--;

            Console.WriteLine($"Aïe! Aïe! Aïe! Ma ferrari n'a plus que {maFerrari.nbRoues} roues...");
            Console.WriteLine($"Mais combien de roues reste-t-il sur la fraise? {laFraise.nbRoues} roues...");
        }
    }
}
