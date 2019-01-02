using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // On crée une variable qu'on initialise à 0 pour créer boucle
            while (i < 10) 
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message."); 
                i++; // On incrémente i
            }
            Console.ReadKey();
        }
    }
}
