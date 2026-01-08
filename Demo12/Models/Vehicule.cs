using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.Models
{
    public abstract class Vehicule
    {
        public string Marque { get; protected set; }

        protected Vehicule(string marque)
        {
            Marque = marque;
            Console.WriteLine($"[BASE] initialisation de la marque : {marque}");
        }

        public abstract void Rouler();
    }
}
