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
            int x = 4;
            int y = 5;
            int z = 6;
            Console.WriteLine("Ma variable x vaut " + x + "\n Ma variable y vaut " + y + " \n ma variable z vaut " + z); // \n pour des retours à la ligne si écrit en trois phrases
            Console.WriteLine("resultat du calcul = " + (x + y) * z);
        }
    }
}
