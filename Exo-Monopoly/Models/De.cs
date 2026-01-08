using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Monopoly.Models
{
    public static class De
    {
        private static int _valeurMin = 1;
        private static int _valeurMax = 6;
        private static Random _rng = new Random();

        public static int ValeurMin
        {
            get
            {
                return _valeurMin;
            }
            set
            {
                if(value > 0)
                {
                    _valeurMin = value;
                    if(ValeurMin >= ValeurMax)
                    {
                        ValeurMax = value + 1;
                    }
                }
            }
        }

        public static int ValeurMax
        {
            get
            {
                return _valeurMax;
            }
            set
            {
                if (value > 1)
                {
                    _valeurMax = value;
                    if (ValeurMax <= ValeurMin)
                    {
                        ValeurMin = value - 1;
                    }
                }
            }
        }

        public static int[] Lancer(int nbDes)
        {
            int[] resultats = new int[nbDes];
            for (int i = 0; i < nbDes; i++)
            {
                resultats[i] = _rng.Next(_valeurMin, _valeurMax + 1);
            }
            return resultats;
        }
    }
}
