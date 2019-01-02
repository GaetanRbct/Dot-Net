using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] week = new string[]
            { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            for (int i = 0; i < week.Length; i++) 
            {
                Console.WriteLine(week[i]);

            }
        }
    }
}
