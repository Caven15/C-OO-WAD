using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12.Models
{
    public class Garage
    {
        #region Prop's
        private List<Vehicule> _Emplacements = new List<Vehicule>();
        public static int Numero { get; set; }
        #endregion

        #region Encapsulation
        public Vehicule this[int index]
        {
            get
            {
                if (index < _Emplacements.Count && index >= 0)
                {
                    return _Emplacements[index];
                }
                return null;
            }
            set
            {
                if (index < _Emplacements.Count && index >= 0)
                {
                    _Emplacements[index] = value;
                }
            }
        }

        #endregion

        #region Méthodes
        public void Ajouter(Vehicule voiture)
        {
            _Emplacements.Add(voiture);
        }
        #endregion
    }
}
