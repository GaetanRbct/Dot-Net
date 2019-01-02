using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class GetValuesTest
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            String[] week = Enum.GetNames(typeof(Week)); // E et non e comme plus haut pour Enum car ici Enum est une méthode permettant plus de sugg.
            foreach (String day in week)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("\n");

            Console.WriteLine("La valeur 4 est "+ week[4] + "\n");
           
            


        }

    }
}
