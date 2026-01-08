using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Vacances_01
{
    internal class ClassRoom
    {
        private List<Person> _eleves;
        public Person[] Eleves
        {
            get { return _eleves.ToArray(); }
        }
        private Lesson? _lesson;
        public Person? Formateur
        {
            get
            {
                return _lesson?.Formateur;
            }
        }
        public bool AvoirCours
        {
            get
            {
                return _lesson is not null;
            }
        }
        public string Formation { get; private set; }
        public ClassRoom(string formation)
        {
            Formation = formation;
            _eleves = new List<Person>();
        }
        public void DonnerCours(Lesson lesson)
        {
            if(_lesson is null)
                _lesson = lesson;
        }
        public void FinirCours()
        {
            _lesson = null;
        }
        public int AjouterEleve(string nom, string prenom)
        {
            _eleves.Add(new Person(nom, prenom));
            return _eleves.Count;
        }
    }
}
