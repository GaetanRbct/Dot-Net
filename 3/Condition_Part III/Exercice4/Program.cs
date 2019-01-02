using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool login;
            bool password; 
            Console.WriteLine("Identifiant: "); bool.TryParse(Console.ReadLine(), out login);
            Console.WriteLine("Mot de Passe "); bool.TryParse(Console.ReadLine(), out password);

            if (login == true)
            {
                Console.WriteLine("Bienvenue");

            }
            else
            {
                Console.WriteLine("Identifiant incorrect");
            }
            
            if (password == true)
            {
                Console.WriteLine("Bienvenue");
            }
            else
            {
                Console.WriteLine("Mot de passe incorrect");
            }
            /* Correction
            String login = "lbh", login2, mdp = "123", mdp2;

            Console.WriteLine("Login");
            login2 = Console.ReadLine();
            Console.WriteLine("Mdp");
            mdp2 = Console.ReadLine();
            
            => On compare le log entré et le mdp
            if (login.Equals(login2) && mdp.Equals(mdp2)) => pas de == car login.Equals(login2) fait de même sans chercher la source
            {
                Console.WriteLine("Bienvenu à la Manu");
            }
            else
            {
                Console.WriteLine("Mauvaus identifiant ou mot de passe incorrect.");
            }
            Console.ReadKey(); */


        }
    }
}
