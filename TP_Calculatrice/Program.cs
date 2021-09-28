using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix = "";
            double valeur1 = 0, valeur2 = 0;
            double result;
            bool loop = true;


            //Affichage du menu
            Console.WriteLine("*************Calculatrice Console***************");
            Console.WriteLine("Choisir une opération");
            Console.WriteLine("Addition : taper a");
            Console.WriteLine("Soustraction : taper s");
            Console.WriteLine("Multiplication : taper m");
            Console.WriteLine("Division : taper d");

            do
            {
                Console.WriteLine("Faites votre choix");
                choix = Console.ReadLine();
            } while (!(choix == "a" || choix == "s" || choix == "d" || choix == "m"));

            switch (choix)
            {
                case "a":
                    Console.WriteLine("Donner la première valeur");
                    valeur1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Donner la deuxième valeur");
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("resultats :" + (valeur1 + valeur2));
                    break;

                case "s":
                    Console.WriteLine("Donner la première valeur");
                    valeur1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Donner la deuxième valeur");
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("resultats :" + (valeur1 - valeur2));
                    break;

                case "d":
                    Console.WriteLine("Donner la première valeur");
                    valeur1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Donner la deuxième valeur");
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("resultats :" + (valeur1 / valeur2));
                    break;

                case "m":
                    Console.WriteLine("Donner la première valeur");
                    valeur1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Donner la deuxième valeur");
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("resultats :" + (valeur1 * valeur2));
                    break;

            }

            //Récupérer le choix de l'utilisateur - si le choix n'est pas valide - on l'invite à faire un autre choix;
            /*choix = Console.ReadLine();
            while (loop == true )
            {
                switch (choix)
                {
                    case "a":
                        Console.WriteLine("Addition");

                        Console.WriteLine("Donner la première valeur");
                        valeur1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Donner la deuxième valeur");
                        valeur2 = Convert.ToInt32(Console.ReadLine());

                        result = valeur1 + valeur2;
                        Console.WriteLine("Resultats : " + result);
                        break;

                    case "s":
                        Console.WriteLine("Soustraction");

                        Console.WriteLine("Donner la première valeur");
                        valeur1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Donner la deuxième valeur");
                        valeur2 = Convert.ToInt32(Console.ReadLine());

                        result = valeur1 - valeur2;
                        Console.WriteLine("Resultats : " + result);
                        break;

                    case "m":
                        Console.WriteLine("Multiplication");

                        Console.WriteLine("Donner la première valeur");
                        valeur1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Donner la deuxième valeur");
                        valeur2 = Convert.ToInt32(Console.ReadLine());
                        result = valeur1 * valeur2;
                        Console.WriteLine("Resultats : " + result);
                        break;

                    case "d":
                        Console.WriteLine("Division");

                        Console.WriteLine("Donner la première valeur");
                        valeur1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Donner la deuxième valeur");
                        valeur2 = Convert.ToInt32(Console.ReadLine());
                        result = valeur1 / valeur2;
                        Console.WriteLine("Resultats : " + result);
                        
                        break;

                    default:
                        Console.WriteLine("Veuillez entrer un choix valide");
                        choix = Console.ReadLine();
                        break;
                }
                break;
            }*/

            

            //Maintenir la console active
            Console.ReadLine();
        }
    }
}
