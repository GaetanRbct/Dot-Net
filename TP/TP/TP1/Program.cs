using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Interprétation = new string[] { "Dénutrition", "Maigreur", "Corpulence normale", "Surpoids", "Obésité modérée",
            "Obésité sévère", "Obésité morbide ou massive" };


            double IMC; // déclarer IMC
            float poids, taille; // idem poids taille
            Console.WriteLine("Entrez votre poids en kg: ");
            float.TryParse(Console.ReadLine(), out poids); // Conversion du float en string
            Console.WriteLine("Entrez votre taille en m ");
            float.TryParse(Console.ReadLine(), out taille); // Conversion du float en string

            IMC = (poids / Math.Pow(taille, 2)); // Appliquation de la formule de l'IMC
            Console.WriteLine("Votre IMC s'élève à " + IMC + "\n");

            if (IMC > 0 && IMC < 16.5)
            {
                Console.WriteLine(Interprétation[0]);
            }
            else if (IMC >= 16.5 && IMC <18.5 )
                {
                Console.WriteLine(Interprétation[1]);
                }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine(Interprétation[2]);
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine(Interprétation[3]);
            }
            else if (IMC >= 30 && IMC < 35)
            {
                Console.WriteLine(Interprétation[4]);
            }
            else if (IMC >= 35 && IMC < 40)
            {
                Console.WriteLine(Interprétation[5]);
            }
            else if (IMC >=40)
            {
                Console.WriteLine(Interprétation[6]);
            }
            else
            {
                Console.WriteLine("Vous avez entré des valeurs incohérentes et vous n'êtes pas amusant(e) du tout ;-)");
            }
                Console.ReadKey();
        }
            
        }
    }
}
