﻿using System;
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
            string name, firstname;
            int year = 0;
            int age = 0;
            Console.WriteLine("Entrer le nom");
            name = Console.ReadLine();
            Console.WriteLine("Entrer le prénom");
            firstname = Console.ReadLine();
            Console.WriteLine("Entrer l'age de naissance:");
            int.TryParse(Console.ReadLine(), out year);
            age = DateTime.Now.Year - year;
            Console.WriteLine("Nom: " + name + "\n Prenom: " + firstname + "\n Age:" + age);
        }
    }
}
