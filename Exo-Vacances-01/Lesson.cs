using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Vacances_01
{
    internal class Lesson
    {
        private Person _formateur;
        private Person? _remplacant;
        public string Module { get; private set; }
        public Person Formateur
        {
            get
            {
                return _remplacant ?? _formateur;
            }
        }
        public Lesson(string module, Person formateur)
        {
            Module = module;
            _formateur = formateur;
        }

        public void DefinirRemplacant(Person remplacant)
        {
            _remplacant = remplacant;
        }

        public void FinRemplacement()
        {
            _remplacant = null;
        }
    }
}
