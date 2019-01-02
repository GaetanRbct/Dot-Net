using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7
{
    class Program
    {
        static void Main(string[] args)
        {
            //double AB = 0; // Hypothénuse AB
            double AC = 0; // AC
            double BC = 0; // BC
            Console.WriteLine("Longueur de BC");
            double.TryParse(Console.ReadLine(), out BC);
           // if { double BC < 0;
                //do Console.WriteLine("Saisissez une valeure strictement positive")
                //};
        
            Console.WriteLine("Longueur de AC");
            double.TryParse(Console.ReadLine(), out AC);
            //if {
            // double AC < 0;
            //do Console.WriteLine("Saisissez une valeure strictement positive")};
            //     }

          Console.WriteLine("Lalongueur de l'hypothénuse est " + (Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2))));
        }
    }
}
