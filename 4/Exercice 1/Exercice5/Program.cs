using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi " , "Mardi " , "Mercredi " , "Jeudi " , "Vendredi " , "Samedi " , "Dimanche " };
            int i = 0;
            while (i < week.Length)
            {
                Console.WriteLine(week[i]);
                i++;
            }
        }
    }
}
/* Correction:
 * string[] week = new string[] { "Lundi " , "Mardi " , "Mercredi " , "Jeudi " , "Vendredi " , "Samedi " , "Dimanche " };
 * for(int indice = 0; indice < week.length; indice++) => inférieur strictement car démarre à 0
 * {Console.Writeline(week);}
