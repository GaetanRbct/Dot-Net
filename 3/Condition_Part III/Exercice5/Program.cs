using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection fujita = new NameValueCollection(); // Tableau associatif

            fujita.Add("F0","Dégats légers");
            fujita.Add("F1", "Dégats modérés");
            fujita.Add("F2", "Dégats importants");
            fujita.Add("F3", "Dégats considérables");
            fujita.Add("F4","Dégats dévastateurs");
            fujita.Add("F5", "Dégats incroyables");




            Console.WriteLine("Entrez le type de tornade entre F0 et F5 ");
            string F = Console.ReadLine();
            Console.WriteLine(fujita["fO"]);
            if (F == "F0")
                Console.WriteLine(fujita["F0"]);
            else if (F == "F1")
                Console.WriteLine(fujita["F1"]);

            [......]

            else if (F==F5)
                Console.WriteLine(fujita["F5"]);
            Console.ReadKey();

        



        }




    }
}
        