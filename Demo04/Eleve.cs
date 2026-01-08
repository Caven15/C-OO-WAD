using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    internal class Eleve
    {
        public string nom, prenom;
        public static string section;

        public string SePresenter()
        {
            return $"Je suis {prenom} {nom}. Je suis en section {Eleve.section}.";
        }

        public static string SePresenter(Eleve eleve)
        {
            return $"Voici {eleve.nom} {eleve.prenom}. Il est en section {Eleve.section}.";
        }
    }
}
