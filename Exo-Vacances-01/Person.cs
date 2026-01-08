using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Vacances_01
{
    public class Person
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public Person(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
    }
}
