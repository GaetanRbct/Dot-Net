using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string firstname;
            Console.WriteLine("Renseigner le nom");
            name = Console.ReadLine();
            Console.WriteLine("Renseigner le prénom");
            firstname = Console.ReadLine();

            Console.WriteLine("Bonjour" + name + " " + firsname + " nous sommes le " + DateTime.Now.Day + " " + DateTime.Now.Month + " " + DateTime.Now.Year + ", comment allez vous?");
            Console.ReadKey();
    }
}
