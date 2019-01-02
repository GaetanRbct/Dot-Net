using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10 ) // Le message s'affichera de 1 à 10
            {
                i++; // on incrémente i
                Console.WriteLine("Bonjour, je ne suis qu'un simple message n°"+ i);
                
            }
            Console.ReadKey();
        }
    }
}
