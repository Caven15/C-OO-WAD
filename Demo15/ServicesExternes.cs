using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo15
{
    public static class ServicesExternes
    {
        public static void LoggerDansFichier(int temp, string nom)
        {
            Console.WriteLine($"[LOG FICHIER] : {DateTime.Now} - Hors limite sir {nom} ({temp}°C)");
        }
    }
}
