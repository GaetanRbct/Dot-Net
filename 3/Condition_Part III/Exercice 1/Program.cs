using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Créer une variable booléenne Rainy et lui attribuer les valeurs vrai/faux
            bool Rainy = true;

            /*if (Rainy)
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd'hui. Bonne journéee!");
            }

            else
            {
                Console.WriteLine("Slt, prends ton parapluie");
            }*/
           
            //Language ternaire expl "=" = if, ":" = else
            String message = Rainy ? "Slt, prends ton parapluie" : "y drache po biloute!";
            Console.WriteLine(message);


            Console.ReadKey();
        }
            
        }
    }
