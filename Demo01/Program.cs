using Exo17;
using Demo02;
using Demo02.Enums;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"Voici le nom complet de ma class Console: System.Console");
            System.Int32 i = 5;
            object o = i; //Boxing : Convertion implicite : La variable o peut enmagaziner le type int
            System.Console.WriteLine($"Voici le nom complet de la class int : {typeof(int)}.");

            Console.WriteLine($"Voici le nom complet de ma class Console: System.Console");
            Int32 i2 = 5;
            object o2 = i2; //Boxing : Convertion implicite : La variable o peut enmagaziner le type int
            Console.WriteLine($"Voici le nom complet de la class int : {typeof(int)}.");

            Menu menu = new Menu();
            Demo02.DemoCard card = new DemoCard();
            card.color = CardColor.Diamonds;
            card.value = CardValue.Jack;
        }
    }
}
