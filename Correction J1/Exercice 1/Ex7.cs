using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double AB = 0;
            double BC = 0;
            double CA = 0;
            Console.WriteLine("Entrez la valeur de BC");
            double.TryParse(Console.ReadLine(), out BC);
            Console.WriteLine("Entrez la valeur de CA");
            double.TryParse(Console.ReadLine(), out CA);
            AB = Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(CA, 2));
            Console.WriteLine("Hypothénuse = " + AB);
            Console.ReadKey();
        }
    }
}
