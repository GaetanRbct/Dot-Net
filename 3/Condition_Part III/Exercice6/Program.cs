using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Renseignez le mois pr connaitre la saison: ");
            String month = Console.ReadLine();

            switch(month)
            {
                case "Janvier":
                    Console.WriteLine("C'est l'hiver!");
                    break;

                case "Février":
                    Console.WriteLine("C'est l'hiver!");
                    break;

                case "Mars":
                    Console.WriteLine("C'est l'hiver!");
                    break;

                case "Avril":
                    Console.WriteLine("C'est le printemps!");
                    break;

                case "Mai":
                    Console.WriteLine("C'est le printemps!");
                    break;

                case "Juin":
                    Console.WriteLine("C'est l'été!");
                    break;

                case "Juillet":
                    Console.WriteLine("C'est l'été!");
                    break;

                case "Aout":
                    Console.WriteLine("C'est l'été!");
                    break;

                case "Septembre":
                    Console.WriteLine("C'est l'été!");
                    break;

                case "Octobre":
                    Console.WriteLine("C'est l'automne!");
                    break;

                case "Novembre":
                    Console.WriteLine("C'est l'automnne!");
                    break;

                case "Decembre":
                    Console.WriteLine("C'est l'hiver!");
                    break;

                default:
                    Console.WriteLine("Le mois n'éxiste pas");
                    break;

            }
            Console.ReadKey();
        }
    }
}
