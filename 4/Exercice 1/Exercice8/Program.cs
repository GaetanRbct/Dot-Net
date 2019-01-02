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
            int[] pairs = new int[20]; // On déclare un tableau int de taille 20
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = i + 1; // On entre les entiers dans le tableau
            }
            foreach (int pair in pairs)
            {
                if (pair %2 == 0) // On vérifie si int/2=0
                {
                    Console.WriteLine(pair);
                }
            }
            Console.ReadKey();
        }
    }
}
