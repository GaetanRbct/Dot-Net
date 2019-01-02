using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {           
            Random random = new Random();
            int k;
            k = random.Next(1, 50);
            int j = 0, l = 0;
            Console.WriteLine("Devinez: ");
            int.TryParse(Console.ReadLine(), out j);
            while (j != k)
            {
                if (j < 0 || j > 50)
                {
                    Console.WriteLine("Respectez les consignes, entrez un autre nombre ");
                    int.TryParse(Console.ReadLine(), out j);
                }


                else if (j < k)
                {
                    l++;
                    Console.WriteLine("Trop petit, entrez une nouvelle valeur \n");
                    int.TryParse(Console.ReadLine(), out j);


                }
                else
                {
                    l++;
                    Console.WriteLine("Trop grand, entrez une nouvelle valeur \n ");
                    int.TryParse(Console.ReadLine(), out j);
                    
                }

            }

            Console.WriteLine("C'est la bonne valeur, il vous aura fallu " + l + " tentatives");
            Console.ReadKey();
        }
    }
}

