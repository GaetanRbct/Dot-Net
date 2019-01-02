using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Months = new String[] { "Janvier", "Février", "Mars", "Avril",
                "Mai", "Juin", "Juillet", "Aour", "October", "Novamber", "Dezember" }; // Déclaration d'un nouveau tableau de chaine de caractères

            foreach (string month in Months)
            {
                Console.WriteLine(month);
            }

            Console.ReadKey();
        }
    }
}
