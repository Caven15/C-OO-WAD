using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo14.Exceptions;

namespace Demo14.Models
{
    public class Moteur
    {
        public int Temperature { get; set; } = 90;
        public bool EstEnMarche { get; set; }

        public void Demarrer()
        {
            EstEnMarche = true;
            Console.WriteLine("Moteur démaré");
        }

        // Accelerer
        public void Accelerer(int intensite)
        {
            if (!EstEnMarche)
            {
                throw new InvalidOperationException("Impossible d'accélérer, le moteur est éteint 🛑");
            }

            Temperature += intensite;

            if (Temperature > 120)
            {
                throw new SurchauffeMoteurExceptionn("Alerte ! LE moteur est trop chaud ⚠️", Temperature);
            }

            Console.WriteLine($"Vroum vroum, Température actuelle : {Temperature} °C");
        }

        // Areter
        public void Arreter()
        {
            EstEnMarche = false;
            Console.WriteLine("Moteur coupé");
        }

    }
}
