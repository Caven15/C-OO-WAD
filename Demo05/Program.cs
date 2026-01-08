namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login()
            {
                Email = "samuel.legrain@bstorm.be"
            };
            Console.WriteLine(login.Duration);
            /* Exemple de propriété sans variable
            login.Bidon = "Toto";
            Console.WriteLine(login.Bidon);*/
            login.Password = "Test1234=";

            /*Mot de passe inaccessible, code plus fonctionnel
            Console.WriteLine($"Vos données de connection :\nIdentifiant : {login.email}\nMot de passe : {login._password}");*/

            Console.WriteLine($"Vos données de connection :\nIdentifiant : {login.Email}");

            Console.Clear();

            Console.WriteLine($"Veuillez vous identifier :");
            string email = Console.ReadLine()!;
            Console.WriteLine($"Veuillez introduire votre mot de passe :");
            string pwd = Console.ReadLine()!;
            if(login.CheckPassword(email, pwd))
            {
                Console.WriteLine("Bienvenue!");
            }
            else
            {
                Console.WriteLine("Compte bloqué...");
            }
            Console.WriteLine(login.Duration);
        }
    }
}
