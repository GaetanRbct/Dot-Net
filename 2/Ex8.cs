using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    class Program
    { 
        enum Week
        { Lundi = 1,
          Mardi,
          Mercredi,
          Jeudi,
          Vendredi,
          Samedi,
          Dimanche
        }

        static void Main(string[] args)
        {
            Week Lundi = (Week)1;
            Console.WriteLine("L'index 1 = " + Lundi + "\n");

            Week Valeur4 = (Week)4;
            Console.WriteLine("L'index 2 = " + Valeur4 + "\n");

            /* Autre solution: 
             * Console.WriteLine(Enum.GetName(typeof(week,4)));
             * Console.Readkey */
            
               
            
        }
    }
}
