using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string sexe; 
            Console.WriteLine("Quel est votre age?");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Quel est votre sexe?");
            sexe = (Console.ReadLine());

            if (age < 18 && age>0)
            { Console.WriteLine("Vous etes un(e) " + sexe + " et vous etes mineur(e)");                

            }
            else
            {
                Console.WriteLine("Vous êtes un(e) " + sexe + " et vous êtes majeur(e)");

                /*int age;
                 * int sex;
                 * Console.WriteLine("uelle est votre age? ");
                 * 
                 * int.TryParse(Console.ReadLine(), out age);
                 * Console.WriteLine("Homme ou femme?");
                 * sexe = Console.ReadLine();
                 * 
                 * if (age >= 18 && sexe == "femme")
                 *  {
                 *      Console.WriteLine("Vous êtes majeur et vous êtes une femme");
                 *   }
                 *  else if (age >= 18 && sexe == "homme")
                 *  {
                 *      Console.WriteLine("Vous êtes majeur et vous êtes un homme);
                 *   }
                 *  else if (age > 0 && sexe = femme)
                 *  {
                 *     Console.WriteLine("Vous êtes une femme et vous êtes mineur);
                 *  }
                 *  else if (age > 0 && sexe == "homme")
                 *  {
                 *      Console.WriteLine("Vous êtes un homme et vous êtes mineur");
                 *   }
                 *   Console.ReadKey() */
            }
        }
    }
}
