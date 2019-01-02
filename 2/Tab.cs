using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new String[] // S pour la forme et l'auto
                { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            foreach (String Day in week ) // pas de for pour alléger le code
            {
                Console.WriteLine(Day);
            }
        }
    }
}
