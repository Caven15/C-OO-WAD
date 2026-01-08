using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    internal class Login
    {
        private DateTime _creationDate = DateTime.Now;
        public int Duration
        {
            get {
                DateTime now = DateTime.Now;
                TimeSpan delta = now - _creationDate;
                return (int)(delta.TotalMicroseconds/1000);
            }
        }
        public string Email { get; set; }
        private string _password;

        public string Password
        {
            /* première méthode, contourner la variable
            get {
                return "*******";
            }*/
            /* deuxième méthode, rendre notre get private
            private get
            {
                return _password;
            } */
            /* troisième méthode, c'est de ne pas mettre de get...*/
            set {
                value = value.Trim();
                _password = value;
            }
        }

        /* Exemple de propriété sans variable
        public string Bidon
        {
            get {
                return "Ceci est bidon";
            }
            set {
                Console.WriteLine(value);
            }
        }*/
        /* Plus besoin de la méthode car propriété définie
        public void SetNewPassword(string password)
        {
            _password = password;
        }*/

        public bool CheckPassword(string email, string password)
        {
            return Email == email && _password == password;
        }
    }
}
