namespace Demo04
{
    internal class Program
    {
        static string ProgramName = "Démonstration 04";
        static ConsoleColor fontColor = ConsoleColor.Cyan;
        static ConsoleColor backColor = ConsoleColor.DarkRed;
        static void Main(string[] args)
        {
            Console.BackgroundColor = backColor;
            Console.ForegroundColor = fontColor;
            Console.WriteLine(Program.ProgramName);
            Eleve e1 = new Eleve();
            e1.nom = "Cruise";
            e1.prenom = "Tom";

            Eleve e2 = new Eleve()
            {
                nom = "Hanks",
                prenom = "Tom"                
            };

            Eleve.section = "Wad 25";

            RainbowConsole.WriteLine(e1.SePresenter());
            RainbowConsole.WriteLine(Eleve.SePresenter(e2));
        }
    }
}
