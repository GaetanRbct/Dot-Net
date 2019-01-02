using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            double r; // rayon du cercle
            Console.WriteLine("Saisissez la valeur de r");
            double.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("Le périmètre du cercle est: " + 2 * Math.PI * r);
            Console.WriteLine("La surface du cercle est: " + (Math.PI) * Math.Pow(r,2));
        }


    }
}
