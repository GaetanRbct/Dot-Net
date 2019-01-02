using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Ta kel age?");
            int.TryParse(Console.ReadLine(), out age); // Vérifier que l'age renseigné est entre 0 et 17

            if (age < 18 && age>0)
            {
                Console.WriteLine("Mineur");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Majeur");
            }
            else // On gère le cas ou la saisie est incorrecte
            {
                Console.WriteLine("C'est pas drole frr");
            }
        }
    }
}
